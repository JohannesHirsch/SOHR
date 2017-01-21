//***********************************************************//
// File:    ModelBase
// Project: SOHR.Shared
// Date:    29.12.2016
// Comment: Basisklasse für alle Modellklassen
//***********************************************************//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Shared
{
    /// <summary>
    /// Basisklasse für alle Modellklassen
    /// </summary>
    public class ModelBase
    {
        #region FIELDS
        #endregion // FIELDS

        #region CONSTRUCTOR
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Id des Satzed von Fragen
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// Name des Satzes von Fragen
        /// </summary>
        public string Name { get; set; }    
        /// <summary>
        /// Kommentar
        /// </summary>
        public string Comment { get; set; }    

        #endregion // PROPERTIES

        #region PRIVATE METHODS
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}
