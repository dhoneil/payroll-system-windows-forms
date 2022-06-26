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
using PayrollSystem.WinFormClass;

namespace PayrollSystem.UserControls
{
    public partial class usercontrolCompanyDepartmentJob : UserControl
    {
        public usercontrolCompanyDepartmentJob()
        {
            InitializeComponent();
        }

        private void btnaddnewcompany_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolCompany ucedit = new usercontrolCompany();
            ucedit.btnupdatecompany.Hide();
            ucedit.btnaddcompany.Show();
            ucedit.Location = new Point(0, 0);
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


        private void usercontrolCompanyDepartmentJob_Load(object sender, EventArgs e)
        {
            dgvcompany.DataSource = CompanyModel.GetList();
            dgvdepartment.DataSource = DepartmentModel.GetList();
            dgvjob.DataSource = JobModel.GetList();
        }

        private void txtsearchcompany_KeyUp(object sender, KeyEventArgs e)
        {
            string searchkey = txtsearchcompany.Text.Trim();
            dgvcompany.DataSource = CompanyModel.Search(searchkey);
        }

        private void btnaddnewdepartment_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolDepartment ucedit = new usercontrolDepartment();
            ucedit.btnaddcompany.Show();
            ucedit.btnupdatedepartment.Hide();
            ucedit.Location = new Point(0, 0);
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

        private void txtsearchdepartment_KeyUp(object sender, KeyEventArgs e)
        {
            string searchkey = txtsearchdepartment.Text.Trim();
            dgvdepartment.DataSource = DepartmentModel.Search(searchkey);
        }

        private void btnaddnewjob_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolJob ucedit = new usercontrolJob();
            ucedit.btnaddcompany.Show();
            ucedit.btnupdate.Hide();
            ucedit.Location = new Point(0, 0);
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

        private void txtsearchjob_KeyUp(object sender, KeyEventArgs e)
        {
            string searchkey = txtsearchjob.Text.Trim();
            dgvjob.DataSource = JobModel.Search(searchkey);
        }

        private void dgvcompany_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvcompany.Rows[e.RowIndex].Selected = true;
                this.dgvcompany.CurrentCell = this.dgvcompany.Rows[e.RowIndex].Cells[1];
                this.contextMenuStripcompany.Show(this.dgvcompany, e.Location);
                contextMenuStripcompany.Show(Cursor.Position);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolCompany ucedit = new usercontrolCompany();
            ucedit.btnupdatecompany.Show();
            ucedit.btnaddcompany.Hide();
            ucedit.Location = new Point(0, 0);
            frm.Controls.Add(ucedit);
            frm.ClientSize = new Size(ucedit.Width, ucedit.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MinimumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            SettingWinForm.DynamicForm = frm;

            SettingWinForm.CurrentForm = frm;

            long empID = Convert.ToInt64(dgvcompany.CurrentRow.Cells["ID"].Value.ToString());
            string empname = dgvcompany.CurrentRow.Cells["name"].Value.ToString();
            string empaddress = dgvcompany.CurrentRow.Cells["address"].Value.ToString();

            ucedit.txthiddencompanyID.Text = Convert.ToString(empID);
            ucedit.txtcompanyname.Text = empname;
            ucedit.txtaddress.Text = empaddress;

            GlobalVariable.SelectedEmployee = empID;
            GlobalControls.SelectedDataGridView = null;
            GlobalControls.SelectedDataGridView = dgvcompany;
            frm.ShowDialog();
        }

        private void dgvdepartment_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvdepartment.Rows[e.RowIndex].Selected = true;
                this.dgvdepartment.CurrentCell = this.dgvdepartment.Rows[e.RowIndex].Cells[1];
                this.contextMenuStripDepartment.Show(this.dgvdepartment, e.Location);
                contextMenuStripDepartment.Show(Cursor.Position);
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolDepartment ucedit = new usercontrolDepartment();
            ucedit.btnupdatedepartment.Show();
            ucedit.btnaddcompany.Hide();
            ucedit.Location = new Point(0, 0);
            frm.Controls.Add(ucedit);
            frm.ClientSize = new Size(ucedit.Width, ucedit.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MinimumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            SettingWinForm.DynamicForm = frm;

            SettingWinForm.CurrentForm = frm;

            long depID = Convert.ToInt64(dgvdepartment.CurrentRow.Cells["DepartmentID"].Value.ToString());
            long companyID = Convert.ToInt64(dgvdepartment.CurrentRow.Cells["CompanyID"].Value.ToString());
            string departmentname = dgvdepartment.CurrentRow.Cells["DepartmentName"].Value.ToString();

            ucedit.cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            List<tbl_company> res = CompanyModel.GetList();
            ucedit.cmbcompany.DataSource = res;
            ucedit.cmbcompany.DisplayMember = "name";
            ucedit.cmbcompany.ValueMember = "id";
            ucedit.cmbcompany.SelectedValue = companyID;

            ucedit.txthiddenDepartmentID.Text = Convert.ToString(depID);
            ucedit.txtdepartmentname.Text = departmentname;
            
            

            GlobalVariable.SelectedEmployee = depID;
            GlobalControls.SelectedDataGridView = null;
            GlobalControls.SelectedDataGridView = dgvdepartment;
            frm.ShowDialog();
        }
        private void dgvjob_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvjob.Rows[e.RowIndex].Selected = true;
                this.dgvjob.CurrentCell = this.dgvjob.Rows[e.RowIndex].Cells[1];
                this.contextMenuStripJob.Show(this.dgvjob, e.Location);
                contextMenuStripJob.Show(Cursor.Position);
            }
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolJob ucedit = new usercontrolJob();
            ucedit.btnupdate.Show();
            ucedit.btnaddcompany.Hide();
            ucedit.Location = new Point(0, 0);
            frm.Controls.Add(ucedit);
            frm.ClientSize = new Size(ucedit.Width, ucedit.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MinimumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            SettingWinForm.DynamicForm = frm;

            SettingWinForm.CurrentForm = frm;

            long jobID = Convert.ToInt64(dgvjob.CurrentRow.Cells["JobID"].Value.ToString());
            var employeedata = JobModel.GetbyID(jobID);
            long? compID = employeedata.company;
            long? depID = employeedata.department;
            string empName = employeedata.name;

            ucedit.cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            List<tbl_company> res = CompanyModel.GetList();
            ucedit.cmbcompany.DataSource = res;
            ucedit.cmbcompany.DisplayMember = "name";
            ucedit.cmbcompany.ValueMember = "id";
            ucedit.cmbcompany.SelectedValue = compID;

            ucedit.cmbdepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            List<tbl_department> ress = DepartmentModel.GetListv2();
            ucedit.cmbdepartment.DataSource = ress;
            ucedit.cmbdepartment.DisplayMember = "name";
            ucedit.cmbdepartment.ValueMember = "id";
            ucedit.cmbdepartment.SelectedValue = depID;

            ucedit.txthiddenJobID.Text = Convert.ToString(jobID);
            ucedit.txtjobname.Text = employeedata.name;


            GlobalVariable.SelectedEmployee = jobID;
            GlobalControls.SelectedDataGridView = null;
            GlobalControls.SelectedDataGridView = dgvjob;
            frm.ShowDialog();
        }

        private void contextMenuStripcompany_Opening(object sender, CancelEventArgs e)
        {

        }

        

        
    }
}
