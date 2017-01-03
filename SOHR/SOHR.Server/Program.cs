using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(SOHR.Server.Server));
            serviceHost.Open();

            Console.WriteLine("Server initalisiert.");
            Console.ReadLine();
        }
    }
}
