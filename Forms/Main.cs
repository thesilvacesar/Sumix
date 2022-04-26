using Sumix.Classes;

namespace Sumix
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private Form history = new History();
        private Form settings = new Settings();

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            restoreBtn.Visible = false;
            compareCheck.Checked = false;
            this.Size = new Size(482, 294);

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                fileInput.Text = openDlg.FileName;
                algoBox.Text = Properties.Settings.Default.algo;
                Properties.Settings.Default.last_session = fileInput.Text;
                hashInput.Text = Hashes.GetHash(fileInput.Text, algoBox.Text);
            }
            else
            {
                algoBox.Text = "";
                fileInput.Clear();
                hashInput.Clear();
                openDlg.FileName = "";
                Properties.Settings.Default.last_session = "";
            }

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (fileInput.Text != "")
            {
                algoBox.Enabled = true;
                copyHash.Enabled = true;
                exportBtn.Enabled = true;
                hashInput.Enabled = true;
                base64Box.Enabled = true;
                compareCheck.Enabled = true;

                var hash = hashInput.Text;
                var hashCompare = hashCompareInput.Text;
                
                if (Properties.Settings.Default.upper_case == true)
                {
                    hashInput.Text = hash.ToUpper();
                    hashCompareInput.Text = hashCompare.ToUpper();
                }
                else
                {
                    hashInput.Text = hash.ToLower();
                    hashCompareInput.Text = hashCompare.ToLower();
                }
            }
            else
            {
                algoBox.Text = "";
                hashInput.Clear();

                algoBox.Enabled = false;
                copyHash.Enabled = false;
                exportBtn.Enabled = false;
                hashInput.Enabled = false;
                base64Box.Enabled = false;
                compareCheck.Enabled = false;

                Properties.Settings.Default.last_plain_hash = "";
                
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }

            if (!Properties.Settings.Default.restore_session)
            {
                restoreBtn.Visible = false;
            }

            if (fileInput.Text != "" && hashInput.Text != "")
            {
                algoBox.Enabled = true;
            }
            else
            {
                algoBox.Enabled = false;
            }

            if (compareCheck.Checked)
            {
                if (hashCompareInput.Text != "" && Regex.Hash(hashCompareInput.Text, "Generic"))
                {
                    compareBtn.Enabled = true;
                }
                else
                {
                    compareBtn.Enabled = false;
                }
            }
        }

        private void algoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (fileInput.Text != "")
            {
                hashInput.Text = Hashes.GetHash(fileInput.Text, algoBox.Text);
            }
        }

        private void copyHash_Click(object sender, EventArgs e)
        {
            hashInput.Select();
            hashInput.Copy();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.minimize_tray)
            {
                e.Cancel = true;
                trayIcon.Visible = true;

                Hide();
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = true;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            var name = Export.GetHashFileName(fileInput.Text, "\\");

            saveDlg.Filter = Export.GetHashFileFilter(algoBox.Text);
            saveDlg.FileName = name + "." + Export.GetHashFileExt(algoBox.Text);

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                FS.WriteAllText(
                    saveDlg.FileName, Export.GetHashFileContent(
                        name, hashInput.Text
                    )
                );
            }
        }
        
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Open.Link("https://github.com/thesilvaemily/Sumix");
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Size = new Size(482, 294);

            if (Properties.Settings.Default.restore_session && Properties.Settings.Default.last_session != "")
            {
                restoreBtn.Visible = true;
            }
            else
            {
                restoreBtn.Visible = false;
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            if (FS.Exists(Properties.Settings.Default.last_session))
            {
                this.Size = new Size(482, 294);
                algoBox.Text = Properties.Settings.Default.algo;

                fileInput.Text = Properties.Settings.Default.last_session;
                hashInput.Text = Hashes.GetHash(fileInput.Text, algoBox.Text);

                restoreBtn.Visible = false;
            }
        }

        private void compareCheck_CheckedChanged(object sender, EventArgs e)
        {
            resultLbl.Text = "";
            hashCompareInput.Clear();
            
            if (compareCheck.Checked)
            {
                panelVerify.Visible = true;
                this.Size = new Size(482, 406);
                algoCompareBox.Text = "Auto detect";
            }
            else
            {
                panelVerify.Visible = false;
                this.Size = new Size(482, 294);
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            var hashCompare = hashCompareInput.Text;
            
            var md5 = Hashes.MD5(fileInput.Text);
            var sha1 = Hashes.SHA1(fileInput.Text);
            var sha256 = Hashes.SHA256(fileInput.Text);
            var sha384 = Hashes.SHA384(fileInput.Text);
            var sha512 = Hashes.SHA512(fileInput.Text);

            if (algoCompareBox.Text == "Auto detect")
            {
                if (Hashes.Compare(md5, hashCompare, "MD 5"))
                {
                    resultLbl.Text = "Hash is correct (md5)";
                }
                else if (Hashes.Compare(sha1, hashCompare, "SHA 1"))
                {
                    resultLbl.Text = "Hash is correct (sha1)";
                }
                else if (Hashes.Compare(sha256, hashCompare, "SHA 256"))
                {
                    resultLbl.Text = "Hash is correct (sha256)";
                }
                else if (Hashes.Compare(sha384, hashCompare, "SHA 384"))
                {
                    resultLbl.Text = "Hash is correct (sha384)";
                }
                else if (Hashes.Compare(sha512, hashCompare, "SHA 512"))
                {
                    resultLbl.Text = "Hash is correct (sha512)";
                }
                else
                {
                    resultLbl.Text = "Hash is incorrect";
                }
            }
            else if (algoCompareBox.Text == "MD 5")
            {
                if (Hashes.Compare(md5, hashCompare, algoCompareBox.Text))
                {
                    resultLbl.Text = "Hash is correct (md5)";
                }
                else
                {
                    resultLbl.Text = "Hash is incorrect";
                }
            }
            else if (algoCompareBox.Text == "SHA 1")
            {
                if (Hashes.Compare(sha1, hashCompare, algoCompareBox.Text))
                {
                    resultLbl.Text = "Hash is correct (sha1)";
                }
                else
                {
                    resultLbl.Text = "Hash is incorrect";
                }
            }
            else if (algoCompareBox.Text == "SHA 256")
            {
                if (Hashes.Compare(sha256, hashCompare, algoCompareBox.Text))
                {
                    resultLbl.Text = "Hash is correct (sha256)";
                }
                else
                {
                    resultLbl.Text = "Hash is incorrect";
                }
            }
            else if (algoCompareBox.Text == "SHA 384")
            {
                if (Hashes.Compare(sha384, hashCompare, algoCompareBox.Text))
                {
                    resultLbl.Text = "Hash is correct (sha384)";
                }
                else
                {
                    resultLbl.Text = "Hash is incorrect";
                }
            }
            else if (algoCompareBox.Text == "SHA 512")
            {
                if (Hashes.Compare(sha512, hashCompare, algoCompareBox.Text))
                {
                    resultLbl.Text = "Hash is correct (sha512)";
                }
                else
                {
                    resultLbl.Text = "Hash is incorrect";
                }
            }
        }

        private void base64Box_CheckedChanged(object sender, EventArgs e)
        {
            string hashTxtPlain = Properties.Settings.Default.last_plain_hash;
            string hashTxtB64 = Base64.Encode(hashTxtPlain);

            if (base64Box.Checked)
            {
                hashInput.Text = hashTxtB64;
            }
            else
            {
                hashInput.Text = hashTxtPlain;
            }
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            hashCompareInput.Text = Clipboard.GetText();
        }
    }
}