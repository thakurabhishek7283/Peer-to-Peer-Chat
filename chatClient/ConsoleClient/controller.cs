
using chatApplication;
using System.Net;
using System.Net.Sockets;
namespace chatApplication
{
    public static class controller
    {

        public static string port;
        public static void Main()
        {
            
            
            Console.WriteLine("which port do you like to listen request to");
            port = Console.ReadLine();
            ListenForClient.ClientToClient();
            getlist:    
            GetCandidates.Candidates();
            
            Console.WriteLine("Which Client do you Prefer to connect or press r for fetching list again or press d for dismiss");
            Console.WriteLine("(127.0.0.1:3456)");
            String input = Console.ReadLine();
            if(input == "r")
            {
                goto getlist;
            }
            else if (input == "d")
            {
                Console.WriteLine("redirecting to chatting");
                ListenForClient.chat();
            }
            else
            {
                String[] ipAdd = input.Split(':');
            connection:
                try
                {
                    ConnectToClient client = new ConnectToClient();
                    client.connect(ipAdd);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto connection;
                }
            }

        }
       
       

    }

}