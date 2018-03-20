using GroupBProject.Business;
using GroupBProject.Database;
using GroupBProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GroupBProject
{
    public partial class AddInspectorForm : Form
    {
        #region Fields

        private Inspector inspectorAdded = null;
        private Inspector inspectorModified = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddInspectorForm"/> class.
        /// </summary>
        public AddInspectorForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Adds the new inspector.
        /// </summary>
        public Inspector AddNewInspector()
        {
            this.ShowDialog();
            if (inspectorAdded != null)
            {
                inspectorAdded.InspectorID = InspectorCommands.AddInspector(inspectorAdded);
            }

            return inspectorAdded;
        }

        /// <summary>
        /// Edits the inspector.
        /// </summary>
        /// <param name="selectedInspector">The selected inspector.</param>
        public void EditInspector(Inspector selectedInspector)
        {
            this.Text = "Edit Inspector";
            lblFormTitle.Text = "Edit Inspector";

            if (selectedInspector == null)
            {
                MessageBox.Show("Please select an inspector to edit", "Inspector Edit Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            inspectorModified = selectedInspector;
            txtFirstName.Text = inspectorModified.FirstName;
            txtLastName.Text = inspectorModified.LastName;
            txtEmail.Text = inspectorModified.Email;
            txtPhone.Text = inspectorModified.Phone;
            chkIsActive.Checked = inspectorModified.IsActive;

            foreach (Control control in pnlQualifications.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkbox = (CheckBox)control;

                    if (inspectorModified.Qualifications.Any(qualification => qualification.Name == checkbox.Text))
                    {
                        checkbox.Checked = true;
                    }
                }
            }

            foreach (DailyAvailability dailyAvailability in inspectorModified.WeeklyAvailability)
            {
                switch (dailyAvailability.DayOfWeek.ToString())
                {
                    case "Monday":
                        dtpMondayStartTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.StartTime, 0, 0);
                        dtpMondayEndTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.EndTime, 0, 0);
                        chkMondayIsAvailable.Checked = dailyAvailability.IsAvailable;
                        break;

                    case "Tuesday":
                        dtpTuesdayStartTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.StartTime, 0, 0);
                        dtpTuesdayEndTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.EndTime, 0, 0);
                        chkTuesdayIsAvailable.Checked = dailyAvailability.IsAvailable;
                        break;

                    case "Wednesday":
                        dtpWednesdayStartTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.StartTime, 0, 0);
                        dtpWednesdayEndTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.EndTime, 0, 0);
                        chkWednesdayIsAvailable.Checked = dailyAvailability.IsAvailable;
                        break;

                    case "Thursday":
                        dtpThursdayStartTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.StartTime, 0, 0);
                        dtpThursdayEndTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.EndTime, 0, 0);
                        chkThursdayIsAvailable.Checked = dailyAvailability.IsAvailable;
                        break;

                    case "Friday":
                        dtpFridayStartTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.StartTime, 0, 0);
                        dtpFridayEndTime.Value = DateTime.Today + new TimeSpan(dailyAvailability.EndTime, 0, 0);
                        chkFridayIsAvailable.Checked = dailyAvailability.IsAvailable;
                        break;
                }
            }

            this.ShowDialog();
            return;
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        private void CancelForm(object sender, EventArgs e)
        {
            inspectorAdded = null;
            this.Close();
        }

        /// <summary>
        /// Validates the form data
        /// </summary>
        /// <returns><c>true</c> if form data is valid; otherwise, <c>false</c>.</returns>
        private bool IsValid()
        {
            bool isValid = true;
            lblError.Text = "";

            if (txtFirstName.Text == "")
            {
                isValid = false;
                lblError.Text += "First name is required." + '\n';
            }

            if (txtLastName.Text == "")
            {
                isValid = false;
                lblError.Text += "Last name is required." + '\n';
            }

            if (txtEmail.Text == "")
            {
                isValid = false;
                lblError.Text += "Email is required." + '\n';
            }
            else if (!Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                isValid = false;
                lblError.Text += "Invalid email." + '\n';
            }

            if (txtPhone.Text == "")
            {
                isValid = false;
                lblError.Text += "Phone number is required." + '\n';
            }
            else if (!Regex.Match(txtPhone.Text, @"^\(?\d{3}\)?[- ]?\d{3}[- ]?\d{4}$").Success)
            {
                isValid = false;
                lblError.Text += "Invalid phone number." + '\n';
            }
            return isValid;
        }

        /// <summary>
        /// Handles the Load event of the AddInspectorForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddInspectorForm_Load(object sender, EventArgs e)
        {
        }

        #endregion Methods

        #region ButtonClickMethods

        /// <summary>
        /// Handles the Click event of the btnSaveInspector control.
        /// </summary>
        private void btnSaveInspector_Click(object sender, EventArgs e)
        {
            string firstName;
            string lastName;
            string email;
            string phone;
            bool isActive;
            List<Qualification> qualifications = new List<Qualification>();
            List<DailyAvailability> availability = new List<DailyAvailability>();

            if (IsValid())
            {
                // required fields
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                email = txtEmail.Text;
                phone = txtPhone.Text;
                isActive = chkIsActive.Checked;

                //qualifications
                foreach (Control control in pnlQualifications.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkbox = (CheckBox)control;

                        if (checkbox.Checked)
                        {
                            qualifications.Add(QualificationCommands.GetQualificationByName(checkbox.Text));
                        }
                    }
                }

                //availability
                availability.Add(new DailyAvailability("Monday", Convert.ToInt16(dtpMondayStartTime.Value.Hour), Convert.ToInt16(dtpMondayEndTime.Value.Hour), chkMondayIsAvailable.Checked));
                availability.Add(new DailyAvailability("Tuesday", Convert.ToInt16(dtpTuesdayStartTime.Value.Hour), Convert.ToInt16(dtpTuesdayEndTime.Value.Hour), chkTuesdayIsAvailable.Checked));
                availability.Add(new DailyAvailability("Wednesday", Convert.ToInt16(dtpWednesdayStartTime.Value.Hour), Convert.ToInt16(dtpWednesdayEndTime.Value.Hour), chkWednesdayIsAvailable.Checked));
                availability.Add(new DailyAvailability("Thursday", Convert.ToInt16(dtpThursdayStartTime.Value.Hour), Convert.ToInt16(dtpThursdayEndTime.Value.Hour), chkThursdayIsAvailable.Checked));
                availability.Add(new DailyAvailability("Friday", Convert.ToInt16(dtpFridayStartTime.Value.Hour), Convert.ToInt16(dtpFridayEndTime.Value.Hour), chkFridayIsAvailable.Checked));

                if (inspectorModified == null)
                {
                    // add new inspector
                    inspectorAdded = new Inspector(firstName, lastName, email, phone, isActive, availability, qualifications);
                }
                else
                {
                    //edit previously selected inspector
                    inspectorModified.FirstName = firstName;
                    inspectorModified.LastName = lastName;
                    inspectorModified.Email = email;
                    inspectorModified.Phone = phone;
                    inspectorModified.IsActive = isActive;
                    inspectorModified.WeeklyAvailability = availability;
                    inspectorModified.Qualifications = qualifications;

                    if (InspectorCommands.DeactivateInspectorValidation(inspectorModified))
                    {
                        InspectorCommands.EditInspector(inspectorModified);
                    }
                    else
                    {
                        MessageBox.Show("This inspector cannot be deactivated at this time", "Deactivation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }

        #endregion ButtonClickMethods
    }
}