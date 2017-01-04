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
        protected ObservableCollection<Answer> setPossibleAnswers;
        #endregion // FIELDS

        #region CONSTRUCTOR
        public Question()
        {
            ID = Guid.NewGuid();
            setPossibleAnswers = new ObservableCollection<Answer>();
        }
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Mögliche Fragen für diese Antwort
        /// </summary>
        public ObservableCollection<Answer> PossibleAnswers
        {
            get
            {
                return setPossibleAnswers;
            }
            set
            {
                setPossibleAnswers = value;
            }
        }
        #endregion // PROPERTIES

        #region PRIVATE METHODS
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}
