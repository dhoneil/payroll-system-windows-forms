namespace PayrollSystem.UserControls
{
    partial class usercontrolPayslipDetail
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
            this.lblemployeename = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnaddadditional = new System.Windows.Forms.Button();
            this.txtadditionalamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadditionalname = new System.Windows.Forms.TextBox();
            this.lbladditional = new System.Windows.Forms.Label();
            this.dgvadditionaladjustments = new System.Windows.Forms.DataGridView();
            this.dgvadditionals = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnadddeduction = new System.Windows.Forms.Button();
            this.txtdeductionamount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdeductioname = new System.Windows.Forms.TextBox();
            this.lblloanamount = new System.Windows.Forms.Label();
            this.lblsssamount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblphilhealthamount = new System.Windows.Forms.Label();
            this.lblpagibigamount = new System.Windows.Forms.Label();
            this.dgvdeductionadjustments = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblundertimeamount = new System.Windows.Forms.Label();
            this.lbllatesamount = new System.Windows.Forms.Label();
            this.lblabsencesamount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblsummarynetpayamount = new System.Windows.Forms.Label();
            this.lblsummarydeductionsamount = new System.Windows.Forms.Label();
            this.lblsummarygrossamount = new System.Windows.Forms.Label();
            this.lblsummarylessamount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblsummaryadditionalsamount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblsummaryrateamount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnprintpayslip = new System.Windows.Forms.Button();
            this.printdocument = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadditionaladjustments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadditionals)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeductionadjustments)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Payslip Detail - ";
            // 
            // lblemployeename
            // 
            this.lblemployeename.AutoSize = true;
            this.lblemployeename.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeename.Location = new System.Drawing.Point(192, 10);
            this.lblemployeename.Name = "lblemployeename";
            this.lblemployeename.Size = new System.Drawing.Size(212, 37);
            this.lblemployeename.TabIndex = 20;
            this.lblemployeename.Text = "Employee Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnaddadditional);
            this.groupBox1.Controls.Add(this.txtadditionalamount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtadditionalname);
            this.groupBox1.Controls.Add(this.lbladditional);
            this.groupBox1.Controls.Add(this.dgvadditionaladjustments);
            this.groupBox1.Controls.Add(this.dgvadditionals);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(841, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 573);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADDITIONALS";
            // 
            // btnaddadditional
            // 
            this.btnaddadditional.Enabled = false;
            this.btnaddadditional.Location = new System.Drawing.Point(359, 538);
            this.btnaddadditional.Name = "btnaddadditional";
            this.btnaddadditional.Size = new System.Drawing.Size(75, 23);
            this.btnaddadditional.TabIndex = 34;
            this.btnaddadditional.Text = "ADD";
            this.btnaddadditional.UseVisualStyleBackColor = true;
            this.btnaddadditional.Click += new System.EventHandler(this.btnaddadditional_Click);
            // 
            // txtadditionalamount
            // 
            this.txtadditionalamount.Enabled = false;
            this.txtadditionalamount.Location = new System.Drawing.Point(237, 539);
            this.txtadditionalamount.Name = "txtadditionalamount";
            this.txtadditionalamount.Size = new System.Drawing.Size(116, 22);
            this.txtadditionalamount.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Amount";
            // 
            // txtadditionalname
            // 
            this.txtadditionalname.Enabled = false;
            this.txtadditionalname.Location = new System.Drawing.Point(19, 539);
            this.txtadditionalname.Name = "txtadditionalname";
            this.txtadditionalname.Size = new System.Drawing.Size(213, 22);
            this.txtadditionalname.TabIndex = 33;
            // 
            // lbladditional
            // 
            this.lbladditional.AutoSize = true;
            this.lbladditional.Location = new System.Drawing.Point(16, 523);
            this.lbladditional.Name = "lbladditional";
            this.lbladditional.Size = new System.Drawing.Size(93, 13);
            this.lbladditional.TabIndex = 22;
            this.lbladditional.Text = "Additional Name";
            // 
            // dgvadditionaladjustments
            // 
            this.dgvadditionaladjustments.AllowUserToAddRows = false;
            this.dgvadditionaladjustments.AllowUserToDeleteRows = false;
            this.dgvadditionaladjustments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadditionaladjustments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvadditionaladjustments.Location = new System.Drawing.Point(20, 355);
            this.dgvadditionaladjustments.Name = "dgvadditionaladjustments";
            this.dgvadditionaladjustments.RowHeadersVisible = false;
            this.dgvadditionaladjustments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadditionaladjustments.Size = new System.Drawing.Size(415, 160);
            this.dgvadditionaladjustments.TabIndex = 32;
            // 
            // dgvadditionals
            // 
            this.dgvadditionals.AllowUserToAddRows = false;
            this.dgvadditionals.AllowUserToDeleteRows = false;
            this.dgvadditionals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadditionals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvadditionals.Location = new System.Drawing.Point(20, 52);
            this.dgvadditionals.Name = "dgvadditionals";
            this.dgvadditionals.RowHeadersVisible = false;
            this.dgvadditionals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadditionals.Size = new System.Drawing.Size(415, 256);
            this.dgvadditionals.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Adjustments";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Salary Additionals";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnadddeduction);
            this.groupBox2.Controls.Add(this.txtdeductionamount);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtdeductioname);
            this.groupBox2.Controls.Add(this.lblloanamount);
            this.groupBox2.Controls.Add(this.lblsssamount);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblphilhealthamount);
            this.groupBox2.Controls.Add(this.lblpagibigamount);
            this.groupBox2.Controls.Add(this.dgvdeductionadjustments);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(384, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 454);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DEDUCTIONS";
            // 
            // btnadddeduction
            // 
            this.btnadddeduction.Enabled = false;
            this.btnadddeduction.Location = new System.Drawing.Point(346, 414);
            this.btnadddeduction.Name = "btnadddeduction";
            this.btnadddeduction.Size = new System.Drawing.Size(75, 23);
            this.btnadddeduction.TabIndex = 34;
            this.btnadddeduction.Text = "ADD";
            this.btnadddeduction.UseVisualStyleBackColor = true;
            this.btnadddeduction.Click += new System.EventHandler(this.btnadddduction_Click);
            // 
            // txtdeductionamount
            // 
            this.txtdeductionamount.Enabled = false;
            this.txtdeductionamount.Location = new System.Drawing.Point(224, 415);
            this.txtdeductionamount.Name = "txtdeductionamount";
            this.txtdeductionamount.Size = new System.Drawing.Size(116, 22);
            this.txtdeductionamount.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Loan";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "SSS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "PHILHEALTH";
            // 
            // txtdeductioname
            // 
            this.txtdeductioname.Enabled = false;
            this.txtdeductioname.Location = new System.Drawing.Point(6, 415);
            this.txtdeductioname.Name = "txtdeductioname";
            this.txtdeductioname.Size = new System.Drawing.Size(213, 22);
            this.txtdeductioname.TabIndex = 33;
            // 
            // lblloanamount
            // 
            this.lblloanamount.Location = new System.Drawing.Point(170, 169);
            this.lblloanamount.Name = "lblloanamount";
            this.lblloanamount.Size = new System.Drawing.Size(83, 13);
            this.lblloanamount.TabIndex = 0;
            this.lblloanamount.Text = "0.00";
            this.lblloanamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblsssamount
            // 
            this.lblsssamount.Location = new System.Drawing.Point(170, 112);
            this.lblsssamount.Name = "lblsssamount";
            this.lblsssamount.Size = new System.Drawing.Size(83, 13);
            this.lblsssamount.TabIndex = 0;
            this.lblsssamount.Text = "0.00";
            this.lblsssamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Government Deduction";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Adjustments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Deduction Name";
            // 
            // lblphilhealthamount
            // 
            this.lblphilhealthamount.Location = new System.Drawing.Point(170, 81);
            this.lblphilhealthamount.Name = "lblphilhealthamount";
            this.lblphilhealthamount.Size = new System.Drawing.Size(83, 13);
            this.lblphilhealthamount.TabIndex = 0;
            this.lblphilhealthamount.Text = "0.00";
            this.lblphilhealthamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblpagibigamount
            // 
            this.lblpagibigamount.Location = new System.Drawing.Point(170, 49);
            this.lblpagibigamount.Name = "lblpagibigamount";
            this.lblpagibigamount.Size = new System.Drawing.Size(83, 13);
            this.lblpagibigamount.TabIndex = 0;
            this.lblpagibigamount.Text = "0.00";
            this.lblpagibigamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvdeductionadjustments
            // 
            this.dgvdeductionadjustments.AllowUserToAddRows = false;
            this.dgvdeductionadjustments.AllowUserToDeleteRows = false;
            this.dgvdeductionadjustments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeductionadjustments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdeductionadjustments.Location = new System.Drawing.Point(6, 232);
            this.dgvdeductionadjustments.Name = "dgvdeductionadjustments";
            this.dgvdeductionadjustments.RowHeadersVisible = false;
            this.dgvdeductionadjustments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdeductionadjustments.Size = new System.Drawing.Size(415, 160);
            this.dgvdeductionadjustments.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "PAG-IBIG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblundertimeamount);
            this.groupBox3.Controls.Add(this.lbllatesamount);
            this.groupBox3.Controls.Add(this.lblabsencesamount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(384, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 113);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LESS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "UNDERTIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "LATES";
            // 
            // lblundertimeamount
            // 
            this.lblundertimeamount.Location = new System.Drawing.Point(166, 80);
            this.lblundertimeamount.Name = "lblundertimeamount";
            this.lblundertimeamount.Size = new System.Drawing.Size(87, 13);
            this.lblundertimeamount.TabIndex = 0;
            this.lblundertimeamount.Text = "0.00";
            this.lblundertimeamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbllatesamount
            // 
            this.lbllatesamount.Location = new System.Drawing.Point(166, 49);
            this.lbllatesamount.Name = "lbllatesamount";
            this.lbllatesamount.Size = new System.Drawing.Size(87, 13);
            this.lbllatesamount.TabIndex = 0;
            this.lbllatesamount.Text = "0.00";
            this.lbllatesamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblabsencesamount
            // 
            this.lblabsencesamount.Location = new System.Drawing.Point(166, 22);
            this.lblabsencesamount.Name = "lblabsencesamount";
            this.lblabsencesamount.Size = new System.Drawing.Size(87, 13);
            this.lblabsencesamount.TabIndex = 0;
            this.lblabsencesamount.Text = "0.00";
            this.lblabsencesamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ABSENCES";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lblsummarynetpayamount);
            this.groupBox4.Controls.Add(this.lblsummarydeductionsamount);
            this.groupBox4.Controls.Add(this.lblsummarygrossamount);
            this.groupBox4.Controls.Add(this.lblsummarylessamount);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lblsummaryadditionalsamount);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblsummaryrateamount);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(10, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 569);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SUMMARY";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 368);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Net Pay";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 283);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Deductions";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Gross Pay";
            // 
            // lblsummarynetpayamount
            // 
            this.lblsummarynetpayamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsummarynetpayamount.Location = new System.Drawing.Point(122, 368);
            this.lblsummarynetpayamount.Name = "lblsummarynetpayamount";
            this.lblsummarynetpayamount.Size = new System.Drawing.Size(159, 20);
            this.lblsummarynetpayamount.TabIndex = 1;
            this.lblsummarynetpayamount.Text = "0.00";
            this.lblsummarynetpayamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblsummarydeductionsamount
            // 
            this.lblsummarydeductionsamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsummarydeductionsamount.Location = new System.Drawing.Point(122, 283);
            this.lblsummarydeductionsamount.Name = "lblsummarydeductionsamount";
            this.lblsummarydeductionsamount.Size = new System.Drawing.Size(159, 20);
            this.lblsummarydeductionsamount.TabIndex = 1;
            this.lblsummarydeductionsamount.Text = "0.00";
            this.lblsummarydeductionsamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblsummarygrossamount
            // 
            this.lblsummarygrossamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsummarygrossamount.Location = new System.Drawing.Point(122, 242);
            this.lblsummarygrossamount.Name = "lblsummarygrossamount";
            this.lblsummarygrossamount.Size = new System.Drawing.Size(159, 20);
            this.lblsummarygrossamount.TabIndex = 1;
            this.lblsummarygrossamount.Text = "0.00";
            this.lblsummarygrossamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblsummarylessamount
            // 
            this.lblsummarylessamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsummarylessamount.Location = new System.Drawing.Point(122, 140);
            this.lblsummarylessamount.Name = "lblsummarylessamount";
            this.lblsummarylessamount.Size = new System.Drawing.Size(162, 20);
            this.lblsummarylessamount.TabIndex = 1;
            this.lblsummarylessamount.Text = "0.00";
            this.lblsummarylessamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Less";
            // 
            // lblsummaryadditionalsamount
            // 
            this.lblsummaryadditionalsamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsummaryadditionalsamount.Location = new System.Drawing.Point(122, 93);
            this.lblsummaryadditionalsamount.Name = "lblsummaryadditionalsamount";
            this.lblsummaryadditionalsamount.Size = new System.Drawing.Size(159, 20);
            this.lblsummaryadditionalsamount.TabIndex = 1;
            this.lblsummaryadditionalsamount.Text = "0.00";
            this.lblsummaryadditionalsamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Additionals";
            // 
            // lblsummaryrateamount
            // 
            this.lblsummaryrateamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsummaryrateamount.Location = new System.Drawing.Point(122, 52);
            this.lblsummaryrateamount.Name = "lblsummaryrateamount";
            this.lblsummaryrateamount.Size = new System.Drawing.Size(162, 20);
            this.lblsummaryrateamount.TabIndex = 1;
            this.lblsummaryrateamount.Text = "0.00";
            this.lblsummaryrateamount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Rate";
            // 
            // btnprintpayslip
            // 
            this.btnprintpayslip.Enabled = false;
            this.btnprintpayslip.Location = new System.Drawing.Point(1220, 10);
            this.btnprintpayslip.Name = "btnprintpayslip";
            this.btnprintpayslip.Size = new System.Drawing.Size(75, 23);
            this.btnprintpayslip.TabIndex = 23;
            this.btnprintpayslip.Text = "Print";
            this.btnprintpayslip.UseVisualStyleBackColor = true;
            this.btnprintpayslip.Click += new System.EventHandler(this.btnprintpayslip_Click);
            // 
            // printdocument
            // 
            // 
            // usercontrolPayslipDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnprintpayslip);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblemployeename);
            this.Controls.Add(this.label3);
            this.Name = "usercontrolPayslipDetail";
            this.Size = new System.Drawing.Size(1307, 681);
            this.Load += new System.EventHandler(this.usercontrolPayslipDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadditionaladjustments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadditionals)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeductionadjustments)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblemployeename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnaddadditional;
        private System.Windows.Forms.TextBox txtadditionalamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadditionalname;
        private System.Windows.Forms.Label lbladditional;
        public System.Windows.Forms.DataGridView dgvadditionals;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnadddeduction;
        private System.Windows.Forms.TextBox txtdeductionamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdeductioname;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvdeductionadjustments;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblundertimeamount;
        private System.Windows.Forms.Label lbllatesamount;
        private System.Windows.Forms.Label lblabsencesamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblsssamount;
        private System.Windows.Forms.Label lblphilhealthamount;
        private System.Windows.Forms.Label lblpagibigamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblsummarynetpayamount;
        private System.Windows.Forms.Label lblsummarydeductionsamount;
        private System.Windows.Forms.Label lblsummarygrossamount;
        private System.Windows.Forms.Label lblsummarylessamount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblsummaryadditionalsamount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblsummaryrateamount;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView dgvadditionaladjustments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblloanamount;
        private System.Windows.Forms.Button btnprintpayslip;
        private System.Drawing.Printing.PrintDocument printdocument;

    }
}
