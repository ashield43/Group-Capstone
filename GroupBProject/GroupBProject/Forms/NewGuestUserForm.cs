using GroupBProject.Utility;
using System;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// New Guest User Form.
    /// </summary>
    public partial class NewGuestUserForm : Form
    {
        #region Fields

        private string userName;
        private string enteredPassword;
        private string confirmationPassword;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NewGuestUserForm"/> class.
        /// </summary>
        public NewGuestUserForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region ButtonClick Methods

        /// <summary>
        /// Handles the Click event of the btnAddUser control. Adds a new guest user to
        /// the database.
        /// </summary>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            enteredPassword = txtPassword.Text;
            confirmationPassword = txtConfirmationPassword.Text;

            bool fieldsFilledIn = CheckForBlankBoxes(userName, enteredPassword, confirmationPassword);

            if (fieldsFilledIn)
            {
                if (UserCommands.CheckUsernameExists(userName))
                {
                    lblUserNameError.Text = "Username already exists.";
                    lblPasswordError.Text = "";
                    txtPassword.Text = "";
                    txtConfirmationPassword.Text = "";
                    lblConfirmationPasswordError.Text = "";
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                    return;
                }

                if (!UserCommands.CheckUsernameExists(userName))
                {
                    if (enteredPassword != confirmationPassword)
                    {
                        lblConfirmationPasswordError.Text = "The passwords you entered don't match";
                        lblPasswordError.Text = "";
                        txtConfirmationPassword.Focus();
                        txtConfirmationPassword.SelectAll();
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
                            txtConfirmationPassword.Text = "";
                            this.Close();
                        }
                        else
                        {
                            lblPasswordError.Text = "Password must contain the following:" + Environment.NewLine
                                                                                           + "8 Characters." + Environment.NewLine
                                                                                           + "At least one uppercase and one lowercase letter." + Environment.NewLine
                                                                                           + "At least one special character and one number.";
                            lblConfirmationPasswordError.Text = "";
                            txtPassword.Focus();
                            txtPassword.SelectAll();

                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCloseForm control. Closes the form.
        /// </summary>
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
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
                lblConfirmationPasswordError.Text = "Please enter a confirmation password";
            }
            else
            {
                lblConfirmationPasswordError.Text = "";
            }

            if (enteredConfirmationPassword != "" && enteredPassword != "" && enteredUserName != "")
            {
                lblPasswordError.Text = "";
                lblConfirmationPasswordError.Text = "";
                lblUserNameError.Text = "";
                isValid = true;
            }

            return isValid;
        }

        #endregion Methods
    }
}