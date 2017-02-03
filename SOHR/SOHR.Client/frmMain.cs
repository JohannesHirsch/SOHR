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
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            btnDeleteRuleSet.Enabled = false;
            btnEditRuleSet.Enabled = false;
            btnStartQuestioning.Enabled = false;

            CreateChannel();          

            UpdateHeaders();
        }

        private void CreateChannel()
        {
            try
            {
                ChannelFactory<IClientService> channelFactory = new ChannelFactory<IClientService>("WSHttpBinding_IClientService");
                remoteClientService = channelFactory.CreateChannel();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditRuleSet_Click(object sender, EventArgs e)
        {
            if (cbxHeaders.Items.Count > 0)
            {
                try
                {
                    if (remoteClientService == null)
                    {
                        CreateChannel();
                    }
                    var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);

                    if (set != null)
                    {
                        frmRuleSet frmRuleSetEdit = new frmRuleSet(set);
                        if (frmRuleSetEdit.ShowDialog() == DialogResult.OK)
                        {
                            remoteClientService.SaveRuleSet(frmRuleSetEdit.RuleSet);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fragensatz ist nicht mehr vorhanden\n" + Environment.NewLine + "Eventuell wurde er von einem anderen Benutzer gelöscht!");
                    }



                    UpdateHeaders();
                }
                catch (EndpointNotFoundException)
                {

                    MessageBox.Show("Fragensatz konnte nicht geladen werden\nEs konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Eventuell ist Server offline");
                    remoteClientService = null;
                }
                catch (System.ServiceModel.Security.MessageSecurityException)
                {

                    MessageBox.Show("Es konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Versuchen Sie es erneut!");
                    remoteClientService = null;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateHeaders();
        }

        private void btnStartQuestioning_Click(object sender, EventArgs e)
        {
            if (cbxHeaders.Items.Count > 0)
            {
                try
                {
                    if (remoteClientService == null)
                    {
                        CreateChannel();
                    }
                    var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);
                    if (set != null)
                    {
                        frmQuestioning frmquestioning = new frmQuestioning(set);
                        frmquestioning.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Fragensatz ist nicht mehr vorhanden\n" + Environment.NewLine + "Eventuell wurde er von einem anderen Benutzer gelöscht!");
                        UpdateHeaders();
                    }

                }
                catch (EndpointNotFoundException)
                {

                    MessageBox.Show("Fragensatz konnte nicht geladen werden\nEs konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Eventuell ist Server offline");
                    remoteClientService = null;
                }
                catch (System.ServiceModel.Security.MessageSecurityException)
                {

                    MessageBox.Show("Es konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Versuchen Sie es erneut!");
                    remoteClientService = null;
                }
            }
        }

        private void btnNewRuleSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (remoteClientService == null)
                {
                    CreateChannel();
                }
                frmRuleSet frmRuleSetNew = new frmRuleSet();
                if (frmRuleSetNew.ShowDialog() == DialogResult.OK)
                {
                    remoteClientService.SaveRuleSet(frmRuleSetNew.RuleSet);
                }
                UpdateHeaders();
            }
            catch (EndpointNotFoundException)
            {

                MessageBox.Show("Fragensatz konnte nicht gespeichert werden\nEs konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Eventuell ist Server offline");
                remoteClientService = null;
            }
            catch (System.ServiceModel.Security.MessageSecurityException)
            {

                MessageBox.Show("Es konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Versuchen Sie es erneut!");
                remoteClientService = null;
            }

        }

        private void btnDeleteRuleSet_Click(object sender, EventArgs e)
        {
            if (cbxHeaders.Items.Count > 0)
            {
                try
                {
                    if (remoteClientService == null)
                    {
                        CreateChannel();
                    }
                    var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);

                    if (set != null)
                    {
                        remoteClientService.DeleteRuleSet(set.ID);
                    }
                    else
                    {
                        MessageBox.Show("Fragensatz ist nicht mehr vorhanden\n" + Environment.NewLine + "Eventuell wurde er von einem anderen Benutzer gelöscht!");
                    }

                    UpdateHeaders();
                }
                catch (EndpointNotFoundException)
                {

                    MessageBox.Show("Es konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Eventuell ist Server offline");
                    remoteClientService = null;
                }
                catch (System.ServiceModel.Security.MessageSecurityException)
                {

                    MessageBox.Show("Es konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Versuchen Sie es erneut!");
                    remoteClientService = null;
                }
                catch (System.ServiceModel.CommunicationObjectFaultedException)
                {

                    MessageBox.Show("Fragensatz ist nicht mehr vorhanden\n" + Environment.NewLine + "Eventuell wurde er von einem anderen Benutzer gelöscht!");
                    UpdateHeaders();
                    
                }

            }

        }

        private void UpdateHeaders()
        {
            try
            {
                
                if (remoteClientService == null)
                {
                    CreateChannel();
                    
                }
                var headers = remoteClientService.LoadRuleSetHeaders();

                cbxHeaders.Items.Clear();
                foreach (var header in headers)
                {
                    cbxHeaders.Items.Add(header);
                }
                if (cbxHeaders.Items.Count > 0)
                {
                    cbxHeaders.SelectedIndex = 0;
                    cbxHeaders.Enabled = true;
                    btnDeleteRuleSet.Enabled = true;
                    btnEditRuleSet.Enabled = true;
                    btnStartQuestioning.Enabled = true;
                }
                else
                {
                    cbxHeaders.SelectedText = "";
                    cbxHeaders.Text = "";
                    cbxHeaders.Enabled = false;
                    btnDeleteRuleSet.Enabled = false;
                    btnEditRuleSet.Enabled = false;
                    btnStartQuestioning.Enabled = false;
                }
        }
            catch (EndpointNotFoundException)
            {

                MessageBox.Show("Header konnten nicht geladen werden.\nEs konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Eventuell ist Server offline");
                remoteClientService = null;
            }
            catch (System.ServiceModel.Security.MessageSecurityException)
            {

                MessageBox.Show("Es konnte keine Verbindung mit dem Server hergestellt werden\n" + Environment.NewLine + "Versuchen Sie es erneut!");
                remoteClientService = null;               
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
