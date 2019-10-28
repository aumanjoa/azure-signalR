using System;
using System.Threading.Tasks;

namespace consoleSignlR
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new Client();

            await client.Connect();
            Console.WriteLine("Connected");

            await client.Broadcast();
            Console.WriteLine("message send");

            await client.Stop();
            Console.WriteLine("stopped");

        }
    }
}
