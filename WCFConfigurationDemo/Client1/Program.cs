using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloServiceProxy.HelloServiceContractClient proxy = new HelloServiceProxy.HelloServiceContractClient();
            Console.WriteLine("The Service Method Output is - {0}",proxy.MyHelloMessage("Pravinkumar R. D."));
            Console.Read();

        }
    }
}
