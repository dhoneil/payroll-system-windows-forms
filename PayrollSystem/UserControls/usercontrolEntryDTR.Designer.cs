namespace PayrollSystem.UserControls
{
    partial class usercontrolEntryDTR
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbldateentry = new System.Windows.Forms.Label();
            this.dtptimeout = new System.Windows.Forms.DateTimePicker();
            this.dtptimein = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmode = new System.Windows.Forms.ComboBox();
            this.btnpost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(77, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "DTR Entry On -";
            // 
            // lbldateentry
            // 
            this.lbldateentry.AutoSize = true;
            this.lbldateentry.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbldateentry.Location = new System.Drawing.Point(188, 18);
            this.lbldateentry.Name = "lbldateentry";
            this.lbldateentry.Size = new System.Drawing.Size(82, 21);
            this.lbldateentry.TabIndex = 17;
            this.lbldateentry.Text = "Date Entry";
            // 
            // dtptimeout
            // 
            this.dtptimeout.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptimeout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtptimeout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtptimeout.Location = new System.Drawing.Point(200, 174);
            this.dtptimeout.Name = "dtptimeout";
            this.dtptimeout.ShowUpDown = true;
            this.dtptimeout.Size = new System.Drawing.Size(120, 29);
            this.dtptimeout.TabIndex = 26;
            // 
            // dtptimein
            // 
            this.dtptimein.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptimein.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtptimein.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtptimein.Location = new System.Drawing.Point(44, 174);
            this.dtptimein.Name = "dtptimein";
            this.dtptimein.ShowUpDown = true;
            this.dtptimein.Size = new System.Drawing.Size(121, 29);
            this.dtptimein.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(196, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Time Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Time In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mode";
            // 
            // cmbmode
            // 
            this.cmbmode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbmode.FormattingEnabled = true;
            this.cmbmode.Location = new System.Drawing.Point(44, 88);
            this.cmbmode.Name = "cmbmode";
            this.cmbmode.Size = new System.Drawing.Size(276, 29);
            this.cmbmode.TabIndex = 29;
            this.cmbmode.SelectionChangeCommitted += new System.EventHandler(this.cmbmode_SelectionChangeCommitted);
            // 
            // btnpost
            // 
            this.btnpost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnpost.Location = new System.Drawing.Point(44, 218);
            this.btnpost.Name = "btnpost";
            this.btnpost.Size = new System.Drawing.Size(276, 36);
            this.btnpost.TabIndex = 30;
            this.btnpost.Text = "POST";
            this.btnpost.UseVisualStyleBackColor = true;
            this.btnpost.Click += new System.EventHandler(this.btnpost_Click);
            // 
            // usercontrolEntryDTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnpost);
            this.Controls.Add(this.cmbmode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtptimeout);
            this.Controls.Add(this.dtptimein);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldateentry);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolEntryDTR";
            this.Size = new System.Drawing.Size(354, 295);
            this.Load += new System.EventHandler(this.usercontrolEntryDTR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldateentry;
        private System.Windows.Forms.DateTimePicker dtptimeout;
        private System.Windows.Forms.DateTimePicker dtptimein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmode;
        private System.Windows.Forms.Button btnpost;
    }
}
