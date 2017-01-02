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
        #endregion // FIELDS

        #region CONSTRUCTOR
        #endregion // CONSTRUCTOR

        #region PROPERTIES
        /// Liste der Fragen
        /// </summary>
        public ObservableCollection<Question> Questions { get; set; }
        /// <summary>
        /// Mögliche Ergebnisse
        /// </summary>
        public ObservableCollection<Result> PossibleResults { get; set; }
        /// <summary>
        /// Mögliches Punktemaximum für diesen Fragensatz
        /// </summary>
        public int PossibleMax { get; set; }
        /// <summary>
        /// Mögliches Punkteminimum für diesen Fragensatz
        /// </summary>
        public int PossibleMin { get; set; }

        #endregion // PROPERTIES

        #region PRIVATE METHODS
        void CalculateBoundaries()
        {
            int localmin;
            int localmax;
            foreach (var question in Questions)
            {
                localmax = 0;
                localmin = 0;
                foreach (var answer in question.PossibleAnswers)
                {
                    if(answer.Points < localmin)
                    {
                        localmin += answer.Points;
                    }
                    if(answer.Points > localmax)
                    {
                        localmax += answer.Points;
                    }
                }
                PossibleMax += localmax;
                PossibleMin += localmin;
            }
        }
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS
        #endregion // PUBLIC METHODS
    }
}
