//***********************************************************//
// File:    frmQuestioning
// Project: SOHR.Server
// Date:    29.12.2016
// Comment: Befragungsform-CodeBehind
//***********************************************************//

using SOHR.Shared;
using System;
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
    /// Befragungsform-CodeBehind
    /// </summary>
    public partial class frmQuestioning : Form
    {
        public frmQuestioning(RuleSet set)
        {
            InitializeComponent();
            RuleSet = set;
            InitForm();
        }

        RuleSet RuleSet { get; set; }
        int Index { get; set; } = 0;
        int Points { get; set; } = 0;



        void InitForm()
        {
            tbxQuestion.Text = RuleSet.Questions[Index].Name;
            // dgvAnswer
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colAnswer = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Answer",
                HeaderText = "Antwort",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            
            dgvAnswers.AutoGenerateColumns = false;

            dgvAnswers.Columns.Add(colAnswer);
            
            dgvAnswers.DataSource = new BindingList<Answer>(RuleSet.Questions[Index].PossibleAnswers);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {            
            if (dgvAnswers.SelectedCells.Count > 0)
            {
                var listAnswers = new BindingList<Answer>(RuleSet.Questions[Index].PossibleAnswers);
                int selectedIndex = dgvAnswers.SelectedCells[0].RowIndex;
                Points += listAnswers[selectedIndex].Points;

                Index++;
                if (Index < RuleSet.Questions.Count)
                {
                    listAnswers = new BindingList<Answer>(RuleSet.Questions[Index].PossibleAnswers);
                    tbxQuestion.Text = RuleSet.Questions[Index].Name;
                    dgvAnswers.DataSource = listAnswers;
                }
            }
            if (Index >= RuleSet.Questions.Count)
            {
                bool resultFound = false;
                foreach (var result in RuleSet.PossibleResults)
                {
                    if (Points >= result.Min && Points <= result.Max)
                    {
                        resultFound = true;
                        MessageBox.Show(result.Name);
                        DialogResult = DialogResult.OK;
                    }
                }
                if (resultFound == false)
                {
                    MessageBox.Show("Fehler");
                }
            }
        }        
    }
}
