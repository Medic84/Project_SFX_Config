using System;
using System.ComponentModel;
using System.Windows.Forms;
using ToolsLibrary;

namespace Project_SFX_Config
{
    public partial class AboutForm : Form
    {
        private Label _TempLabel;
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            TVerLabel.Text = "Версия: " + Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tools.Execute("http://mediclab.org/files/more/project-sfx-config-gui-dlja-sozdanija-konfiguracij-modificirovannogo-modulja-7zip.html");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tools.Execute("http://vk.com/phoenix84");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tools.Execute("http://www.facebook.com/profile.php?id=100001124670058");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tools.Execute("https://plus.google.com/u/0/116041127872162226481");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Tools.Execute("https://twitter.com/Med1c84");
        }

        private void CopyContext_Opening(object sender, CancelEventArgs e)
        {
            _TempLabel = (Label)CopyContext.SourceControl;
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_TempLabel.Text); 
        }
    }
}
