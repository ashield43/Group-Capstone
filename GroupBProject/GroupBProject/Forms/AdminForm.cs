using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// Admin Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AdminForm : Form
    {
        #region Fields

        private User loggedInUser;
        private User updatedUser;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminForm"/> class.
        /// </summary>
        /// <param name="userName">Username of the admin who logged in.</param>
        public AdminForm(string userName)
        {
            InitializeComponent();
            loggedInUser = UserCommands.GetUserByUserName(userName);
        }

        #endregion Constructors

        #region ButtonClick Methods

        /// <summary>
        /// Handles the Click event of the btnLogout control. Logs out of the program and returns to the
        /// main login form.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Handles the Click event of the btnGoToScheduler control. Opens the Scheduler form.
        /// </summary>
        private void btnGoToScheduler_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnViewReports control. Opens the reports form.
        /// </summary>
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            ReportSelectorForm form = new ReportSelectorForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnManageUsers control. Opens the form to manage guest users.
        /// </summary>
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUserForm form = new ManageUserForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnManageAdmin control. Opens the form to update
        /// current user password.
        /// </summary>
        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            AdminUpdateInfoForm form = new AdminUpdateInfoForm(loggedInUser.Username);
            form.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the btnAddNewAdmin control. Opens form to add new admin.
        /// </summary>
        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            AddNewAdminForm form = new AddNewAdminForm();
            form.ShowDialog();
        }

        #endregion ButtonClick Methods

        #region Methods
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Restart();
        }

        #endregion
    }
}