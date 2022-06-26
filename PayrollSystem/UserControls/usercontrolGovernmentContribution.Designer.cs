namespace PayrollSystem.UserControls
{
    partial class usercontrolGovernmentContribution
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
            this.dgvemployeegovernment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployeegovernment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvemployeegovernment
            // 
            this.dgvemployeegovernment.AllowUserToAddRows = false;
            this.dgvemployeegovernment.AllowUserToDeleteRows = false;
            this.dgvemployeegovernment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvemployeegovernment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployeegovernment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvemployeegovernment.Location = new System.Drawing.Point(3, 3);
            this.dgvemployeegovernment.Name = "dgvemployeegovernment";
            this.dgvemployeegovernment.ReadOnly = true;
            this.dgvemployeegovernment.RowHeadersVisible = false;
            this.dgvemployeegovernment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvemployeegovernment.Size = new System.Drawing.Size(674, 384);
            this.dgvemployeegovernment.TabIndex = 17;
            // 
            // usercontrolGovernmentContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvemployeegovernment);
            this.Name = "usercontrolGovernmentContribution";
            this.Size = new System.Drawing.Size(680, 390);
            this.Load += new System.EventHandler(this.usercontrolGovernmentContribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployeegovernment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvemployeegovernment;


    }
}
