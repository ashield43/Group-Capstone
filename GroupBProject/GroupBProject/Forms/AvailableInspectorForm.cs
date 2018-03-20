using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// AvailableInspectorForm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AvailableInspectorForm : Form
    {
        #region Fields

        private List<Inspector> allAvailableInspectors = new List<Inspector>();
        private Inspector selectedInspector = null;
        private Inspector assignedInspector = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableInspectorForm"/> class.
        /// </summary>
        public AvailableInspectorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the AvailableInspectorForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AvailableInspectorForm_Load(object sender, EventArgs e)
        {
        }

        #endregion Constructors

        #region ButtonClickMethods

        /// <summary>
        /// Handles the Click event of the btnAddInspector control to assign an inspector.
        /// </summary>
        private void btnAddInspector_Click(object sender, EventArgs e)
        {
            if (selectedInspector != null)
            {
                assignedInspector = selectedInspector;
                this.Close();
            }
            else
            {
                lblInspector.Text = "Please choose an inspector to assign";
                lblInspector.Visible = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control to close the form.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion ButtonClickMethods

        #region Methods

        /// <summary>
        /// Assigns the head inspector.
        /// </summary>
        public Inspector AssignHeadInspector()
        {
            this.ShowAvailableHeadInspectors();
            this.ShowDialog();
            return assignedInspector;
        }

        /// <summary>
        /// Assigns the job inspector.
        /// </summary>
        /// <param name="job">The job.</param>
        /// <returns>Inspector.</returns>
        public Inspector AssignJobInspector(Job job)
        {
            this.ShowAvailableJobInspectors(job);
            this.ShowDialog();
            return assignedInspector;
        }

        /// <summary>
        /// Gets the list of available head inspectors.
        /// </summary>
        /// <returns>A list of available head inspectors</returns>
        private List<Inspector> GetAvailableHeadInspectors()
        {
            allAvailableInspectors = InspectorCommands.GetHeadInspectors();
            return allAvailableInspectors;
        }

        /// <summary>
        /// Gets the list of available job inspectors.
        /// </summary>
        /// <param name="job">The job.</param>
        /// <returns>A list of available inspectors</returns>
        private List<Inspector> GetAvailableJobInspectors(Job job)
        {
            var allActiveInspectors = InspectorCommands.GetActiveInspectors();

            foreach (Inspector inspector in allActiveInspectors)
            {
                if (job.CheckInspectorAvailability(inspector))
                {
                    allAvailableInspectors.Add(inspector);
                }
            }
            return allAvailableInspectors;
        }

        /// <summary>
        /// Shows all available head inspectors.
        /// </summary>
        private void ShowAvailableHeadInspectors()
        {
            lstAvailableInspectors.Items.Clear();
            GetAvailableHeadInspectors();

            foreach (Inspector i in allAvailableInspectors)
            {
                lstAvailableInspectors.Items.Add(i);
            }
        }

        /// <summary>
        /// Shows all available job inspectors.
        /// </summary>
        /// <param name="job">The job.</param>
        private void ShowAvailableJobInspectors(Job job)
        {
            lstAvailableInspectors.Items.Clear();
            GetAvailableJobInspectors(job);

            foreach (Inspector i in allAvailableInspectors)
            {
                lstAvailableInspectors.Items.Add(i);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the lstAvailableInspectors control.
        /// </summary>
        private void lstAvailableInspectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update the selected Inspector object each time a new one is selected.
            selectedInspector = (Inspector)lstAvailableInspectors.SelectedItem;
            lblInspector.Visible = false;
        }

        #endregion Methods
    }
}