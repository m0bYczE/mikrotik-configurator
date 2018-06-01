using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikrotik_configurator
{
    public partial class configurationMenu : Form
    {
        
        public configurationMenu()
        {
            InitializeComponent();
        }

        private void Setting_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void wifiSettingsBtn_Click(object sender, EventArgs e)
        {
            wifiSettingsWindow settings = new wifiSettingsWindow();
            settings.FormClosed += new FormClosedEventHandler(Setting_Closed);
            settings.Show();
            this.Hide();
        }

        private void modulesBtn_Click(object sender, EventArgs e)
        {
            modulesWindow modules = new modulesWindow();
            modules.FormClosed += new FormClosedEventHandler(Setting_Closed);
            modules.Show();
            this.Hide();
        }

        private void portForwardingBtn_Click(object sender, EventArgs e)
        {
            portForwardingWindow forwarding = new portForwardingWindow();
            forwarding.FormClosed += new FormClosedEventHandler(Setting_Closed);
            forwarding.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
