using GroupBProject.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// Manage User Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ManageUserForm : Form
    {
        #region Fields

        private List<User> currentGuestUserList = new List<User>();
        private User selectedUser = null;
        private string enteredPassword = "";
        private string confirmationPassword = "";

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageUserForm"/> class.
        /// </summary>
        public ManageUserForm()
        {
            InitializeComponent();
            ShowGuestUsers();
        }

        #endregion Constructors

        #region ButtonClick Methods

        /// <summary>
        /// Handles the Click event of the btnCloseForm control. Close the form.
        /// </summary>
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnUpdateGuest control. Updates the guest user password.
        /// </summary>
        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            enteredPassword = txtPassword.Text;
            confirmationPassword = txtPasswordConfirmation.Text;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a guest user to update", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredPassword == "")
            {
                lblPasswordError.Text = "Password can't be blank";
            }
            else
            {
                lblPasswordError.Text = "";
            }

            if (confirmationPassword == "")
            {
                lblConfirmationError.Text = "Confirmation password can't be blank";
            }
            else
            {
                lblConfirmationError.Text = "";
            }

            if (enteredPassword != "" && confirmationPassword != "")
            {
                if (enteredPassword != confirmationPassword)
                {
                    lblConfirmationError.Text = "Passwords don't match";
                    txtPasswordConfirmation.Focus();
                    txtPasswordConfirmation.SelectAll();
                    return;
                }

                if (enteredPassword == confirmationPassword)
                {
                    lblPasswordError.Text = "";
                    lblConfirmationError.Text = "";

                    if (Validator.IsValidPassword(enteredPassword))
                    {
                        string newPassword = Hashing.HashPassword(enteredPassword);
                        selectedUser.Password = newPassword;
                        selectedUser.UserID = UserCommands.GetUserID(selectedUser.Username);

                        UserCommands.UpdateUser(selectedUser);
                        MessageBox.Show("User successfully modified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblUserName.Text = "";
                        txtPassword.Text = "";
                        txtPasswordConfirmation.Text = "";
                        selectedUser = null;
                        ShowGuestUsers();
                    }
                    else
                    {
                        lblPasswordError.Text = "Password must contain the following: " +
                                                Environment.NewLine
                                                + "8 Characters." + Environment.NewLine
                                                + "At least one uppercase and one lowercase letter." + Environment.NewLine
                                                + "At least one special character.";
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnAddUser control. Opens the form to add a new guest user.
        /// </summary>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            NewGuestUserForm form = new NewGuestUserForm();
            form.ShowDialog();
            ShowGuestUsers();
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteUser control. Deletes guest user from database.
        /// </summary>
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show(
                    $"Are you sure you want to delete {selectedUser.Username}.", "Are You Sure",
                    MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    UserCommands.DeleteUser(selectedUser);
                    MessageBox.Show($"{selectedUser.Username} was successfully deleted", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowGuestUsers();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Unable to delete user", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        #endregion ButtonClick Methods

        #region Methods

        /// <summary>
        /// Populates the listbox with a list of guest users.
        /// </summary>
        private void ShowGuestUsers()
        {
            lstGuestUsers.Items.Clear();

            picBoxWelcomePic.Show();
            pnlUserInfo.Hide();

            currentGuestUserList = UserCommands.GetGuestUsers("Guest");

            lstGuestUsers.DisplayMember = "Username";

            foreach (User user in currentGuestUserList)
            {
                lstGuestUsers.Items.Add(user);
            }

            btnDeleteUser.Enabled = false;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the lstGuestUsers control. Updates the
        /// user to be updated.
        /// </summary>
        private void lstGuestUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBoxWelcomePic.Hide();
            pnlUserInfo.Show();
            selectedUser = (User)lstGuestUsers.SelectedItem;
            lblUserName.Text = selectedUser.Username;
            btnDeleteUser.Enabled = true;
        }

        #endregion Methods
    }
}