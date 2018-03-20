using GroupBProject.Utility;
using System;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// Main Login.
    /// </summary>
    public partial class MainLogin : Form
    {
        #region Fields

        private string userName;
        private string password;
        private string userType;
        private bool correctPassword;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainLogin"/> class.
        /// </summary>
        public MainLogin()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region ButtonClick Methods

        /// <summary>
        /// Handles the Click event of the btnLogin control. Logs the user into the program.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            password = txtPassword.Text;

            User user = new User();

            bool doesUserExistAsAdmin = UserCommands.CheckUsernameExists(userName);

            if (userName == "")
            {
                lblUserNameError.Text = "Username can't be blank";
            }
            else if (!doesUserExistAsAdmin)
            {
                lblUserNameError.Text = "Username doesn't exist";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
            else
            {
                lblUserNameError.Text = "";
            }

            if (password == "")
            {
                lblPasswordError.Text = "Password can't be blank";
            }
            else
            {
                lblPasswordError.Text = "";
            }

            if (userName != "" && password != "" && doesUserExistAsAdmin)
            {
                user = UserCommands.GetUserByUserName(userName);
                userType = user.UserType;
                lblUserNameError.Text = "";

                correctPassword = Hashing.ValidatePassword(password, user.Password);

                if (correctPassword)
                {
                    if (userType == "Admin")
                    {
                        AdminForm form = new AdminForm(user.Username);
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (userType == "Guest")
                    {
                        GuestForm form = new GuestForm();
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    lblPasswordError.Text = "Password is incorrect";
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnExit control. Shuts the program down.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion ButtonClick Methods
    }
}