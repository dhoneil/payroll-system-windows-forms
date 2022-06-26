using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem.Model;
using PayrollSystem.UserControls;
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem
{
    public partial class usercontrolLogIn : UserControl
    {
        public usercontrolLogIn()
        {
            InitializeComponent();
        }

        private void usercontrolLogIn_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string USERNAME = txtUsername.Text.Trim();
            string PASSWORD = txtPassword.Text.Trim();

            bool flag = true;
            if (String.IsNullOrEmpty(USERNAME)) flag = false;
            if (String.IsNullOrEmpty(PASSWORD)) flag = false;

            try
            {
                if (flag)
                {
                    AccountModel account = new AccountModel();
                    tbl_employee_account data = account.LogInUser(USERNAME, PASSWORD);
                    if (data!=null)
                    {
                        //this area is to get the information details of the current user start..
                        SessionModel.UserID = data.id;
                        SessionModel.UserType = data.usertype;

                        dbPayrollEntities db = new dbPayrollEntities();
                        View_Employee src = db.View_Employee.Single(s => s.id == data.emp_id);
                        SessionModel.userFirstname = src.firstname;
                        SessionModel.userLastname = src.lastname;
                        SessionModel.userCompany = src.Company_Name;
                        SessionModel.userDepartment = src.Department_Name;
                        //this area is to get the information details of the current user end..

                        var form = SettingWinForm.CurrentForm;
                        usercontrolMain mainview = new usercontrolMain();
                        mainview.Location = new Point(0, 5);

                        form.Size = new Size(mainview.Width, mainview.Height);
                        form.Controls.Clear();
                        form.Controls.Add(mainview);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password must not be empty");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linklblNewRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolForgotPassword ucedit = new usercontrolForgotPassword();
            ucedit.Location = new Point(0, 5);
            frm.Controls.Add(ucedit);
            frm.ClientSize = new Size(ucedit.Width, ucedit.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MinimumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            SettingWinForm.CurrentForm = frm;

            frm.ShowDialog();
        }
    }
}
