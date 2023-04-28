using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;

namespace chatui
{
    public class Candidates
    {
        public List<String> candidates { get; set; } 
    }
    public static class Controller
    {
        public static NetworkStream stream;

        public async static Task<List<String>> GetIPList(String port)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 3000);
            NetworkStream stream = tcpClient.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(port);
            writer.Flush();
            StreamReader reader = new StreamReader(stream);
            String returnedJson =  reader.ReadLine();
            stream.Close();
            tcpClient.Close();
            Candidates jsonString = JsonSerializer.Deserialize<Candidates>(returnedJson);
            return jsonString.candidates;
        }
    }
}
