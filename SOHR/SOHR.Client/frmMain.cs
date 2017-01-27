//***********************************************************//
// File:    frmMain
// Project: SOHR.Server
// Date:    29.12.2016
// Comment: Hauptform-CodeBehind
//***********************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using SOHR.Shared.Contracts;
using SOHR.Shared;

namespace SOHR.Client
{
    /// <summary>
    /// Hauptform-CodeBehind
    /// </summary>
    public partial class frmMain : Form
    {
        private IClientService remoteClientService;

        public frmMain()
        {
            InitializeComponent();
            btnDeleteRuleSet.Enabled = false;
            btnEditRuleSet.Enabled = false;
            btnStartQuestioning.Enabled = false;            

            try
            {
                ChannelFactory<IClientService> channelFactory = new ChannelFactory<IClientService>("WSHttpBinding_IClientService");
                remoteClientService = channelFactory.CreateChannel();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateHeaders();
        }
        private void btnEditRuleSet_Click(object sender, EventArgs e)
        {
            var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);

            frmRuleSet frmRuleSetEdit = new frmRuleSet(set);                        
            if(frmRuleSetEdit.ShowDialog() == DialogResult.OK)
            {
                remoteClientService.SaveRuleSet(frmRuleSetEdit.RuleSet);
            }

            UpdateHeaders();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateHeaders();
        }

        private void btnStartQuestioning_Click(object sender, EventArgs e)
        {
            var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);
            frmQuestioning frmquestioning = new frmQuestioning(set);
            frmquestioning.ShowDialog();
        }

        private void btnNewRuleSet_Click(object sender, EventArgs e)
        {
            frmRuleSet frmRuleSetNew = new frmRuleSet();
            if (frmRuleSetNew.ShowDialog() == DialogResult.OK)
            {
                remoteClientService.SaveRuleSet(frmRuleSetNew.RuleSet);
            }
            UpdateHeaders();
        }

        private void btnDeleteRuleSet_Click(object sender, EventArgs e)
        {
            var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);
            remoteClientService.DeleteRuleSet(set.ID);

            UpdateHeaders();
        }

        private void UpdateHeaders()
        {
            var headers = remoteClientService.LoadRuleSetHeaders();

            cbxHeaders.Items.Clear();
            foreach (var header in headers)
            {
                cbxHeaders.Items.Add(header);
            }
            if (cbxHeaders.Items.Count > 0)
            {
                cbxHeaders.SelectedIndex = 0;
            }
            
        }

        private void cbxHeaders_TextChanged(object sender, EventArgs e)
        {
            btnDeleteRuleSet.Enabled = true;
            btnEditRuleSet.Enabled = true;
            btnStartQuestioning.Enabled = true;
        }


    }
}
