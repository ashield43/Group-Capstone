using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// CurrentInspectorForm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CurrentInspectorForm : Form
    {
        #region Fields

        private List<Inspector> allInspectors = new List<Inspector>();
        private Inspector selectedInspector = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentInspectorForm"/> class.
        /// </summary>
        public CurrentInspectorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the CurrentInspectorForm control.
        /// </summary>
        private void CurrentInspectorForm_Load(object sender, EventArgs e)
        {
            ShowInspectors();
        }

        #endregion Constructors

        #region ButtonClickMethods

        /// <summary>
        /// Handles the Click event of the btnAddInspector control.
        /// </summary>
        private void btnAddInspector_Click(object sender, EventArgs e)
        {
            Inspector newInspector = null;

            // new instance of add inspector form, and run the add inspector method to create a new inspector
            AddInspectorForm addInspectorForm = new AddInspectorForm();
            newInspector = addInspectorForm.AddNewInspector();

            // add new inspector to the all inspectors list and refresh the list
            if (newInspector != null)
            {
                allInspectors.Add(newInspector);
                ShowInspectors();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnEditInspector control.
        /// </summary>
        private void btnEditInspector_Click(object sender, EventArgs e)
        {
            selectedInspector = (Inspector)lstCurrentInspectors.SelectedItem;

            AddInspectorForm modifiedInspector = new AddInspectorForm();
            modifiedInspector.EditInspector(selectedInspector);

            ShowInspectors();
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteInspector control.
        /// </summary>
        private void btnDeleteInspector_Click(object sender, EventArgs e)
        {
            selectedInspector = (Inspector)lstCurrentInspectors.SelectedItem;
        }

        #endregion ButtonClickMethods

        #region Methods

        /// <summary>
        /// Shows the inspectors.
        /// </summary>
        private void ShowInspectors()
        {
            lstCurrentInspectors.Items.Clear();

            allInspectors = InspectorCommands.GetActiveInspectors();

            foreach (Inspector i in allInspectors)
            {
                lstCurrentInspectors.Items.Add(i);
            }
        }

        #endregion Methods
    }
}