//***********************************************************//
// File:    File
// Project: SOHR.Server
// Date:    29.12.2016
// Comment: Datei, in der ein Fragensatz abgelegt wird (.csv)
//***********************************************************//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOHR.Shared;

namespace SOHR.Server
{
    /// <summary>
    /// Datei, in der ein Fragensatz abgelegt wird (.csv)
    /// </summary>
    internal class File
    {
        #region FIELDS
        
        #endregion // FIELDS

        #region CONSTRUCTOR
        public File()
        {
        }
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Pfad des Files
        /// </summary>
        internal string Path { get; set; }
        /// <summary>
        /// Fragensatz dieses Files
        /// </summary>
        public RuleSet RuleSet { get; set; }
        #endregion // PROPERTIES

        #region PRIVATE METHODS
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}
