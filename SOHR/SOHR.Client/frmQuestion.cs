﻿//***********************************************************//
// File:    frmQuestion
// Project: SOHR.Server
// Date:    29.12.2016
// Comment: Frage-CodeBehind
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
    /// Frage-CodeBehind
    /// </summary>
    public partial class frmQuestion : Form
    {
        public frmQuestion(Question question)
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Question = question;
            tbxQuestion.Text = question.Name;

            InitDataGridViews();            
        }

        public frmQuestion()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Question = new Question();

            InitDataGridViews();
        }

        #region Properties

        public Question Question { get; set; }

        #endregion Properties

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxQuestion.Text) && dgvAnswers.RowCount > 2)
            {
                this.Question.Name = this.tbxQuestion.Text;
                DialogResult = DialogResult.OK;
            }
        }

        void InitDataGridViews()
        {
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
            DataGridViewTextBoxColumn colPoints = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Points",
                HeaderText = "Punkte",
                DataPropertyName = "Points",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            };
            dgvAnswers.AutoGenerateColumns = false;

            dgvAnswers.Columns.Add(colAnswer);
            dgvAnswers.Columns.Add(colPoints);

            var answersList = new BindingList<Answer>(Question.PossibleAnswers);
            dgvAnswers.DataSource = answersList;
        }
    }
}
