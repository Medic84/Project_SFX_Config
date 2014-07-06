using System.Windows.Forms;

namespace Project_SFX_Config
{
    public partial class EditForm : Form
    {
        public string TextEdit
        {
            get { return TEdit.Text; }
            set { TEdit.Text = value; }
        }

        public EditForm()
        {
            InitializeComponent();
        }
    }
}