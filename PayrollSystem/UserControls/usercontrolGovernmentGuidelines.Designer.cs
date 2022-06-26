namespace PayrollSystem.UserControls
{
    partial class usercontrolGovernmentGuidelines
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvgovernment = new System.Windows.Forms.DataGridView();
            this.lblgovernmentname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgovernment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgovernment
            // 
            this.dgvgovernment.AllowUserToAddRows = false;
            this.dgvgovernment.AllowUserToDeleteRows = false;
            this.dgvgovernment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgovernment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgovernment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvgovernment.Location = new System.Drawing.Point(3, 70);
            this.dgvgovernment.Name = "dgvgovernment";
            this.dgvgovernment.ReadOnly = true;
            this.dgvgovernment.RowHeadersVisible = false;
            this.dgvgovernment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvgovernment.Size = new System.Drawing.Size(616, 496);
            this.dgvgovernment.TabIndex = 18;
            // 
            // lblgovernmentname
            // 
            this.lblgovernmentname.AutoSize = true;
            this.lblgovernmentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgovernmentname.Location = new System.Drawing.Point(3, 0);
            this.lblgovernmentname.Name = "lblgovernmentname";
            this.lblgovernmentname.Size = new System.Drawing.Size(242, 31);
            this.lblgovernmentname.TabIndex = 19;
            this.lblgovernmentname.Text = "Government Name";
            // 
            // usercontrolGovernmentGuidelines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblgovernmentname);
            this.Controls.Add(this.dgvgovernment);
            this.Name = "usercontrolGovernmentGuidelines";
            this.Size = new System.Drawing.Size(622, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgovernment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvgovernment;
        public System.Windows.Forms.Label lblgovernmentname;
    }
}
