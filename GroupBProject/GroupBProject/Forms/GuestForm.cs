using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ReportSelectorForm form = new ReportSelectorForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Restart();
        }
    }
}