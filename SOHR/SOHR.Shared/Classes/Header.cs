using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Shared
{
    public class Header : ModelBase
    {
        public string Path { get; set; }
        public override string ToString()
        {
            return Name;
            //Änderung Spindlberger
        }
    }
}
