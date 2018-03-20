namespace GroupBProject.Forms
{
    partial class AvailableInspectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableInspectorForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstAvailableInspectors = new System.Windows.Forms.ListBox();
            this.btnAddInspector = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInspector = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(179, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Available Inspectors";
            // 
            // lstAvailableInspectors
            // 
            this.lstAvailableInspectors.FormattingEnabled = true;
            this.lstAvailableInspectors.ItemHeight = 16;
            this.lstAvailableInspectors.Location = new System.Drawing.Point(13, 14);
            this.lstAvailableInspectors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAvailableInspectors.Name = "lstAvailableInspectors";
            this.lstAvailableInspectors.Size = new System.Drawing.Size(292, 276);
            this.lstAvailableInspectors.TabIndex = 0;
            this.lstAvailableInspectors.SelectedIndexChanged += new System.EventHandler(this.lstAvailableInspectors_SelectedIndexChanged);
            // 
            // btnAddInspector
            // 
            this.btnAddInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnAddInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInspector.ForeColor = System.Drawing.Color.White;
            this.btnAddInspector.Location = new System.Drawing.Point(128, 415);
            this.btnAddInspector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddInspector.Name = "btnAddInspector";
            this.btnAddInspector.Size = new System.Drawing.Size(173, 50);
            this.btnAddInspector.TabIndex = 1;
            this.btnAddInspector.Text = "Assign Inspector";
            this.btnAddInspector.UseVisualStyleBackColor = false;
            this.btnAddInspector.Click += new System.EventHandler(this.btnAddInspector_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(317, 415);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(173, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lstAvailableInspectors);
            this.panel1.Location = new System.Drawing.Point(152, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 303);
            this.panel1.TabIndex = 0;
            // 
            // lblInspector
            // 
            this.lblInspector.AutoSize = true;
            this.lblInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspector.ForeColor = System.Drawing.Color.Red;
            this.lblInspector.Location = new System.Drawing.Point(124, 54);
            this.lblInspector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspector.Name = "lblInspector";
            this.lblInspector.Size = new System.Drawing.Size(59, 20);
            this.lblInspector.TabIndex = 5;
            this.lblInspector.Text = "label1";
            this.lblInspector.Visible = false;
            // 
            // AvailableInspectorForm
            // 
            this.AcceptButton = this.btnAddInspector;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupBProject.Properties.Resources.concrete_texture;
            this.ClientSize = new System.Drawing.Size(616, 496);
            this.Controls.Add(this.lblInspector);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddInspector);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AvailableInspectorForm";
            this.Text = "Available Inspectors";
            this.Load += new System.EventHandler(this.AvailableInspectorForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstAvailableInspectors;
        private System.Windows.Forms.Button btnAddInspector;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInspector;
    }
}