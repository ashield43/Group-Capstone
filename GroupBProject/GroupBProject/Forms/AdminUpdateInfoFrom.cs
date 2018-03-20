using GroupBProject.Utility;
using System;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// Admin Update Info Form.
    /// </summary>
    public partial class AdminUpdateInfoForm : Form
    {
        #region Fields

        private User currentUser;
        private string enteredPassword;
        private string confirmationPassword;
        private User userToUpdate = new User();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminUpdateInfoForm"/> class.
        /// </summary>
        /// <param name="userName">Username of the user logging in.</param>
        public AdminUpdateInfoForm(string userName)
        {
            InitializeComponent();
            currentUser = UserCommands.GetUserByUserName(userName);

            userToUpdate.UserID = currentUser.UserID;
            userToUpdate.Password = currentUser.Password;
            userToUpdate.UserType = currentUser.UserType;
            userToUpdate.Username = currentUser.Username;

            lblCurrentUsername.Text = currentUser.Username;
        }

        #endregion Constructors

        #region ButtonClick Methods

        /// <summary>
        /// Handles the Click event of the btnUpdatePassword control. Updates user password.
        /// </summary>
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            enteredPassword = txtNewPassword.Text;
            confirmationPassword = txtConfirmationPassword.Text;

            if (enteredPassword == "")
            {
                lblPasswordError.Text = "Password field can't be blank";
                txtNewPassword.Focus();
                return;
            }

            if (enteredPassword != "")
            {
                if (enteredPassword != confirmationPassword)
                {
                    lblPasswordError.Text = "The passwords you entered don't match";
                    txtConfirmationPassword.Focus();
                    txtConfirmationPassword.SelectAll();
                    return;
                }

                if (Validator.IsValidPassword(enteredPassword))
                {
                    string currentPassword = userToUpdate.Password;
                    userToUpdate.Password = Hashing.HashPassword(enteredPassword);

                    UserCommands.UpdateAdminPassword(userToUpdate);
                    MessageBox.Show("Your password has been successfully updated.");
                    txtNewPassword.Text = "";
                    lblPasswordError.Text = "";
                    this.Close();
                }
                else
                {
                    lblPasswordError.Text = "Password must contain the following:" + Environment.NewLine
                                            + "8 Characters." + Environment.NewLine
                                            + "At least one uppercase and one lowercase letter." + Environment.NewLine
                                            + "At least one special character and one number.";

                    txtNewPassword.Focus();
                    txtNewPassword.SelectAll();
                    return;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control. Closes the form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion ButtonClick Methods
    }
}