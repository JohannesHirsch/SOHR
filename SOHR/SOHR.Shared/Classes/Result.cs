//***********************************************************//
// File:    Result
// Project: SOHR.Shared
// Date:    29.12.2016
// Comment: Ergebnis einer Befragung
//***********************************************************//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Shared
{
    /// <summary>
    /// Ergebnis einer Befragung
    /// </summary>
    public class Result : ModelBase
    {
        #region FIELDS
        #endregion // FIELDS

        #region CONSTRUCTOR
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Minimum dieses Typs
        /// </summary>
        public int Min { get; set; }
        /// <summary>
        /// Maximum dieses Typs
        /// </summary>
        public int Max { get; set; }
        #endregion // PROPERTIES

        #region PRIVATE METHODS
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}
