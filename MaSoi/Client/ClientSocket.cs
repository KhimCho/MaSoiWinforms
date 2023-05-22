using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public class ClientSocket
    {
        public static IPEndPoint IP; 
        public static Socket client;
        public static string datatype = "";
        public static Socket clientSocket;
        
        public static void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 25465);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch {
                MessageBox.Show("Khong the ket noi!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(HandleReceive);
            listen.IsBackground = true;
            listen.Start();
        }
        private static void HandleReceive()
        { }
    }
}