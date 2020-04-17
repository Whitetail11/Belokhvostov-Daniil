using System;
using System.Dynamic;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вебсайт:");
            var website = Console.ReadLine();
            Console.WriteLine("Введите имя файла в который записать: ");
            string fileName = Console.ReadLine();
            var http = website.IndexOf("http://");
            if (http != -1)
                website = website.Substring(http + 7);
            var massage = $"GET / HTTP/1.0\r\nHost: {website}\r\n\r\n";
            try
            {
                var port = 80;
                var serverAddr = website;
                var Client = new TcpClient(serverAddr, port);
                var data = System.Text.Encoding.ASCII.GetBytes(massage);
                NetworkStream stream = Client.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent {0}", massage);

                var responceData = new StringBuilder();
               
                FileStream aFile = new FileStream(fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(aFile);
                aFile.Seek(0, SeekOrigin.End);
                var data1 = new byte[256];
                do
                {
                    int bytes = stream.Read(data1, 0, data1.Length);
                    var res = System.Text.Encoding.ASCII.GetString(data1, 0, bytes);
                    responceData.Append(res);
                } while (stream.DataAvailable);
                
                responceData.Remove(0, responceData.ToString().IndexOf("\n\r\n") + 2);
                sw.Write(responceData);
                sw.Close();

                Console.WriteLine("Recived\n {0}", responceData);
                stream.Close();
                Client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exceprion {0}", e);
            }
            Console.WriteLine("Press any key . . .");
            Console.Read(); 
        }
    }
}
