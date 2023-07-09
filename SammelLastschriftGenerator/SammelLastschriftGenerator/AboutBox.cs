using System.Windows.Forms;

namespace SammelLastschriftGenerator
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            Text = string.Format("Info über {0}", Program.AssemblyTitle);
            labelProductName.Text = Program.AssemblyProduct;
            labelVersion.Text = string.Format("Version {0}", Program.AssemblyVersion);
            labelCopyright.Text = Program.AssemblyCopyright;
            labelCompanyName.Text = Program.AssemblyCompany;
            textBoxDescription.Text = Program.AssemblyDescription;
        }
    }
}
