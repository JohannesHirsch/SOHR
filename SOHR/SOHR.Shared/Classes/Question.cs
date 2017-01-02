using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Shared
{
    public class Question : ModelBase
    {
        #region FIELDS
        #endregion // FIELDS

        #region CONSTRUCTOR
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Mögliche Fragen für diese Antwort
        /// </summary>
        public ObservableCollection<Answer> PossibleAnswers { get; set; }
        #endregion // PROPERTIES

        #region PRIVATE METHODS
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}
