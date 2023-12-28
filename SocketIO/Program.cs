using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerIO
{
    class Program
    {
        // ServerIO: İstemciden gelen mesajları alan ve işleyen sunucu tarafı

        static async Task Main(string[] args)
        {
            bool done = false;
            int port = 9080; // Kullanılan port numarası
            IPAddress adress = IPAddress.Any; // Tüm IP adreslerini kabul et
            TcpListener server = new TcpListener(adress, port); // Bağlantıları dinlemek için TcpListener oluşturma
            server.Start(); // Sunucuyu başlatma
            var loggedNoRequest = false;

            while (!done)
            {
                if (!server.Pending())
                {
                    if (!loggedNoRequest)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Henüz bekleyen istek yok."); // Bekleyen istek yoksa mesaj gösterme
                        Console.WriteLine("Server dinlemede");
                        loggedNoRequest = true;
                    }
                }
                else
                {
                    byte[] bytes = new byte[1024];
                    using (var client = await server.AcceptTcpClientAsync())
                    {
                        using (var tcpStream = client.GetStream())
                        {
                            await tcpStream.ReadAsync(bytes, 0, bytes.Length); // İstemciden gelen mesajı okuma
                            var requestMessage = Encoding.UTF8.GetString(bytes).Replace("@\0", string.Empty);
                            Console.WriteLine();
                            Console.WriteLine("Client mesaj alındı.");
                            string data = requestMessage.Replace("@\0\0", string.Empty);
                            data = new string(data.Where(c => !char.IsControl(c)).ToArray());
                            Console.WriteLine(data); // Gelen mesajı ekrana yazdırma
                        }
                    }
                }
            }
            server.Stop(); // Sunucuyu durdurma
            Thread.Sleep(3000);
        }

    }
}
