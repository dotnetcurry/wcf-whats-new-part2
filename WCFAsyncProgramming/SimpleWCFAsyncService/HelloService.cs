using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWCFAsyncService
{
    public class HelloService:IHelloService
    {
        public async Task<string> MyHelloMessage(string fullName)
        {
            System.Threading.Thread.Sleep(10000);
            return string.Format("Hello, {0}!!, WelCome To What's New in WCF 4.5 Part - II", fullName);
        }
    }
}
