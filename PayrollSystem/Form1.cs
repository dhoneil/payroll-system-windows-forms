using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem.UserControls;

namespace PayrollSystem
{
    //public partial class Form1 : Form
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SettingWinForm.CurrentForm = this;
            Form1 mainform = new Form1();
            usercontrolLogIn uc = new usercontrolLogIn();
            //usercontrolMain uc = new usercontrolMain();

            uc.Dock = DockStyle.Top;
            uc.Location = new Point(0, 5);

            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(uc.Width, uc.Height);
            this.Controls.Add(uc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult diagresult = MessageBox.Show("Are you sure to terminate the program?", "System Confirmation", MessageBoxButtons.YesNo);
                if (diagresult == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
            }
            else { }
        }
    }
}
