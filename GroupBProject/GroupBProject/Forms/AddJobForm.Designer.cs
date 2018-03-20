namespace GroupBProject.Forms
{
    partial class AddJobForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJobForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboAvailableQualifications = new System.Windows.Forms.ComboBox();
            this.btnAssignInspector = new System.Windows.Forms.Button();
            this.btnRemoveInspector = new System.Windows.Forms.Button();
            this.dtpJobDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssignedInspector = new System.Windows.Forms.TextBox();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chkComplete = new System.Windows.Forms.CheckBox();
            this.lblAssignedInspectorError = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRequiredQualificaitonError = new System.Windows.Forms.Label();
            this.lblDescriptionError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblAddEditJob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(48, 132);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(261, 63);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Save Job";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(48, 537);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 63);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(202, 28);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(442, 26);
            this.txtType.TabIndex = 0;
            this.txtType.Tag = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(202, 77);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(442, 26);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Tag = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Time:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.AccessibleDescription = "dtpJobStartTime";
            this.dtpStartTime.AccessibleName = "dtpStartTime";
            this.dtpStartTime.CustomFormat = "HH:00 tt";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(202, 82);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(140, 26);
            this.dtpStartTime.TabIndex = 1;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.AccessibleDescription = "dtpJobStartTime";
            this.dtpEndTime.AccessibleName = "dtpStartTime";
            this.dtpEndTime.CustomFormat = "HH:00 tt";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(202, 143);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(140, 26);
            this.dtpEndTime.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Required Qualification:";
            // 
            // cboAvailableQualifications
            // 
            this.cboAvailableQualifications.FormattingEnabled = true;
            this.cboAvailableQualifications.Location = new System.Drawing.Point(202, 143);
            this.cboAvailableQualifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboAvailableQualifications.Name = "cboAvailableQualifications";
            this.cboAvailableQualifications.Size = new System.Drawing.Size(298, 28);
            this.cboAvailableQualifications.TabIndex = 2;
            this.cboAvailableQualifications.Tag = "Qualification";
            this.cboAvailableQualifications.SelectedIndexChanged += new System.EventHandler(this.cboAvailableQualifications_SelectedIndexChanged);
            // 
            // btnAssignInspector
            // 
            this.btnAssignInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnAssignInspector.Enabled = false;
            this.btnAssignInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignInspector.ForeColor = System.Drawing.Color.White;
            this.btnAssignInspector.Location = new System.Drawing.Point(48, 267);
            this.btnAssignInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignInspector.Name = "btnAssignInspector";
            this.btnAssignInspector.Size = new System.Drawing.Size(261, 63);
            this.btnAssignInspector.TabIndex = 1;
            this.btnAssignInspector.Text = "Assign Inspector";
            this.btnAssignInspector.UseVisualStyleBackColor = false;
            this.btnAssignInspector.Click += new System.EventHandler(this.btnAssignInspector_Click);
            // 
            // btnRemoveInspector
            // 
            this.btnRemoveInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRemoveInspector.Enabled = false;
            this.btnRemoveInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveInspector.ForeColor = System.Drawing.Color.White;
            this.btnRemoveInspector.Location = new System.Drawing.Point(48, 402);
            this.btnRemoveInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveInspector.Name = "btnRemoveInspector";
            this.btnRemoveInspector.Size = new System.Drawing.Size(260, 63);
            this.btnRemoveInspector.TabIndex = 2;
            this.btnRemoveInspector.Text = "Remove Inspector";
            this.btnRemoveInspector.UseVisualStyleBackColor = false;
            this.btnRemoveInspector.Click += new System.EventHandler(this.btnRemoveInspector_Click);
            // 
            // dtpJobDate
            // 
            this.dtpJobDate.Location = new System.Drawing.Point(202, 26);
            this.dtpJobDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpJobDate.Name = "dtpJobDate";
            this.dtpJobDate.Size = new System.Drawing.Size(298, 26);
            this.dtpJobDate.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 40);
            this.label7.TabIndex = 29;
            this.label7.Text = "Assigned\r\nInspector:";
            // 
            // txtAssignedInspector
            // 
            this.txtAssignedInspector.Location = new System.Drawing.Point(202, 205);
            this.txtAssignedInspector.Name = "txtAssignedInspector";
            this.txtAssignedInspector.ReadOnly = true;
            this.txtAssignedInspector.Size = new System.Drawing.Size(442, 26);
            this.txtAssignedInspector.TabIndex = 3;
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataMember = "Qualification";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.btnAssignInspector);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnRemoveInspector);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 742);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.chkComplete);
            this.panel2.Controls.Add(this.lblAssignedInspectorError);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAssignedInspector);
            this.panel2.Controls.Add(this.dtpEndTime);
            this.panel2.Controls.Add(this.dtpStartTime);
            this.panel2.Controls.Add(this.dtpJobDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(466, 372);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 318);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Job is Complete:";
            // 
            // chkComplete
            // 
            this.chkComplete.AutoSize = true;
            this.chkComplete.Location = new System.Drawing.Point(202, 263);
            this.chkComplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkComplete.Name = "chkComplete";
            this.chkComplete.Size = new System.Drawing.Size(22, 21);
            this.chkComplete.TabIndex = 31;
            this.chkComplete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkComplete.UseVisualStyleBackColor = true;
            // 
            // lblAssignedInspectorError
            // 
            this.lblAssignedInspectorError.AutoSize = true;
            this.lblAssignedInspectorError.ForeColor = System.Drawing.Color.Red;
            this.lblAssignedInspectorError.Location = new System.Drawing.Point(681, 214);
            this.lblAssignedInspectorError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignedInspectorError.Name = "lblAssignedInspectorError";
            this.lblAssignedInspectorError.Size = new System.Drawing.Size(0, 20);
            this.lblAssignedInspectorError.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel3.Controls.Add(this.lblRequiredQualificaitonError);
            this.panel3.Controls.Add(this.lblDescriptionError);
            this.panel3.Controls.Add(this.lblNameError);
            this.panel3.Controls.Add(this.cboAvailableQualifications);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(466, 129);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1078, 214);
            this.panel3.TabIndex = 0;
            // 
            // lblRequiredQualificaitonError
            // 
            this.lblRequiredQualificaitonError.AutoSize = true;
            this.lblRequiredQualificaitonError.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredQualificaitonError.Location = new System.Drawing.Point(676, 151);
            this.lblRequiredQualificaitonError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequiredQualificaitonError.Name = "lblRequiredQualificaitonError";
            this.lblRequiredQualificaitonError.Size = new System.Drawing.Size(0, 20);
            this.lblRequiredQualificaitonError.TabIndex = 27;
            // 
            // lblDescriptionError
            // 
            this.lblDescriptionError.AutoSize = true;
            this.lblDescriptionError.ForeColor = System.Drawing.Color.Red;
            this.lblDescriptionError.Location = new System.Drawing.Point(676, 88);
            this.lblDescriptionError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionError.Name = "lblDescriptionError";
            this.lblDescriptionError.Size = new System.Drawing.Size(0, 20);
            this.lblDescriptionError.TabIndex = 26;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(676, 37);
            this.lblNameError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 20);
            this.lblNameError.TabIndex = 25;
            // 
            // lblAddEditJob
            // 
            this.lblAddEditJob.AutoSize = true;
            this.lblAddEditJob.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditJob.Location = new System.Drawing.Point(738, 46);
            this.lblAddEditJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddEditJob.Name = "lblAddEditJob";
            this.lblAddEditJob.Size = new System.Drawing.Size(142, 31);
            this.lblAddEditJob.TabIndex = 34;
            this.lblAddEditJob.Text = "Add a Job";
            // 
            // AddJobForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupBProject.Properties.Resources.concrete_texture;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1672, 740);
            this.Controls.Add(this.lblAddEditJob);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddJobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Job";
            this.Load += new System.EventHandler(this.AddJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboAvailableQualifications;
        private System.Windows.Forms.Button btnAssignInspector;
        private System.Windows.Forms.Button btnRemoveInspector;
        private System.Windows.Forms.DateTimePicker dtpJobDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssignedInspector;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAddEditJob;
        private System.Windows.Forms.Label lblAssignedInspectorError;
        private System.Windows.Forms.Label lblRequiredQualificaitonError;
        private System.Windows.Forms.Label lblDescriptionError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.CheckBox chkComplete;
        private System.Windows.Forms.Label label8;
    }
}