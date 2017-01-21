//***********************************************************//
// File:    frmRuleSet
// Project: SOHR.Server
// Date:    29.12.2016
// Comment: Fragensatzform-CodeBehind
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
    /// Fragensatzform-CodeBehind
    /// </summary>
    public partial class frmRuleSet : Form
    {
        RuleSet ruleSet;

        public frmRuleSet()
        {
            InitializeComponent();
        }
        public frmRuleSet(RuleSet set)
        {            
            InitializeComponent();
            ruleSet = set;
            tbxRuleSetName.Text = ruleSet.Name;
            tbxComment.Text = ruleSet.Comment;

            foreach (var question in ruleSet.Questions)
            {
                lstvwQuestions.Items.Add(question.Name);
            }
        }
    }
}
