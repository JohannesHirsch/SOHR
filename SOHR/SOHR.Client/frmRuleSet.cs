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

            foreach (var question in SetEdit.Questions)
            {
                lstvwQuestions.Items.Add(question.Name);
            }

            foreach (var result in SetEdit.PossibleResults)
            {
                lstvwResults.Items.Add(result.Name);
            }       
        }

        #region Properties

        public RuleSet SetEdit { get; set; }
        

        #endregion Properties


        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            frmQuestion frmQuestionNew = new frmQuestion(new Question());
            if (frmQuestionNew.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
