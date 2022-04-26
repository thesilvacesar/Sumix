using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumix
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.minimize_tray)
            {
                trayCheck.Checked = true;
            }
            else
            {
                trayCheck.Checked = false;
            }

            if (Properties.Settings.Default.upper_case)
            {
                upperCheck.Checked = true;
            }
            else
            {
                upperCheck.Checked = false;
            }

            if (Properties.Settings.Default.restore_session)
            {
                restoreBox.Checked = true;
            }
            else
            {
                restoreBox.Checked = false;
            }

            algoDefaultBox.Text = Properties.Settings.Default.algo;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (trayCheck.Checked)
            {
                Properties.Settings.Default.minimize_tray = true;
            }
            else
            {
                Properties.Settings.Default.minimize_tray = false;
            }

            if (upperCheck.Checked)
            {
                Properties.Settings.Default.upper_case = true;
            }
            else
            {
                Properties.Settings.Default.upper_case = false;
            }

            if (restoreBox.Checked)
            {
                Properties.Settings.Default.restore_session = true;
            }
            else
            {
                Properties.Settings.Default.restore_session = false;
            }

            Properties.Settings.Default.algo = algoDefaultBox.Text;

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            Close();
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            
            Close();
        }
    }
}
