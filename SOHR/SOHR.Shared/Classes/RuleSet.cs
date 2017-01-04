using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHR.Shared
{
    public class RuleSet : ModelBase
    {
        #region FIELDS
        protected ObservableCollection<Question> setQuestions;
        protected ObservableCollection<Result> setPossibleResults;
        #endregion // FIELDS

        #region CONSTRUCTOR
        public RuleSet()
        {
            ID = Guid.NewGuid();
            setPossibleResults = new ObservableCollection<Result>();
            setQuestions = new ObservableCollection<Question>();
        }
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// <summary>
        /// Liste der Fragen
        /// </summary>
        public ObservableCollection<Question> Questions
        {
            get
            {
                return setQuestions;
            }
            set
            {
                setQuestions = value;
            }
        }       
        /// <summary>
        /// Mögliche Ergebnisse
        /// </summary>
        public ObservableCollection<Result> PossibleResults
        {
            get
            {
                return setPossibleResults;
            }
            set
            {
                setPossibleResults = value;
            }
        }
        /// <summary>
        /// Mögliches Punktemaximum für diesen Fragensatz
        /// </summary>
        public int PossibleMax
        {
            get
            {
                int max = 0;
                int localmax;
                foreach (var question in Questions)
                {
                    localmax = 0;
                    foreach (var answer in question.PossibleAnswers)
                    {                        
                        if (answer.Points > localmax)
                        {
                            localmax += answer.Points;
                        }
                    }
                    max += localmax;
                }
                return max;
            }
        }

        /// <summary>
        /// Mögliches Punkteminimum für diesen Fragensatz
        /// </summary>
        public int PossibleMin
        {
            get
            {
                int min = 0;
                int localmin;
                foreach (var question in Questions)
                {
                    localmin = 0;
                    foreach (var answer in question.PossibleAnswers)
                    {
                        if (answer.Points < localmin)
                        {
                            localmin += answer.Points;
                        }
                    }
                    min += localmin;
                }
                return min;
            }
        }
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
