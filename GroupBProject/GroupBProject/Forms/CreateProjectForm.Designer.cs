namespace GroupBProject.Forms
{
    partial class CreateProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProjectForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.lblProjectAddress = new System.Windows.Forms.Label();
            this.txtProjectAddress = new System.Windows.Forms.TextBox();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.lblHeadInspector = new System.Windows.Forms.Label();
            this.txtHeadInspector = new System.Windows.Forms.TextBox();
            this.btnAssignHeadInspector = new System.Windows.Forms.Button();
            this.btnRemoveHeadInspector = new System.Windows.Forms.Button();
            this.chkProjectComplete = new System.Windows.Forms.CheckBox();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnRemoveJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lblCurrentJobs = new System.Windows.Forms.Label();
            this.lstCurrenftJobs = new System.Windows.Forms.ListBox();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTheTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblErrorRemove = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpJobs = new System.Windows.Forms.Panel();
            this.lblJobError = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpJobs.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(468, 29);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create New Project";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Location = new System.Drawing.Point(362, 31);
            this.lblProjectTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(95, 20);
            this.lblProjectTitle.TabIndex = 1;
            this.lblProjectTitle.Text = "Project Title:";
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(534, 28);
            this.txtProjectTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectTitle.Multiline = true;
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(307, 36);
            this.txtProjectTitle.TabIndex = 0;
            this.txtProjectTitle.Tag = "Title";
            // 
            // lblProjectAddress
            // 
            this.lblProjectAddress.AutoSize = true;
            this.lblProjectAddress.Location = new System.Drawing.Point(362, 88);
            this.lblProjectAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectAddress.Name = "lblProjectAddress";
            this.lblProjectAddress.Size = new System.Drawing.Size(125, 20);
            this.lblProjectAddress.TabIndex = 3;
            this.lblProjectAddress.Text = "Project Address:";
            // 
            // txtProjectAddress
            // 
            this.txtProjectAddress.Location = new System.Drawing.Point(534, 83);
            this.txtProjectAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectAddress.Multiline = true;
            this.txtProjectAddress.Name = "txtProjectAddress";
            this.txtProjectAddress.Size = new System.Drawing.Size(307, 36);
            this.txtProjectAddress.TabIndex = 1;
            this.txtProjectAddress.Tag = "Address";
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Location = new System.Drawing.Point(362, 312);
            this.lblProjectDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Size = new System.Drawing.Size(146, 20);
            this.lblProjectDescription.TabIndex = 5;
            this.lblProjectDescription.Text = "Project Description:";
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(534, 262);
            this.txtProjectDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(307, 132);
            this.txtProjectDescription.TabIndex = 3;
            this.txtProjectDescription.Tag = "Description";
            // 
            // lblHeadInspector
            // 
            this.lblHeadInspector.AutoSize = true;
            this.lblHeadInspector.Location = new System.Drawing.Point(362, 166);
            this.lblHeadInspector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadInspector.Name = "lblHeadInspector";
            this.lblHeadInspector.Size = new System.Drawing.Size(123, 20);
            this.lblHeadInspector.TabIndex = 7;
            this.lblHeadInspector.Text = "Head Inspector:";
            // 
            // txtHeadInspector
            // 
            this.txtHeadInspector.Location = new System.Drawing.Point(534, 162);
            this.txtHeadInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeadInspector.Multiline = true;
            this.txtHeadInspector.Name = "txtHeadInspector";
            this.txtHeadInspector.ReadOnly = true;
            this.txtHeadInspector.Size = new System.Drawing.Size(307, 36);
            this.txtHeadInspector.TabIndex = 2;
            // 
            // btnAssignHeadInspector
            // 
            this.btnAssignHeadInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnAssignHeadInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignHeadInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignHeadInspector.ForeColor = System.Drawing.Color.White;
            this.btnAssignHeadInspector.Location = new System.Drawing.Point(26, 166);
            this.btnAssignHeadInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignHeadInspector.Name = "btnAssignHeadInspector";
            this.btnAssignHeadInspector.Size = new System.Drawing.Size(285, 63);
            this.btnAssignHeadInspector.TabIndex = 0;
            this.btnAssignHeadInspector.Text = "Assign Head Inspector";
            this.btnAssignHeadInspector.UseVisualStyleBackColor = false;
            this.btnAssignHeadInspector.Click += new System.EventHandler(this.btnAssignHeadInspector_Click);
            // 
            // btnRemoveHeadInspector
            // 
            this.btnRemoveHeadInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRemoveHeadInspector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveHeadInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveHeadInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHeadInspector.ForeColor = System.Drawing.Color.White;
            this.btnRemoveHeadInspector.Location = new System.Drawing.Point(26, 269);
            this.btnRemoveHeadInspector.Name = "btnRemoveHeadInspector";
            this.btnRemoveHeadInspector.Size = new System.Drawing.Size(285, 63);
            this.btnRemoveHeadInspector.TabIndex = 1;
            this.btnRemoveHeadInspector.Text = "Remove Head Inspector";
            this.btnRemoveHeadInspector.UseVisualStyleBackColor = false;
            this.btnRemoveHeadInspector.Click += new System.EventHandler(this.btnRemoveHeadInspector_Click);
            // 
            // chkProjectComplete
            // 
            this.chkProjectComplete.AutoSize = true;
            this.chkProjectComplete.Location = new System.Drawing.Point(344, 400);
            this.chkProjectComplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkProjectComplete.Name = "chkProjectComplete";
            this.chkProjectComplete.Size = new System.Drawing.Size(156, 24);
            this.chkProjectComplete.TabIndex = 4;
            this.chkProjectComplete.Text = "Project Complete";
            this.chkProjectComplete.UseVisualStyleBackColor = true;
            // 
            // btnEditJob
            // 
            this.btnEditJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnEditJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditJob.ForeColor = System.Drawing.Color.White;
            this.btnEditJob.Location = new System.Drawing.Point(22, 235);
            this.btnEditJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(285, 63);
            this.btnEditJob.TabIndex = 2;
            this.btnEditJob.Text = "Edit Job";
            this.btnEditJob.UseVisualStyleBackColor = false;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRemoveJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveJob.ForeColor = System.Drawing.Color.White;
            this.btnRemoveJob.Location = new System.Drawing.Point(22, 325);
            this.btnRemoveJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(285, 63);
            this.btnRemoveJob.TabIndex = 3;
            this.btnRemoveJob.Text = "Remove Job From Project";
            this.btnRemoveJob.UseVisualStyleBackColor = false;
            this.btnRemoveJob.Click += new System.EventHandler(this.btnRemoveJob_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJob.ForeColor = System.Drawing.Color.White;
            this.btnAddJob.Location = new System.Drawing.Point(22, 145);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(285, 63);
            this.btnAddJob.TabIndex = 1;
            this.btnAddJob.Text = "Add Job to Project";
            this.btnAddJob.UseVisualStyleBackColor = false;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // lblCurrentJobs
            // 
            this.lblCurrentJobs.AutoSize = true;
            this.lblCurrentJobs.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentJobs.Location = new System.Drawing.Point(458, 65);
            this.lblCurrentJobs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentJobs.Name = "lblCurrentJobs";
            this.lblCurrentJobs.Size = new System.Drawing.Size(417, 29);
            this.lblCurrentJobs.TabIndex = 2;
            this.lblCurrentJobs.Text = "Jobs Currently Assigned to Project";
            // 
            // lstCurrenftJobs
            // 
            this.lstCurrenftJobs.FormattingEnabled = true;
            this.lstCurrenftJobs.ItemHeight = 20;
            this.lstCurrenftJobs.Location = new System.Drawing.Point(366, 158);
            this.lstCurrenftJobs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCurrenftJobs.Name = "lstCurrenftJobs";
            this.lstCurrenftJobs.Size = new System.Drawing.Size(620, 264);
            this.lstCurrenftJobs.TabIndex = 0;
            this.lstCurrenftJobs.SelectedIndexChanged += new System.EventHandler(this.lstCurrenftJobs_SelectedIndexChanged);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSaveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProject.ForeColor = System.Drawing.Color.White;
            this.btnSaveProject.Location = new System.Drawing.Point(357, 1197);
            this.btnSaveProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(237, 63);
            this.btnSaveProject.TabIndex = 3;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseVisualStyleBackColor = false;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(698, 1197);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 63);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblTheTitle);
            this.panel1.Controls.Add(this.chkProjectComplete);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblProjectDescription);
            this.panel1.Controls.Add(this.lblProjectTitle);
            this.panel1.Controls.Add(this.txtProjectDescription);
            this.panel1.Controls.Add(this.txtProjectTitle);
            this.panel1.Controls.Add(this.txtHeadInspector);
            this.panel1.Controls.Add(this.lblProjectAddress);
            this.panel1.Controls.Add(this.lblHeadInspector);
            this.panel1.Controls.Add(this.txtProjectAddress);
            this.panel1.Location = new System.Drawing.Point(92, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 488);
            this.panel1.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(854, 312);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(51, 20);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "label6";
            this.lblDescription.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(854, 102);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 20);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "label4";
            this.lblAddress.Visible = false;
            // 
            // lblTheTitle
            // 
            this.lblTheTitle.AutoSize = true;
            this.lblTheTitle.Location = new System.Drawing.Point(854, 31);
            this.lblTheTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheTitle.Name = "lblTheTitle";
            this.lblTheTitle.Size = new System.Drawing.Size(51, 20);
            this.lblTheTitle.TabIndex = 12;
            this.lblTheTitle.Text = "label3";
            this.lblTheTitle.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.lblErrorRemove);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRemoveHeadInspector);
            this.panel2.Controls.Add(this.btnAssignHeadInspector);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 485);
            this.panel2.TabIndex = 5;
            // 
            // lblErrorRemove
            // 
            this.lblErrorRemove.AutoSize = true;
            this.lblErrorRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRemove.Location = new System.Drawing.Point(4, 355);
            this.lblErrorRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorRemove.Name = "lblErrorRemove";
            this.lblErrorRemove.Size = new System.Drawing.Size(64, 22);
            this.lblErrorRemove.TabIndex = 16;
            this.lblErrorRemove.Text = "label3";
            this.lblErrorRemove.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Project Information";
            // 
            // grpJobs
            // 
            this.grpJobs.AutoSize = true;
            this.grpJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.grpJobs.Controls.Add(this.lblJobError);
            this.grpJobs.Controls.Add(this.panel5);
            this.grpJobs.Controls.Add(this.lblCurrentJobs);
            this.grpJobs.Controls.Add(this.lstCurrenftJobs);
            this.grpJobs.Location = new System.Drawing.Point(92, 609);
            this.grpJobs.Name = "grpJobs";
            this.grpJobs.Size = new System.Drawing.Size(1094, 546);
            this.grpJobs.TabIndex = 2;
            // 
            // lblJobError
            // 
            this.lblJobError.AutoSize = true;
            this.lblJobError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobError.Location = new System.Drawing.Point(380, 98);
            this.lblJobError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobError.Name = "lblJobError";
            this.lblJobError.Size = new System.Drawing.Size(70, 25);
            this.lblJobError.TabIndex = 4;
            this.lblJobError.Text = "label3";
            this.lblJobError.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnEditJob);
            this.panel5.Controls.Add(this.btnRemoveJob);
            this.panel5.Controls.Add(this.btnAddJob);
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 543);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assign Jobs";
            // 
            // CreateProjectForm
            // 
            this.AcceptButton = this.btnSaveProject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupBProject.Properties.Resources.concrete_texture;
            this.ClientSize = new System.Drawing.Size(1282, 1050);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.grpJobs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "Project";
            this.Text = "Create / Edit Project Form";
            this.Load += new System.EventHandler(this.CreateProjectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpJobs.ResumeLayout(false);
            this.grpJobs.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.TextBox txtProjectTitle;
        private System.Windows.Forms.Label lblProjectAddress;
        private System.Windows.Forms.TextBox txtProjectAddress;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Label lblHeadInspector;
        private System.Windows.Forms.TextBox txtHeadInspector;
        private System.Windows.Forms.Button btnAssignHeadInspector;
        private System.Windows.Forms.Button btnRemoveJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label lblCurrentJobs;
        private System.Windows.Forms.ListBox lstCurrenftJobs;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkProjectComplete;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnRemoveHeadInspector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel grpJobs;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTheTitle;
        private System.Windows.Forms.Label lblJobError;
        private System.Windows.Forms.Label lblErrorRemove;
    }
}