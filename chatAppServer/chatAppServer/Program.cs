
using System;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;

namespace chatServer
{
   
    public class serverApp
    {
        public static NetworkStream stream;
        public static StreamWriter writer;
        private static StreamReader reader;
        public static iceCandidates iceCandidates = new iceCandidates();

        public StreamReader streamReader { 
            get 
            {
                return reader;
            }
        }


        public static  void Main()
        {
            //can implement port forwarding to establish multiple tcp connection
            TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 3000);
            listener.Start();
            Console.WriteLine("waiting for a connection");
           
            //use threadpool to accept multiple request and send ipaddress list to connected clients
            //avoid deadlock/race conditions
            while (true)
            {
                if (listener.Pending())
                {
                    TcpClient client = listener.AcceptTcpClient();
                     stream = client.GetStream();
                     reader = new StreamReader(stream);
                    String port = reader.ReadLine();
                   
                    
                    String jsonString = JsonSerializer.Serialize<iceCandidates>(iceCandidates);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(jsonString);
                    writer.Flush();
                    String clientIP = client.Client.RemoteEndPoint.ToString();

                    String []ip = clientIP.Split(':');
                    String newcandidate = ip[0] + ':' + port;
                    bool flag = false;
                    foreach (var ipa in iceCandidates.candidates)
                    {
                        if(ipa == newcandidate)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if(!flag && port!="")
                    iceCandidates.candidates.Add(newcandidate);
                    
                    Console.WriteLine("Connection Closing");
                    
                }
                else
                {
                    Console.WriteLine("No pending Connection Request");
                    System.Threading.Thread.Sleep(1000);
                }
            }

        }
               
    }
}