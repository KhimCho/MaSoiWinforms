using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Server
{
    class Program
    {
        private static IPEndPoint IP;
        private static Socket server;
        private static List<Player> connectPlayers = new List<Player>();
        private static Socket client;
        
        static void Main(string[] args)
        {
            Console.WriteLine("=> Listen for connection...\n");
            IP = new IPEndPoint(IPAddress.Any, 25465);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        client = server.Accept();
                        var endPoint = (IPEndPoint)client.RemoteEndPoint;
                        Console.WriteLine("=> Connection from " + endPoint+"\n");
                        Thread receive = new Thread(() => HandleReceive(client));
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 25465);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });

            listen.IsBackground = true;
            listen.Start();
        }
        public static void HandleReceive(Socket client)
        {
            Player p = new Player();
            p.playerSocket = client;
            connectPlayers.Add(p);
            byte[] bytes = new byte[1024];
            while (p.playerSocket.Connected)
            {
                if (p.playerSocket.Available > 0)
                {
                    // nhận lệnh control từ client
                    //.....
                    //xử lý control
                    
                }
            }

        }

        private static void HandleControl(string msg, Player p)
        {
            string[] payload = msg.Split(';');
            // payload[0] msg type
            // payload[1] playername
            
        }

        private void addMessage(string v)
        {
            
        }

        private static string Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return (string)bf.Deserialize(ms);
        }
    }
}