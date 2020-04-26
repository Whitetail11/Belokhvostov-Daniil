using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Client
    {
        internal string Id { get; set; }
        internal NetworkStream stream { get; set; }
        public string UserName;
        public TcpClient client;
        Server server;
        public bool connection;

        public Client(TcpClient client, Server server)
        {
            Id = Guid.NewGuid().ToString();
            this.client = client;
            this.server = server;
            server.AddConnection(this);
            server.connected = true;
        }

        public void NameUser()
        {
                stream = client.GetStream();
                string message = GetMessage();
                for (int i = 0; i < server.clients.Count; i++)
                {
                    if (message == server.clients[i].UserName)
                    {
                    message = "ERROR";
                    var response = System.Text.Encoding.UTF8.GetBytes(message);
                    stream.Write(response,0,response.Length);
                    server.connected = false;
                    server.RemoveConnection(this.Id);
                    Close();
                    return;
                    }
                }
                UserName = message;
                message = UserName + " вошёл в чат";
                server.BroadcastMessage(message, Id);
                Console.WriteLine(message);
        }

        public void Process()
        {
            string message;
            try
            {
                if (stream.DataAvailable)
                {
                    message = GetMessage();
                    if (message == ".quit")
                    {
                        message = string.Format("{0} покинул чат", UserName);
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                        server.RemoveConnection(this.Id);
                        Close();
                        return;
                    }
                    message = string.Format("{0} : {1}", UserName, message);
                    Console.WriteLine(message);
                    server.BroadcastMessage(message, this.Id);
                }

            }
            catch
            {
                message = string.Format("{0} покинул чат", UserName);
                Console.WriteLine(message);
                server.BroadcastMessage(message, this.Id);
            }
        }
        public void Close()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }
        string GetMessage()
        {
            var data = new byte[256];
            StringBuilder stringBuilder = new StringBuilder();
            var bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                stringBuilder.Append(System.Text.Encoding.UTF8.GetString(data, 0, bytes));
            } while (stream.DataAvailable);
            return stringBuilder.ToString();
        }
    }
    class Server
    {
        static TcpListener listener;
        public bool connected;
        public List<Client> clients = new List<Client>();
        public void AddConnection(Client client)
        {
            clients.Add(client);
        }
        public void RemoveConnection(string id)
        {
            Client client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
                clients.Remove(client);
        }
        public void Listen()
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 16243);
                listener.Start();
                Console.WriteLine("Server is working. Waiting for connection . . .");
                while(true)
                {
                    if (listener.Pending())
                    {
                        TcpClient tcpClient = listener.AcceptTcpClient();
                        Client client = new Client(tcpClient, this);
                    }
                    for(int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].UserName == null)
                        {
                            clients[i].NameUser();
                            if (connected == false)
                                i--;
                        }
                            clients[i].Process();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Disconnect();
            }
        }
        public void Disconnect()
        {
            listener.Stop();
            for(int i = 0; i<clients.Count;i++)
            {
                clients[i].Close();
            }
            Environment.Exit(0);
        }
        public void BroadcastMessage(string message, string id)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
            for(int i = 0; i < clients.Count; i++)
            {
               
                    if (clients[i].Id != id)
                    {
                        clients[i].stream.Write(data, 0, data.Length);
                    }
                
            }
        }
    }
    class Program
    {
        static Server server;
        static void Main(string[] args)
        {
            try
            {
                server = new Server();
                server.Listen();
            }
            catch(Exception e)
            {
                server.Disconnect();
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
