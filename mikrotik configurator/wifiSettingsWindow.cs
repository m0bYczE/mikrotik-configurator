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
    public partial class wifiSettingsWindow : Form
    {
        public wifiSettingsWindow()
        {
            InitializeComponent();
        }

        public wifiSettings settings = new wifiSettings();
        private void exitNoSaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit without saving?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //DoNothing
            }
        }
    }
}
