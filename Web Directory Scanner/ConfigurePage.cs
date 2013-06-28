using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Directory_Scanner
{
    public partial class ConfigurePage : UserControl
    {

        private RadioButtonManager rButtonManager;

        public ConfigurePage()
        {
            InitializeComponent();
            this.rButtonManager = new RadioButtonManager();
            this.rButtonManager.AddButton(rbNormal);
            this.rButtonManager.AddButton(rbDictionary);

            txtStrings.Text = Properties.Settings.Default.strings;
            txtDictionaryPath.Text = Properties.Settings.Default.dictionary_path;
            textBox1.Text = Properties.Settings.Default.last_url;

        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            btnOpenDictionary.Enabled = false;
            txtStrings.Enabled = true;
        }

        private void rbDictionary_CheckedChanged(object sender, EventArgs e)
        {
            btnOpenDictionary.Enabled = true;
            txtStrings.Enabled = false;
        }

        private void btnOpenDictionary_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text-based Dictionary Files *.txt|*.txt|All files *.*|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult r = openFileDialog1.ShowDialog(this);
            if (r == DialogResult.OK)
            {
                txtDictionaryPath.Text = openFileDialog1.FileName;
                Properties.Settings.Default.dictionary_path = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClickHandler.HandleClick(this, new ClickHandler.ClickEventArgs("cancel_scan"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.scan_mode = (rButtonManager.CurrentButton.Name.Equals("rbNormal")) ? "normal" : "dictionary";
            Properties.Settings.Default.last_url = textBox1.Text;
            Properties.Settings.Default.Save();
            ClickHandler.HandleClick(this, new ClickHandler.ClickEventArgs("start_scan"));
        }

        private void txtStrings_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.strings = txtStrings.Text;
        }
    }
}
