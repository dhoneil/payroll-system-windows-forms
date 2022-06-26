namespace PayrollSystem.UserControls
{
    partial class usercontrolForgotPassword
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtconfirmanswer = new MetroFramework.Controls.MetroTextBox();
            this.txtanswer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbquestion = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reset Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(291, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(541, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Retrieve account by remembering your Security Question and Answer.";
            // 
            // txtconfirmanswer
            // 
            this.txtconfirmanswer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtconfirmanswer.Lines = new string[0];
            this.txtconfirmanswer.Location = new System.Drawing.Point(376, 382);
            this.txtconfirmanswer.MaxLength = 32767;
            this.txtconfirmanswer.Name = "txtconfirmanswer";
            this.txtconfirmanswer.PasswordChar = '●';
            this.txtconfirmanswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtconfirmanswer.SelectedText = "";
            this.txtconfirmanswer.Size = new System.Drawing.Size(379, 30);
            this.txtconfirmanswer.TabIndex = 2;
            this.txtconfirmanswer.UseSelectable = true;
            this.txtconfirmanswer.UseSystemPasswordChar = true;
            // 
            // txtanswer
            // 
            this.txtanswer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtanswer.Lines = new string[0];
            this.txtanswer.Location = new System.Drawing.Point(376, 317);
            this.txtanswer.MaxLength = 32767;
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.PasswordChar = '●';
            this.txtanswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtanswer.SelectedText = "";
            this.txtanswer.Size = new System.Drawing.Size(379, 30);
            this.txtanswer.TabIndex = 1;
            this.txtanswer.UseSelectable = true;
            this.txtanswer.UseSystemPasswordChar = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(502, 361);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(152, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Confirm Security Answer";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(525, 295);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Security Answer";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(519, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Security Question";
            // 
            // cmbquestion
            // 
            this.cmbquestion.FormattingEnabled = true;
            this.cmbquestion.ItemHeight = 23;
            this.cmbquestion.Items.AddRange(new object[] {
            "What was your childhood nickname?",
            "What is the name of your favorite childhood friend?",
            "In what city or town did your mother and father meet?",
            "What is the middle name of your oldest child?",
            "What is your favorite team?",
            "What is your favorite movie?",
            "What was your favorite sport in high school?",
            "What was your favorite food as a child?",
            "What is the first name of the boy or girl that you first kissed?",
            "What was the make and model of your first car?"});
            this.cmbquestion.Location = new System.Drawing.Point(376, 243);
            this.cmbquestion.Name = "cmbquestion";
            this.cmbquestion.Size = new System.Drawing.Size(379, 29);
            this.cmbquestion.TabIndex = 0;
            this.cmbquestion.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(455, 456);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(233, 34);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Retrieve Password";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // usercontrolForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtconfirmanswer);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbquestion);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolForgotPassword";
            this.Size = new System.Drawing.Size(1130, 632);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtconfirmanswer;
        private MetroFramework.Controls.MetroTextBox txtanswer;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbquestion;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
