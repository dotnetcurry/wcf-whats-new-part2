using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWCFService
{
    [ServiceContract(Name="HelloServiceContract",Namespace="http://www.mycompany.com/2012/11")]
    public interface IHelloService
    {
        [OperationContract]
        string MyHelloMessage(string firstName);
    }
}
