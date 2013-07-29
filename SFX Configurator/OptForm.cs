using System;
using System.Windows.Forms;

namespace Project_SFX_Config
{
    public partial class OptForm : Form
    {
        public OptForm()
        {
            InitializeComponent();
        }

        private void OptForm_Load(object sender, EventArgs e)
        {
            var Prefs = new Params();
            TAutoReplace.Checked = Prefs.AutoReplace && false;
            TGUIFlags.Text = Params.MainIniFile.GetString("General", "GUIFlags", "2+4+8+16+32+2048+4096");
            TMiscFlags.Text = Params.MainIniFile.GetString("General", "MiscFlags", "4");
            TGUIMode.Text = Params.MainIniFile.GetString("General", "GUIMode", "1");
            TOverwriteMode.Text = Params.MainIniFile.GetString("General", "OverwriteMode", "Нет");

        }

        private void TSaveButton_Click(object sender, EventArgs e)
        {
            if (TAutoReplace.Checked)
                Params.MainIniFile.WriteValue("General", "AutoReplace", "false"); // когда придумаешь как сделать замени на true
            else
                Params.MainIniFile.WriteValue("General", "AutoReplace", "false"); 
            Params.MainIniFile.WriteValue("General", "GUIFlags", TGUIFlags.Text);
            Params.MainIniFile.WriteValue("General", "MiscFlags", TMiscFlags.Text);
            Params.MainIniFile.WriteValue("General", "GUIMode", TGUIMode.Text);
            Params.MainIniFile.WriteValue("General", "OverwriteMode", TOverwriteMode.Text);
        }
    }
}
