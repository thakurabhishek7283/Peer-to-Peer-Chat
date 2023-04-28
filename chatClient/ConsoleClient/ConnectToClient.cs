
using System.Net.Sockets;


namespace chatApplication
{
    public static class ConnectToClient
    {
        public static NetworkStream stream;
        public static StreamReader reader;
        public static StreamWriter writer;
        public static async Task ReadComplete()
        {
            String res = await reader.ReadLineAsync();
            Console.WriteLine(res);
        }
        public static void connect(String []ip)
        {
            connection:
            try
            {
                TcpClient client = new TcpClient(ip[0], int.Parse(ip[1]));
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                bool isrunning = true;
                while (true && isrunning)
                {
                    ReadComplete();
                    String str = Console.ReadLine();
                    writer.WriteLine(str);
                    writer.Flush();
                }
            }
            catch {
                throw new Exception("failed to connect");
            }

        }
    }
}
