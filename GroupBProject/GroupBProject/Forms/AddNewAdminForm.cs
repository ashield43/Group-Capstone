using GroupBProject.Utility;
using System;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// Class AddNewAdminForm.
    /// </summary>
    public partial class AddNewAdminForm : Form
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewAdminForm"/> class.
        /// </summary>
        public AddNewAdminForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region ButtonClick Methods

        /// <summary>
        /// Handles the Click event of the btnCancel control. Closes the form.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnCreateAdmin control. If all information is valid
        /// this will add a new admin to the database.
        /// </summary>
        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string enteredPassword = txtPassword.Text;
            string confirmationPassword = txtPasswordConfirmation.Text;

            bool fieldsFilledIn = CheckForBlankBoxes(userName, enteredPassword, confirmationPassword);

            if (fieldsFilledIn)
            {
                if (UserCommands.CheckUsernameExists(userName))
                {
                    lblUserNameError.Text = "Username already exists.";
                    lblPasswordError.Text = "";
                    txtPassword.Text = "";
                    txtPasswordConfirmation.Text = "";
                    lblPasswordConfirmationError.Text = "";
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                    return;
                }

                if (!UserCommands.CheckUsernameExists(userName))
                {
                    if (enteredPassword != confirmationPassword)
                    {
                        lblPasswordConfirmationError.Text = "The passwords you entered don't match";
                        lblPasswordError.Text = "";
                        txtPasswordConfirmation.Focus();
                        txtPasswordConfirmation.SelectAll();
                        return;
                    }

                    if (enteredPassword == confirmationPassword)
                    {
                        if (Validator.IsValidPassword(enteredPassword))
                        {
                            User newGuest = new User();
                            newGuest.Username = userName;
                            newGuest.Password = Hashing.HashPassword(enteredPassword);
                            newGuest.UserType = "Guest";

                            newGuest.UserID = UserCommands.AddUser(newGuest);
                            MessageBox.Show("Guest user " + newGuest.Username + " successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPassword.Text = "";
                            txtUserName.Text = "";
                            txtPasswordConfirmation.Text = "";
                            this.Close();
                        }
                        else
                        {
                            lblPasswordError.Text = "Password must contain the following:" + Environment.NewLine
                                                                                           + "8 Characters." + Environment.NewLine
                                                                                           + "At least one uppercase and one lowercase letter." + Environment.NewLine
                                                                                           + "At least one special character and one number.";
                            lblPasswordConfirmationError.Text = "";
                            txtPassword.Focus();
                            txtPassword.SelectAll();

                            return;
                        }
                    }
                }
            }
        }

        #endregion ButtonClick Methods

        #region Methods

        /// <summary>
        /// Checks for blank password and username boxes.
        /// </summary>
        private bool CheckForBlankBoxes(string userName, string password, string confirmationPassword)
        {
            string enteredUserName = userName;
            string enteredPassword = password;
            string enteredConfirmationPassword = confirmationPassword;
            bool isValid = false;

            if (enteredUserName == "")
            {
                lblUserNameError.Text = "Username can't be blank";
            }
            else
            {
                lblUserNameError.Text = "";
            }

            if (enteredPassword == "")
            {
                lblPasswordError.Text = "Password can't be blank";
            }
            else
            {
                lblPasswordError.Text = "";
            }

            if (enteredConfirmationPassword == "")
            {
                lblPasswordConfirmationError.Text = "Please enter a confirmation password";
            }
            else
            {
                lblPasswordConfirmationError.Text = "";
            }

            if (enteredConfirmationPassword != "" && enteredPassword != "" && enteredUserName != "")
            {
                lblPasswordError.Text = "";
                lblPasswordConfirmationError.Text = "";
                lblUserNameError.Text = "";
                isValid = true;
            }

            return isValid;
        }

        #endregion Methods
    }
}