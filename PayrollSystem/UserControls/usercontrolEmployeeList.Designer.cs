namespace PayrollSystem.UserControls
{
    partial class usercontrolEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usercontrolEmployeeList));
            this.txtsearchemployee = new System.Windows.Forms.TextBox();
            this.btnregisteremployee = new System.Windows.Forms.Button();
            this.dgvemployee = new System.Windows.Forms.DataGridView();
            this.cntxtmenustripemployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblheader = new System.Windows.Forms.Label();
            this.dsEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).BeginInit();
            this.cntxtmenustripemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearchemployee
            // 
            this.txtsearchemployee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsearchemployee.Location = new System.Drawing.Point(75, 71);
            this.txtsearchemployee.Name = "txtsearchemployee";
            this.txtsearchemployee.Size = new System.Drawing.Size(555, 29);
            this.txtsearchemployee.TabIndex = 0;
            this.txtsearchemployee.TextChanged += new System.EventHandler(this.txtsearchemployee_TextChanged);
            // 
            // btnregisteremployee
            // 
            this.btnregisteremployee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnregisteremployee.Location = new System.Drawing.Point(809, 71);
            this.btnregisteremployee.Name = "btnregisteremployee";
            this.btnregisteremployee.Size = new System.Drawing.Size(132, 29);
            this.btnregisteremployee.TabIndex = 1;
            this.btnregisteremployee.Text = "Add New Employee";
            this.btnregisteremployee.UseVisualStyleBackColor = true;
            this.btnregisteremployee.Click += new System.EventHandler(this.btnregisteremployee_Click);
            // 
            // dgvemployee
            // 
            this.dgvemployee.AllowUserToAddRows = false;
            this.dgvemployee.AllowUserToDeleteRows = false;
            this.dgvemployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvemployee.Location = new System.Drawing.Point(19, 115);
            this.dgvemployee.Name = "dgvemployee";
            this.dgvemployee.ReadOnly = true;
            this.dgvemployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvemployee.Size = new System.Drawing.Size(922, 365);
            this.dgvemployee.TabIndex = 2;
            this.dgvemployee.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvemployee_CellMouseUp);
            // 
            // cntxtmenustripemployee
            // 
            this.cntxtmenustripemployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.cntxtmenustripemployee.Name = "cntxtmenustripemployee";
            this.cntxtmenustripemployee.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(3, 10);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(181, 37);
            this.lblheader.TabIndex = 15;
            this.lblheader.Text = "Employee List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // usercontrolEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.dgvemployee);
            this.Controls.Add(this.btnregisteremployee);
            this.Controls.Add(this.txtsearchemployee);
            this.Name = "usercontrolEmployeeList";
            this.Size = new System.Drawing.Size(961, 503);
            this.Load += new System.EventHandler(this.usercontrolEmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).EndInit();
            this.cntxtmenustripemployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearchemployee;
        private System.Windows.Forms.Button btnregisteremployee;
        private System.Windows.Forms.DataGridView dgvemployee;
        private System.Windows.Forms.ContextMenuStrip cntxtmenustripemployee;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        //private DataSource.dsEmployeeTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        //private dbPayrollDataSet2 dbPayrollDataSet2;
        //private DataSource.dsEmployee dsEmployee;
        private System.Windows.Forms.BindingSource dsEmployeeBindingSource;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
