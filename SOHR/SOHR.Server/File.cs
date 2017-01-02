using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOHR.Shared;

namespace SOHR.Server
{
    internal class File
    {
        #region FIELDS
        internal StreamReader StreamReader { get; set; }
        internal StreamWriter StreamWriter { get; set; }
        internal string FileName { get; set; }
        #endregion // FIELDS

        #region CONSTRUCTOR
        internal File(string path)
        {
            FileName = path;
            RuleSet = new RuleSet();
        }
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Fragensatz dieses Files
        /// </summary>
        internal RuleSet RuleSet { get; set; }
        #endregion // PROPERTIES

        #region PRIVATE METHODS
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}
