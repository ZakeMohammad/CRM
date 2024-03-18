using System.Windows.Forms;

namespace CRM
{
    public partial class frmStartForm : Form
    {
        public frmStartForm()
        {
            InitializeComponent();
        }

        private void LinkForMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cloudonex.com/");
        }

    }
}
