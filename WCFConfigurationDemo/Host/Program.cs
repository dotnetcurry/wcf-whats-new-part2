using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host=new ServiceHost(typeof(HelloWCFService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Server Started successfully!!");
                Console.WriteLine("");
                Console.WriteLine("Press Enter Key to Terminate the host!!");
                //foreach (ServiceEndpoint endPointInfo in host.Description.Endpoints)
                //{
                //    Console.WriteLine("Address - {0}, Binding - {1} and Contract {2}",endPointInfo.Address,endPointInfo.Binding.GetType().ToString(),endPointInfo.Contract.Name);
                //}
                NetTcpBinding netTcpBinding = host.Description.Endpoints[0].Binding as NetTcpBinding;
                Console.Read();
                host.Close();
            }
        }
    }
}
