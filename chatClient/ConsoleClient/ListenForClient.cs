using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace chatApplication
{
    
    public class ListenForClient
    {
        public static NetworkStream stream;
        public static StreamWriter writer;
        public static StreamReader reader;
        public static async Task ReadComplete()
        {
            String res = await reader.ReadLineAsync();
            Console.WriteLine(res);
        }
        public static async void ClientToClient()
        {
            
            {
                TcpListener listener = new TcpListener(int.Parse(controller.port));
                listener.Start();
                Console.WriteLine("Waiting for Client");
                TcpClient client = await listener.AcceptTcpClientAsync();
                Console.WriteLine("client Accepted");
                stream = client.GetStream();

            }
        }
        public static void chat()
        {
            
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);
            writer.WriteLine("hello");
            writer.Flush();
            while (true && stream != null)
            {
                ReadComplete();
                String str = Console.ReadLine();
                writer.WriteLine(str);
                writer.Flush();
            }
        }
         
    }
}
