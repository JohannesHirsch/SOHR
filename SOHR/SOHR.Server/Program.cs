using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(@"RuleSets");

            server.InitServer();
            server.LoadFuleSetHeaders();
        }
    }
}
