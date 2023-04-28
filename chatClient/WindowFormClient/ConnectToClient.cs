
using System.IO;
using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace chatui
{
    public static class ConnectToClient
    {
       
        
       
        public static Task connect(String ip)
        {
            String[] ipAdd = ip.Split(':');
            return Task.Run(() => {
                try
                {
                    TcpClient client = new TcpClient(ipAdd[0], int.Parse(ipAdd[1]));
                    Controller.stream = client.GetStream();
                }
                catch
                {
                    throw new Exception("failed to connect");
                }
            });
            

        }
    }
}
