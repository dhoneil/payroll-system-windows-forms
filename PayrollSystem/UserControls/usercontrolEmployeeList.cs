using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem.Model;
using PayrollSystem.Model.dbEntity;
using System.Windows.Forms.Design;

namespace PayrollSystem.UserControls
{
    
    public partial class usercontrolEmployeeList : UserControl
    {
        public usercontrolEmployeeList()
        {
            InitializeComponent();
        }
        dbPayrollEntities db = new dbPayrollEntities();

        private void usercontrolEmployeeList_Load(object sender, EventArgs e)
        {
            var res = EmployeeModel.GenerateEmployee();
            dgvemployee.DataSource = null;
            dgvemployee.DataSource = res;
        }

        private void txtsearchemployee_TextChanged(object sender, EventArgs e)
        {
            var result =  EmployeeModel.GenerateEmployee(txtsearchemployee.Text.Trim());

            dgvemployee.DataSource = result;
        }

        private void btnregisteremployee_Click(object sender, EventArgs e)
        {
            GlobalControls.SelectedDataGridView = null;
            GlobalControls.SelectedDataGridView = dgvemployee;
            GlobalVariable.SelectedEmployee = 0;
            Form frm = new Form();
            usercontrolRegistration ucreg = new usercontrolRegistration();
            int ucWith = ucreg.Width, ucHeight = ucreg.Height;
            ucreg.Location = new Point(0, 0);
            frm.Controls.Add(ucreg);
            frm.ClientSize = new Size(ucWith, ucHeight);
            frm.MaximumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MinimumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            SettingWinForm.DynamicForm = frm;
            frm.ShowDialog();
        }

        private void dgvemployee_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                this.dgvemployee.Rows[e.RowIndex].Selected = true;
                this.dgvemployee.CurrentCell = this.dgvemployee.Rows[e.RowIndex].Cells[1];
                this.cntxtmenustripemployee.Show(this.dgvemployee, e.Location);
                cntxtmenustripemployee.Show(Cursor.Position);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            usercontrolRegistration ucedit = new usercontrolRegistration();
            ucedit.Location = new Point(0, 0);
            frm.Controls.Add(ucedit);
            frm.ClientSize = new Size(ucedit.Width, ucedit.Height);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MaximumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MinimumSize = new System.Drawing.Size(frm.Width, frm.Height);
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            SettingWinForm.DynamicForm = frm;

            long empID = Convert.ToInt64(dgvemployee.CurrentRow.Cells["ID"].Value.ToString());

            var data = EmployeeModel.GetEmployeeById(empID);

            ucedit.txthiddenEmployeeID.Text = Convert.ToString(empID);
            ucedit.txtfirstname.Text = data.firstname;
            ucedit.txtlastname.Text = data.middlename;
            ucedit.cmbcivilstatus.SelectedValue = data.civil_status;
            ucedit.cmbgender.SelectedValue = data.gender;


            ucedit.cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            List<tbl_company> res = CompanyModel.GetList();
            ucedit.cmbcompany.DataSource = res;
            ucedit.cmbcompany.DisplayMember = "name";
            ucedit.cmbcompany.ValueMember = "id";
            ucedit.cmbcompany.SelectedValue = data.company;

            

            GlobalVariable.SelectedEmployee = empID;

            GlobalControls.SelectedDataGridView = null;
            GlobalControls.SelectedDataGridView = dgvemployee;
            frm.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objmap = new Bitmap(this.dgvemployee.Width, this.dgvemployee.Height);
            dgvemployee.DrawToBitmap(objmap, new Rectangle(0, 0, this.dgvemployee.Width,this.dgvemployee.Height));


            e.Graphics.DrawImage(objmap, 250, 120);

            e.Graphics.DrawString(lblheader.Text, new Font("Verdana", 22, FontStyle.Bold),Brushes.Black,new Point(120,30));

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

    }
}

