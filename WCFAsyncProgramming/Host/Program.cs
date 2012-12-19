using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SimpleWCFAsyncService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Server Started successfully!!");
                Console.WriteLine("");
                Console.WriteLine("Press Enter Key to Terminate the host!!");
                Console.Read();
                host.Close();
            }
        }
    }
}
