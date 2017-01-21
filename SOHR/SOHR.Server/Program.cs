//***********************************************************//
// File:    Program
// Project: SOHR.Server
// Date:    29.12.2016
// Comment: Programm des Servers
//***********************************************************//

using SOHR.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Server
{
    /// <summary>
    /// Programm des Servers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(SOHR.Server.Server));
            serviceHost.Open();

            Console.ReadLine();
        }
    }
}
