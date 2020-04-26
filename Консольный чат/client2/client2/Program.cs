using System;
using System.Net.Sockets;
using System.Text;


namespace client2
{
    class Program
    {
        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 16243;
        static TcpClient client;
        static NetworkStream stream;
        static bool connetcion;

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
            Environment.Exit(0);
        }
        static void SendMessage()
        {


            string message = Console.ReadLine();
            var data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);


        }
        static void ReceiveMessage()
        {
            try
            {
                byte[] data = new byte[64];
                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                string message = builder.ToString();
                if (message == "ERROR")
                    connetcion = false;
                Console.WriteLine(message);
            }
            catch
            {
                Console.WriteLine("Подключение прервано!");
                Console.ReadLine();
                Disconnect();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя: ");
            userName = Console.ReadLine();
            client = new TcpClient();
            try
            {
                client.Connect(host, port);
                connetcion = true;
                stream = client.GetStream();
                string message = userName;
                var data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Введите .quit для выхода. . .");
                Console.WriteLine("Введите сообщение");
                while (true)
                {
                    if (stream.DataAvailable)
                        ReceiveMessage();
                    if (Console.KeyAvailable)
                        SendMessage();
                    if (connetcion == false)
                        return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Disconnect();
            }


        }
    }
}
