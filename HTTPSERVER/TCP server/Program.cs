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
                HttpListener listener = new HttpListener();
                listener.Prefixes.Add("http://127.0.0.1:13204/");
                listener.Start();
                Console.WriteLine("Ожидание подключений");
                while(true)
                {
                    HttpListenerContext context = listener.GetContext();
                    HttpListenerRequest request = context.Request;
                    HttpListenerResponse response = context.Response;
                    string responseM = "<html><head><meta charset='utf8'></head><body>Hello webserver</body></html>";
                    byte[] buffer = System.Text.Encoding.ASCII.GetBytes(responseM);
                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer,0,buffer.Length);
                    output.Close();
                    listener.Stop();
                    Console.WriteLine("Обработка подключений завершена");
                    Console.Read();
                }
               /* var port = 19539;
                var localAddr = IPAddress.Parse("127.0.0.1");
                var server = new TcpListener(localAddr, port);
                server.Start();
                var bytes = new Byte[256];
                while (true)
                {
                    Console.WriteLine("Waiting for connection . . .");
                    var client = server.AcceptTcpClient();
                    Console.WriteLine("Accepted connection from {0}", client.Client.RemoteEndPoint);
                    NetworkStream stream = client.GetStream();
                    var bytesReadCount = stream.Read(bytes, 0, bytes.Length);
                    var data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesReadCount);
                    data = data.ToUpper();
                    var response = System.Text.Encoding.ASCII.GetBytes("your massage is taken");
                    stream.Write(response, 0, response.Length);
                    Console.WriteLine("Sent : your massage is taken");
                    client.Close();

                }*/
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception {0}", e);
            }
        }
    }
}
