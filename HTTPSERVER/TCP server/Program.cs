using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TCP_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple server");
            try
            {
                //HttpListener listener = new HttpListener();
                //listener.Prefixes.Add("http://127.0.0.1:13204/");
                //listener.Start();
                //Console.WriteLine("Ожидание подключений");
                //while (true)
                //{
                //    HttpListenerContext context = listener.GetContext();
                //    HttpListenerRequest request = context.Request;
                //    HttpListenerResponse response = context.Response;
                //    string responseM = "<html><head><meta charset='utf8'></head><body>Hello webserver</body></html>";
                //    byte[] buffer = System.Text.Encoding.ASCII.GetBytes(responseM);
                //    response.ContentLength64 = buffer.Length;
                //    Stream output = response.OutputStream;
                //    output.Write(buffer, 0, buffer.Length);
                //    output.Close();
                //    listener.Stop();
                //    Console.WriteLine("Обработка подключений завершена");
                //    Console.Read();
                //}
                var port = 12000;
                var localAddr = IPAddress.Any;
                var server = new TcpListener(localAddr, port);
                server.Start();
                var bytes = new Byte[512];
                while (true)
                {
                    Console.WriteLine("Waiting for connection . . .");
                    var client = server.AcceptTcpClient();
                    Console.WriteLine("Accepted connection from {0}", client.Client.RemoteEndPoint);
                    NetworkStream stream = client.GetStream();
                    StreamWriter writer = new StreamWriter(stream);
                    var bytesReadCount = stream.Read(bytes, 0, bytes.Length);
                    var data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesReadCount);
                   
                    var msg = "<html><head><meta charset='utf8'></head><body>Hello webserver</body></html>";

                    writer.Write("HTTP/1.0 200 OK");
                    writer.Write(Environment.NewLine);
                    writer.Write("Content-Type: text/html; charset=UTF-8");
                    writer.Write(Environment.NewLine);
                    writer.Write("Content-Length: " + msg.Length);
                    writer.Write(Environment.NewLine);
                    writer.Write(Environment.NewLine);
                    writer.Write(msg);
                    writer.Flush();
                    //var res = System.Text.Encoding.ASCII.GetBytes("HTTP/1.1 200 OK\r\nServer: danyaserv/1.1\r\nContent-Language: ru\r\nContent-Type: text/html\r\nAccept-Ranges: bytes\r\nContent-Lenght: 75\r\nConnection: close\r\nAccept-Encoding: gzip, deflate\r\n\r\n");
                    //stream.Write(res, 0, res.Length);
                    //writer.WriteLine(String.Format("HTTP/1.0 200 OK\r\nDate: {0}\r\nServer: danyaserv/1.1\r\nContent-Language: ru\r\nContent-Type: text/html\r\nAccept-Ranges: bytes\r\nContent-Lenght: {1}\r\nConnection: Close\r\n\r\n<html><head><meta charset='utf8'></head><body>Hello webserver</body></html>", DateTime.Now, msg.Length));
                    //writer.Flush();
                    // stream.Write(msg, 0, msg.Length);
                    Console.WriteLine("Recived: {0}", data);
                    
                    //Console.WriteLine("Sent : {0}", ms);
                    Console.WriteLine("sent: HTTP/1.1 200 OK\r\nServer: danyaserv/1.1\r\nContent-language: ru\r\nContent-type: text/html\r\nAccept-Ranges: bytes\r\nContent-Lenght: {0}\r\nConnection: close\r\n", msg.Length);
                    writer.Close();
                    stream.Close();
                    
                }
            }                
                    
            catch(Exception e)
            {
                Console.WriteLine("Exception {0}", e);
            }
        }
    }
}
