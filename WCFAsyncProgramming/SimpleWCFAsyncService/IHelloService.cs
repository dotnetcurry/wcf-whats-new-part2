using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace SimpleWCFAsyncService
{
    [ServiceContract(Name="HelloServiceContract",Namespace="http://www.mycompany.com/2012/11")]
    public interface IHelloService
    {
        [OperationContract]
        Task<string> MyHelloMessage(string fullName);
    }
}
