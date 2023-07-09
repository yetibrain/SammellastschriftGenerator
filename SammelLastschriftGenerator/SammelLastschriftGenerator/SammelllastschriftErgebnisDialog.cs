using System.Windows.Forms;

namespace SammelLastschriftGenerator
{
    public partial class SammelllastschriftErgebnisDialog : Form
    {
        public SammelllastschriftErgebnisDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
