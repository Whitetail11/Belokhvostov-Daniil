﻿using System;
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
          
            var massage = "GET / HTTP/1.0\n\n";
            try
            {
                var port = 80;
                var serverAddr = "selin.in.ua";
                var Client = new TcpClient(serverAddr, port);
                var data = System.Text.Encoding.ASCII.GetBytes(massage);
                NetworkStream stream = Client.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent {0}", massage);

                var responceData = new StringBuilder();
                Console.WriteLine("Введите имя файла в который записать: ");
                string fileName = Console.ReadLine();
                FileStream aFile = new FileStream(fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(aFile);
                aFile.Seek(0, SeekOrigin.End);
                var data1 = new byte[32];
                do
                {
                    int bytes = stream.Read(data1, 0, data1.Length);
                    var res = System.Text.Encoding.ASCII.GetString(data1, 0, bytes);
                    //responceData.Append(res);
                    if (res.IndexOf("<html") != -1)
                    {
                        sw.Write(res);
                        do
                        {
                            bytes = stream.Read(data1, 0, data1.Length);
                            res = System.Text.Encoding.ASCII.GetString(data1, 0, bytes);
                            sw.Write(res);
                        } while (stream.DataAvailable);
                        break;
                    }

                } while (stream.DataAvailable);
                sw.Close();

               // Console.WriteLine("Recived {0}", responceData);
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
