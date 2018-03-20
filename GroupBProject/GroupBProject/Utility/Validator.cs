using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GroupBProject.Utility
{
    /// <summary>
    /// Class Validator.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// The title
        /// </summary>
        private static string title = "Entry Error";

        #region Properties

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        #endregion Properties

        /// <summary>
        /// Determines whether the specified text box is present.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <param name="label">The label.</param>
        /// <returns><c>true</c> if the specified text box is present; otherwise, <c>false</c>.</returns>
        public static bool IsPresent(TextBox textBox, Label label)
        {
            if (textBox.Text == "")
            {
                label.Text = textBox.Tag + " is Required";
                label.ForeColor = System.Drawing.Color.Red;
                label.Visible = true;
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
            label.Visible = false;
            return true;
        }

        /// <summary>
        /// Determines whether the specified text box is decimal.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <returns><c>true</c> if the specified text box is decimal; otherwise, <c>false</c>.</returns>
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified text box is int32.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <returns><c>true</c> if the specified text box is int32; otherwise, <c>false</c>.</returns>
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
        }

        /// <summary>
        /// Determines whether [is within range] [the specified text box].
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns><c>true</c> if [is within range] [the specified text box]; otherwise, <c>false</c>.</returns>
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Determines whether [is selected ComboBox] [the specified combo box].
        /// </summary>
        /// <param name="comboBox">The combo box.</param>
        /// <returns><c>true</c> if [is selected ComboBox] [the specified combo box]; otherwise, <c>false</c>.</returns>
        public static bool IsSelectedComboBox(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                comboBox.Focus();
                comboBox.SelectAll();
                MessageBox.Show("Must choose a " + comboBox.Tag, Title);
                return false;
            }
        }

        /// <summary>
        /// Determines whether [is selected ListBox] [the specified list box].
        /// </summary>
        /// <param name="listBox">The combo box.</param>
        /// <returns><c>true</c> if [is selected ListBox] [the specified lsit box]; otherwise, <c>false</c>.</returns>
        public static bool IsSelected(ListBox listBox, Label label)
        {
            if (listBox.SelectedIndex != -1)
            {
                label.Visible = false;
                return true;
            }
            else
            {
                label.Text = "Please choose a job from the list to Update/Remove";
                label.ForeColor = System.Drawing.Color.Red;
                label.Visible = true;
                return false;
            }
        }

        /// <summary>
        /// Determines whether [is valid password] [the specified password].
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns><c>true</c> if [is valid password] [the specified password]; otherwise, <c>false</c>.</returns>
        public static bool IsValidPassword(string password)
        {
            const string PATTERN = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$";
            return Regex.IsMatch(password, PATTERN);
        }
    }
}