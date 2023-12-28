# Basit TCP/IP Sohbet Uygulaması

## Türkçe Kullanım

### Kurulum Adımları
1. Projeyi Visual Studio'da açın.
2. `ClientIO` projesindeki `Program.cs` dosyasında `IpAdrress` değişkenini kendi IP adresinizle değiştirin.
3. `ClientIO` projesindeki `client` nesnesinin port kısmını kendi port bilginizle değiştirin.
4. `ServerIO` projesindeki `port` değişkenini kendi port bilginizle değiştirin.
5. Solution ayarlarında, "Properties"e tıklayın.
6. "Multiple startup project" özelliğini seçin ve `ClientIO` ve `ServerIO` projelerinin "Action" özelliklerini "Start" yapın. Bu şekilde iki proje aynı anda çalışacaktır.
   
### Kullanım
- Sunucu, belirtilen portta (varsayılan olarak 9080) dinlemeye başlayacaktır.
- Sunucu, istemcilerin bağlantılarını kabul edecek ve iletilen mesajları diğer istemcilere iletecektir.
- İstemci, sunucu IP adresini girmenizi isteyecektir. Varsayılan olarak 127.0.0.1 (yerel) kullanılabilir.
- İstemci, sunucuya bağlandıktan sonra bir mesaj girmenizi isteyecek ve bu mesajı sunucuya iletecektir.
- Sunucudan gelen yanıtı görebilirsiniz.


### Notlar
- Kodun anlaşılması ve geliştirilmesi için yorum satırları eklenmiştir.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## English Usage

### Installation Steps
1. Open the project in Visual Studio.
2. Replace the `IpAdrress` variable with your own IP address in the `Program.cs` file of the `ClientIO` project.
3. Modify the port part of the `client` object in the `ClientIO` project to match your specific port.
4. Update the `port` variable in the `ServerIO` project to reflect your desired port.
5. Access Solution settings and click on "Properties."
6. Select the "Multiple startup project" feature and set the "Action" properties of the `ClientIO` and `ServerIO` projects to "Start" for simultaneous execution.

### Usage
- The server will begin listening on the specified port (default is 9080).
- Incoming connections from clients will be accepted, and the server will relay transmitted messages among connected clients.
- The client will prompt for the server's IP address. By default, 127.0.0.1 (localhost) can be used.
- After connecting to the server, the client will request a message to send.
- You can see the response received from the server.

### Notes
- Comment lines have been added to aid in understanding and development of the code.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Görseller / Images

![image](https://github.com/ZeynepSlhoglu/SocketIO/assets/58303082/97b23870-fe7e-47ad-b92e-03d3aac7eb52)

![image](https://github.com/ZeynepSlhoglu/SocketIO/assets/58303082/582097cc-7743-4c68-bf0b-edd2f7193dad)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
