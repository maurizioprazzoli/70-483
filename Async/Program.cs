using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(0.ToString("###0"));
            Console.WriteLine(10.ToString("###0"));
            Console.WriteLine(999.ToString("###0"));
            Console.WriteLine(99999.ToString("###0"));
        }

        //The method must meet the following requirements:
        //Return a string that includes the player name and the number of coins.
        //Display the number of coins without leading zeros if the number is 1 or greater.
        //Display the number of coins as a single 0 if the number is 0.
        //You need to ensure that the method meets the requirements.
        //Which code segment should you insert at line 03?
        public string FormatCoins(string name, int coins)
        {
            return "";
        }


        private static int testm()
        {
            throw new NotImplementedException();
        }


        private static async Task<String> IssueClientRequestAsync(String serverName, String message)
        {
            using (var pipe = new NamedPipeClientStream(serverName, "PipeName", PipeDirection.InOut,
                                                        PipeOptions.Asynchronous | PipeOptions.WriteThrough))
            {
                pipe.Connect(); // Must Connect before setting ReadMode
                pipe.ReadMode = PipeTransmissionMode.Message;
                // Asynchronously send data to the server
                Byte[] request = Encoding.UTF8.GetBytes(message);
                await pipe.WriteAsync(request, 0, request.Length);
                // Asynchronously read the server's response
                Byte[] response = new Byte[1000];
                Int32 bytesRead = await pipe.ReadAsync(response, 0, response.Length);
                return Encoding.UTF8.GetString(response, 0, bytesRead);
            } // Close the pipe
        }

        internal sealed class Type1 { }
        internal sealed class Type2 { }
        private static async Task<Type1> Method1Async()
        {
            /* Does some async thing that returns a Type1 object */
            return new Type1();
        }
        private static async Task<Type2> Method2Async()
        {
            /* Does some async thing that returns a Type2 object */
            return new Type2();
        }

        private static async Task<String> MyMethodAsync(Int32 argument)
        {
            Int32 local = argument;
            try
            {
                Type1 result1 = await Method1Async();
                for (Int32 x = 0; x < 3; x++)
                {
                    Type2 result2 = await Method2Async();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Catch");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            return "Done";
        }

    }


}
