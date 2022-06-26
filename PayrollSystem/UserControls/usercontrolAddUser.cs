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
using PayrollSystem.Model.dbEntity;

namespace PayrollSystem.UserControls
{
    public partial class usercontrolAddUser : UserControl
    {
        public usercontrolAddUser()
        {
            InitializeComponent();
        }

        private void usercontrolAddUser_Load(object sender, EventArgs e)
        {
            this.cmbemployee.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbusertype.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvuserlist.DataSource = AccountModel.GetList();
            var employeenouseraccount = AccountModel.EmployeeNoAccountList();
            if (employeenouseraccount.Any())
            {
                cmbemployee.DataSource = employeenouseraccount;
                cmbemployee.ValueMember = "id";
                cmbemployee.DisplayMember = "EmployeeName";
                cmbemployee.SelectedValue = 0;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string usertype = cmbusertype.Text.Trim();
                string username = txtusername.Text.Trim();
                string password = txtpassword.Text.Trim();
                string confirmpassword = txtconfirmpassword.Text.Trim();


                //string question = cmbquestion.Text.Trim();
                //string answer = txtanswer.Text.Trim();
                //string confirmanswer = txtconfirmanswer.Text.Trim();

                long company = (long)cmbemployee.SelectedValue;

                bool flag = true;
                if (String.IsNullOrEmpty(usertype)) flag = false;
                if (String.IsNullOrEmpty(username)) flag = false;
                if (String.IsNullOrEmpty(password)) flag = false;
                //if (String.IsNullOrEmpty(question)) flag = false;
                //if (String.IsNullOrEmpty(answer)) flag = false;
                //if (String.IsNullOrEmpty(confirmanswer)) flag = false;

                if (password!=confirmpassword)
                {
                    MessageBox.Show("Passwords don't match.");
                    flag = false;
                }
                else
                {

                }

                if (company == 0) flag = false;

                if (flag)
                {
                    long empid = (long)cmbemployee.SelectedValue;
                    tbl_employee_account data = new tbl_employee_account
                    {
                        emp_id = empid,
                        username = username,
                        usertype = usertype,
                        password = DataSecurity.EncryptText(username, confirmpassword)
                        //question = question.ToUpper(),
                        //answer = confirmanswer.ToUpper()
                    };

                    flag = AccountModel.UsernameExist(username);
                    if (flag)
                    {
                        txtpassword.Text = string.Empty;
                        MessageBox.Show("Username already taken.");
                    }
                    else
                    {

                        var res = AccountModel.Save(data);
                        if (res.id > 0)
                        {
                            cmbemployee.DataSource = AccountModel.EmployeeNoAccountList();
                            cmbemployee.Text = string.Empty;
                            cmbusertype.Text = string.Empty;
                            txtusername.Text = string.Empty;
                            txtpassword.Text = string.Empty;
                            cmbquestion.Text = string.Empty;
                            txtanswer.Text = string.Empty;
                            txtconfirmanswer.Text = string.Empty;
                            txtconfirmpassword.Text = string.Empty;
                            dgvuserlist.DataSource = AccountModel.GetList();
                            MessageBox.Show("User successfully added.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void dgvuserlist_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvuserlist.Rows[e.RowIndex].Selected = true;
                this.dgvuserlist.CurrentCell = this.dgvuserlist.Rows[e.RowIndex].Cells[1];
                //this.contextMenuStripJob.Show(this.dgvjob, e.Location);
                this.CMS_resetPassword.Show(this.dgvuserlist, e.Location);
                CMS_resetPassword.Show(Cursor.Position);
            }
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string usertype = SessionModel.UserType;

            if (usertype == "Staff") {
                MessageBox.Show("Only Admins and Super Admins are allowed to proceed.");
                flag = false;
            }
            else
            {
                DialogResult diagresult = MessageBox.Show("Are you sure to reset this user's password?", "System Confirmation", MessageBoxButtons.YesNo);
                if (diagresult == DialogResult.Yes)
                {
                    long accountid = Convert.ToInt64(dgvuserlist.CurrentRow.Cells["id"].Value.ToString());
                    string username = dgvuserlist.CurrentRow.Cells["username"].Value.ToString();

                    string newpassword =  DataSecurity.EncryptText(username,"1234");

                    dbPayrollEntities db = new dbPayrollEntities();
                    tbl_employee_account src = db.tbl_employee_account.Single(s=>s.id == accountid);
                    src.password = newpassword;
                    db.SaveChanges();

                    MessageBox.Show("Password successfully changed to default.");
                }
            }
        }
    }
}
