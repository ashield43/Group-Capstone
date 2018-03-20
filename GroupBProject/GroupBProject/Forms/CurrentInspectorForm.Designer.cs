namespace GroupBProject.Forms
{
    partial class CurrentInspectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentInspectorForm));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lstCurrentInspectors = new System.Windows.Forms.ListBox();
            this.btnAddInspector = new System.Windows.Forms.Button();
            this.btnEditInspector = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(268, 60);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(300, 33);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Available Inspectors";
            // 
            // lstCurrentInspectors
            // 
            this.lstCurrentInspectors.FormattingEnabled = true;
            this.lstCurrentInspectors.ItemHeight = 20;
            this.lstCurrentInspectors.Location = new System.Drawing.Point(20, 20);
            this.lstCurrentInspectors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCurrentInspectors.Name = "lstCurrentInspectors";
            this.lstCurrentInspectors.Size = new System.Drawing.Size(446, 384);
            this.lstCurrentInspectors.TabIndex = 0;
            // 
            // btnAddInspector
            // 
            this.btnAddInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnAddInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInspector.ForeColor = System.Drawing.Color.White;
            this.btnAddInspector.Location = new System.Drawing.Point(57, 611);
            this.btnAddInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddInspector.Name = "btnAddInspector";
            this.btnAddInspector.Size = new System.Drawing.Size(210, 63);
            this.btnAddInspector.TabIndex = 1;
            this.btnAddInspector.Text = "Add New Inspector";
            this.btnAddInspector.UseVisualStyleBackColor = false;
            this.btnAddInspector.Click += new System.EventHandler(this.btnAddInspector_Click);
            // 
            // btnEditInspector
            // 
            this.btnEditInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnEditInspector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInspector.ForeColor = System.Drawing.Color.White;
            this.btnEditInspector.Location = new System.Drawing.Point(319, 611);
            this.btnEditInspector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditInspector.Name = "btnEditInspector";
            this.btnEditInspector.Size = new System.Drawing.Size(210, 63);
            this.btnEditInspector.TabIndex = 2;
            this.btnEditInspector.Text = "Edit Inspector";
            this.btnEditInspector.UseVisualStyleBackColor = false;
            this.btnEditInspector.Click += new System.EventHandler(this.btnEditInspector_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(581, 611);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(210, 63);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lstCurrentInspectors);
            this.panel1.Location = new System.Drawing.Point(178, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 425);
            this.panel1.TabIndex = 0;
            // 
            // CurrentInspectorForm
            // 
            this.AcceptButton = this.btnAddInspector;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupBProject.Properties.Resources.concrete_texture;
            this.ClientSize = new System.Drawing.Size(864, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditInspector);
            this.Controls.Add(this.btnAddInspector);
            this.Controls.Add(this.lblFormTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentInspectorForm";
            this.Text = "Available Inspectors";
            this.Load += new System.EventHandler(this.CurrentInspectorForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ListBox lstCurrentInspectors;
        private System.Windows.Forms.Button btnAddInspector;
        private System.Windows.Forms.Button btnEditInspector;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}