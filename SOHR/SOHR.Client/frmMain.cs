using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel; // for WCF - need Verweis
using SOHR.Shared.Contracts; // for remote methods 
using SOHR.Shared;

namespace SOHR.Client
{
    public partial class frmMain : Form
    {
        private IClientService remoteClientService;

        public frmMain()
        {
            InitializeComponent();

            try
            {
                ChannelFactory<IClientService> channelFactory = new ChannelFactory<IClientService>("WSHttpBinding_IClientService");
                remoteClientService = channelFactory.CreateChannel();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var headers = remoteClientService.LoadRuleSetHeaders();

            foreach (var header in headers)
            {
                cbxHeaders.Items.Add(header);
            }
        }

        private void btnEditRuleSet_Click(object sender, EventArgs e)
        {
            var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);

            frmRuleSet frmRuleSetEdit = new frmRuleSet(set);                        
            if(frmRuleSetEdit.ShowDialog() == DialogResult.OK)
            {

            }

            //Event zum Aktualisieren der Header feuern

        }

        private void btnStartQuestioning_Click(object sender, EventArgs e)
        {
            var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);
        }

        private void btnNewRuleSet_Click(object sender, EventArgs e)
        {

            //Event zum Aktualisieren der Header feuern
        }

        private void btnDeleteRuleSet_Click(object sender, EventArgs e)
        {
            var set = remoteClientService.LoadRuleSet((cbxHeaders.SelectedItem as Header).ID);
            remoteClientService.DeleteRuleSet(set.ID);

            //Event zum Aktualisieren der Header feuern
        }
    }
}
