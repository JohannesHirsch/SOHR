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
        }
        public frmRuleSet(RuleSet set)
        {            
            InitializeComponent();
            SetEdit = set;
            tbxRuleSetName.Text = SetEdit.Name;
            tbxComment.Text = SetEdit.Comment;

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
            
            dgvQuestions.Columns.Add(colQuestion);

            questionsList = new BindingList<Question>(SetEdit.Questions);
            dgvQuestions.DataSource = questionsList;

            // dgvResult
            DataGridViewTextBoxColumn colResut = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Result",
                HeaderText = "Ergebnis",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            DataGridViewTextBoxColumn colMin= new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Min",
                HeaderText = "Minimum",
                DataPropertyName = "Min",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            DataGridViewTextBoxColumn colMax = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Max",
                HeaderText = "Maximum",
                DataPropertyName = "Max",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            dgvResults.AllowUserToAddRows = false;
            dgvResults.Columns.Add(colResut);
            dgvResults.Columns.Add(colMin);
            dgvResults.Columns.Add(colMax);
            resultsList = new BindingList<Result>(SetEdit.PossibleResults);
            dgvResults.DataSource = resultsList;

        }

        #region Properties

        public RuleSet SetEdit { get; set; }
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
            Question questionNew = new Question();
            frmQuestion frmQuestionNew = new frmQuestion(questionNew);
            if (frmQuestionNew.ShowDialog() == DialogResult.OK)
            {
                QuestionsList.Add(questionNew);
            }
        }

        private void frmRuleSet_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
