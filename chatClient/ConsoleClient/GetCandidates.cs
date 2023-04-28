using System.Net.Sockets;
using System.Text.Json;

namespace chatApplication
{
    public class iceCandidate
    {
        public string ipAddress { get; set; }
        public string port { get; set; }
    }
    public class iceCandidates
    {
        public List<iceCandidate> candidates { get; set; }
    } 
    public class GetCandidates
    {
        public static async void Candidates() {
            connection:
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 3000);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream);
                
                writer.WriteLine(controller.port);
                writer.Flush();
                StreamReader reader = new StreamReader(stream);
                
                String jsonString = reader.ReadLine();
                iceCandidates result = JsonSerializer.Deserialize<iceCandidates>(jsonString);
                foreach(var ip in result.candidates)
                Console.WriteLine($"{ip.ipAddress}:{ip.port}");
                Console.WriteLine("done outputing");
                stream.Close();
                client.Close();
            }
            catch {
                Console.WriteLine("failed to connect");
                goto connection;
            }
           


        }
    }
}
