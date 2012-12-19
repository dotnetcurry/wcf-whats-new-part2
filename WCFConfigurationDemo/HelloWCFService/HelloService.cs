using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWCFService
{
    public class HelloService:IHelloService
    {
        public string MyHelloMessage(string firstName)
        {
            return string.Format("Hello, {0} !! WelCome to What's New in WCF 4.5 Part - I", firstName);
        }
    }
}
