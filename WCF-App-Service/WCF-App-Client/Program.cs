using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_App_Client
{
    class Program
    {
            static void Main(string[] args){
            ServiceReference1.WCFAppServiceClient proxy = new ServiceReference1.WCFAppServiceClient();
            var msg = proxy.GetData(101);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
