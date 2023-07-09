using System.Windows.Forms;

namespace SammelLastschriftGenerator
{
    public partial class SammelllastschriftDialog : Form
    {
        public SammelllastschriftDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
