namespace PayrollSystem.UserControls
{
    partial class usercontrolDTR
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.dgvDTR = new System.Windows.Forms.DataGridView();
            this.contextmenustripdtrentry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTR)).BeginInit();
            this.contextmenustripdtrentry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "DTR -";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.Location = new System.Drawing.Point(82, 19);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(134, 21);
            this.lblempname.TabIndex = 15;
            this.lblempname.Text = "(Emplpyee Name)";
            this.lblempname.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDTR
            // 
            this.dgvDTR.AllowUserToAddRows = false;
            this.dgvDTR.AllowUserToDeleteRows = false;
            this.dgvDTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDTR.Location = new System.Drawing.Point(9, 48);
            this.dgvDTR.Name = "dgvDTR";
            this.dgvDTR.ReadOnly = true;
            this.dgvDTR.RowHeadersVisible = false;
            this.dgvDTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDTR.Size = new System.Drawing.Size(814, 513);
            this.dgvDTR.TabIndex = 16;
            this.dgvDTR.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDTR_CellMouseUp);
            // 
            // contextmenustripdtrentry
            // 
            this.contextmenustripdtrentry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDTRToolStripMenuItem});
            this.contextmenustripdtrentry.Name = "contextmenustriptimesheet";
            this.contextmenustripdtrentry.Size = new System.Drawing.Size(125, 26);
            // 
            // viewDTRToolStripMenuItem
            // 
            this.viewDTRToolStripMenuItem.Name = "viewDTRToolStripMenuItem";
            this.viewDTRToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.viewDTRToolStripMenuItem.Text = "Edit Entry";
            this.viewDTRToolStripMenuItem.Click += new System.EventHandler(this.viewDTRToolStripMenuItem_Click);
            // 
            // usercontrolDTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDTR);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolDTR";
            this.Size = new System.Drawing.Size(836, 573);
            this.Load += new System.EventHandler(this.usercontrolDTR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTR)).EndInit();
            this.contextmenustripdtrentry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.ContextMenuStrip contextmenustripdtrentry;
        private System.Windows.Forms.ToolStripMenuItem viewDTRToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvDTR;
    }
}
