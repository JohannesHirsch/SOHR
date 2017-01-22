//***********************************************************//
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

            questionEdit = question;
        }

        #region Properties

        public Question questionEdit { get; set; }

        #endregion Properties

    }
}
