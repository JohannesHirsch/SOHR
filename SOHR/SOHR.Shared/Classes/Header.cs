//***********************************************************//
// File:    Result
// Project: SOHR.Shared
// Date:    29.12.2016
// Comment: Header eines Fragensatzes
//***********************************************************//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Shared
{
    /// <summary>
    /// Header eines Fragensatzes
    /// </summary>
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
