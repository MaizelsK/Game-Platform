using System.Net.Sockets;

namespace ServerApp
{
    public class Client
    {
        public TcpClient TcpClient { get; set; }
        public NetworkStream Stream { get; set; }

        public void CloseConnection()
        {
            Stream.Close();
            TcpClient.Close();
        }
    }
}
