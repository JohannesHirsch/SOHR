//***********************************************************//
// File:    frmRuleSet
// Project: SOHR.Server
// Date:    29.12.2016
// Comment: Fragensatzform-CodeBehind
//***********************************************************//

using SOHR.Shared;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHR.Client
{
    /// <summary>
    /// Fragensatzform-CodeBehind
    /// </summary>
    public partial class frmRuleSet : Form
    {
        BindingList<Question> questionsList;
        BindingList<Result> resultsList;

        public frmRuleSet()
        {
            InitializeComponent();            
            RuleSet = new RuleSet();
            InitForm();
        }
        public frmRuleSet(RuleSet set)
        {            
            InitializeComponent();
            RuleSet = set;
            tbxRuleSetName.Text = RuleSet.Name;
            tbxComment.Text = RuleSet.Comment;
            InitForm();
        }

        #region Properties

        public RuleSet RuleSet { get; set; }
        private BindingList<Question> QuestionsList
        {
            get
            {
                return questionsList;
            }

        }
        private BindingList<Result> ResulstList
        {
            get
            {
                return resultsList;
            }

        }



        #endregion Properties


        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            frmQuestion frmQuestionNew = new frmQuestion();
            if (frmQuestionNew.ShowDialog() == DialogResult.OK)
            {
                QuestionsList.Add(frmQuestionNew.Question);
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedCells.Count > 0)
            {
                int selectedIndex = dgvQuestions.SelectedCells[0].RowIndex;
                Question questionEdit = questionsList[selectedIndex];
                frmQuestion frmQuestionEdit = new frmQuestion(questionEdit);
                if (frmQuestionEdit.ShowDialog() == DialogResult.OK)
                {
                    QuestionsList.Remove(questionEdit);
                    QuestionsList.Add(frmQuestionEdit.Question);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool allValid = true;
            bool lowerBoundValid = false;
            bool upperBoundValid = false;
            foreach (var result in RuleSet.PossibleResults)
            {
                if (allValid && result.Min < RuleSet.PossibleMin)
                {
                    MessageBox.Show(String.Format("Minimum von {0} außerhal des möglichen Punkebereichs", result.Name));
                    allValid = false;
                }
                if (allValid && result.Max > RuleSet.PossibleMax)
                {
                    MessageBox.Show(String.Format("Maximum von {0} außerhal des möglichen Punkebereichs", result.Name));
                    allValid = false;
                }
                if (allValid && result.Min > result.Max)
                {
                    MessageBox.Show(String.Format("Fehler bei Ergebnis {0}: Minimum größer Maximum", result.Name));
                    allValid = false;
                }
                if (allValid && result.Max < result.Min)
                {
                    MessageBox.Show(String.Format("Fehler bei Ergebnis {0}: Maximum kleiner Minimum", result.Name));
                    allValid = false;
                }
                lowerBoundValid = false;
                upperBoundValid = false;
                foreach (var resultTemp in RuleSet.PossibleResults)
                {
                    // Überprüfen, ob der gesamte Punktebereich abgedeckt ist
                    // jedes Minimum muss entweder das globale Minimum sein, oder das Maximum eines anderen Ergebnisses (und umgekehrt)
                    if(result.Min == RuleSet.PossibleMin || result.Min == (resultTemp.Max + 1))
                    {
                        
                        lowerBoundValid = true;
                    }
                    if(result.Max == RuleSet.PossibleMax || result.Max == (resultTemp.Min - 1))
                    {
                        upperBoundValid = true;
                    }


                    if(resultTemp != result)
                    {
                        if(allValid && (result.Min >= resultTemp.Min && result.Min <= resultTemp.Max || result.Max >= resultTemp.Min && result.Max <= resultTemp.Max))
                        {
                            MessageBox.Show(String.Format("Überschneidung bei Ergbenis {0} und Ergebnis {1}", result.Name, resultTemp.Name));
                            allValid = false;
                        }
                    }
                }
            }
            if(!lowerBoundValid || !upperBoundValid)
            {
                MessageBox.Show("Es ist nicht der gesamte mögliche Punktebereich abgedeckt");
                allValid = false;
            }

            if(allValid && String.IsNullOrWhiteSpace(tbxRuleSetName.Text))
            {
                MessageBox.Show("Name vergeben");
                allValid = false;
            }


            if (allValid)//!String.IsNullOrWhiteSpace(tbxRuleSetName.Text) && RuleSet.Questions.Count > 0 && RuleSet.PossibleResults.Count > 0)
            {
                RuleSet.Name = tbxRuleSetName.Text;
                RuleSet.Comment = tbxComment.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvQuestions.SelectedCells[0].RowIndex;
            QuestionsList.Remove(QuestionsList[selectedIndex]);
        }

        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvResults.SelectedCells[0].RowIndex;
            ResulstList.Remove(ResulstList[selectedIndex]);
        }       

        void InitForm()
        {
            questionsList = new BindingList<Question>();
            tbxMin.Text = RuleSet.PossibleMin.ToString();
            tbxMax.Text = RuleSet.PossibleMax.ToString();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            // dgvQuestion
            DataGridViewTextBoxColumn colQuestion = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Quesiton",
                HeaderText = "Frage",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            dgvQuestions.AllowUserToAddRows = false;
            dgvQuestions.AllowUserToDeleteRows = false;
            dgvQuestions.AutoGenerateColumns = false;
            dgvQuestions.MultiSelect = false;

            dgvQuestions.Columns.Add(colQuestion);

            questionsList = new BindingList<Question>(RuleSet.Questions);


            dgvQuestions.DataSource = questionsList;

            // dgvResult
            DataGridViewTextBoxColumn colResut = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Result",
                HeaderText = "Ergebnis",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            DataGridViewTextBoxColumn colMin = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Min",
                HeaderText = "Minimum",
                DataPropertyName = "Min",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            DataGridViewTextBoxColumn colMax = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Max",
                HeaderText = "Maximum",
                DataPropertyName = "Max",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvResults.AutoGenerateColumns = false;
            dgvResults.MultiSelect = false;

            dgvResults.Columns.Add(colResut);
            dgvResults.Columns.Add(colMin);
            dgvResults.Columns.Add(colMax);
            resultsList = new BindingList<Result>(RuleSet.PossibleResults);

            dgvResults.DataSource = resultsList;
        }       
    }
}
