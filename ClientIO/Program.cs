using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientIO
{
    class Program
    {
        // ClientIO: Sunucuya mesaj gönderen istemci tarafı
        static async Task Main(string[] args)
        {
            try
            {
                string IpAdrress = "10.20.0.68"; // Sunucu IP adresi
                bool done = true;

                while (done)
                {
                    string Message = "";
                    Console.WriteLine("Mesaj yazın");
                    Message = Console.ReadLine();
                    TcpClient client = new TcpClient(IpAdrress, 9080); // Sunucuya bağlantı oluşturma

                    if (!string.IsNullOrEmpty(Message))
                    {
                        // Mesajı baytlara dönüştürme
                        int byteCount = Encoding.UTF8.GetByteCount(Message);
                        byte[] sendData = new byte[byteCount];
                        sendData = Encoding.UTF8.GetBytes(Message);

                        // Sunucuya mesajı gönderme
                        using (var networkStream = client.GetStream())
                        {
                            await networkStream.WriteAsync(sendData, 0, sendData.Length);
                        }
                    }
                    client.Close(); // Bağlantıyı kapatma
                }
                Console.WriteLine(IpAdrress + " cihaza bağlanıldı 😉");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cihaza bağlanılamadı " + ex.Message); // Bağlantı hatası durumunda hata mesajı gösterme
            }
        }

    }
}
