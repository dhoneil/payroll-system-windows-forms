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
    public partial class usercontrolSeedFund : UserControl
    {
        public usercontrolSeedFund()
        {
            InitializeComponent();
        }

        private void usercontrolSeedFund_Load(object sender, EventArgs e)
        {
            cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbemployee.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvloan.DataSource = SeedFundDeduction.GenerateEmployeeLoan();

            var companylist = CompanyModel.GetList();
            if (companylist.Any())
            {
                cmbcompany.DataSource = null;
                cmbcompany.DataSource = companylist;
                cmbcompany.ValueMember = "id";
                cmbcompany.DisplayMember = "name";
                cmbcompany.SelectedValue = 0;
            }
        }

        private void cmbcompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbdepartment.DataSource = null;
            cmbemployee.DataSource = null;
            long company = Convert.ToInt64(cmbcompany.SelectedValue);
            if (company > 0)
            {
                var departmentlist = DepartmentModel.GetList(0, company);
                if (departmentlist.Any())
                {
                    cmbdepartment.DataSource = departmentlist;
                    cmbdepartment.ValueMember = "DepartmentID";
                    cmbdepartment.DisplayMember = "DepartmentName";
                    cmbdepartment.SelectedValue = 0;
                }
            }
        }

        private void cmbdepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long company = Convert.ToInt64(cmbcompany.SelectedValue);
            long department = Convert.ToInt64(cmbdepartment.SelectedValue);
            if (company > 0 && department > 0)
            {
                cmbemployee.DataSource = null;
                cmbemployee.DataSource = EmployeeModel.GetList(company, department, 0);
                cmbemployee.ValueMember = "id";
                cmbemployee.DisplayMember = "EmployeeName";
                cmbemployee.SelectedValue = 0;
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;
            long employee = Convert.ToInt64(cmbemployee.SelectedValue);
            DateTime datededucted = dtpdeductiondate.Value;
            decimal amount = 0m;
            if (employee == 0)
            {
                flag = false;
                MessageBox.Show("Please select Employee");
            }
            else if (String.IsNullOrEmpty(txtamount.Text.Trim()))
            {
                flag = false;
                MessageBox.Show("Please input amount");
            }

            if (flag)
            {
                try
                {
                    amount = Convert.ToDecimal(txtamount.Text);
                    tbl_loan data = new tbl_loan
                    {
                        emp_id = employee,
                        amount = amount,
                        effective_date = datededucted
                    };
                    data = SeedFundDeduction.Save(data);
                    if (data.id > 0)
                    {
                        dgvloan.DataSource = null;
                        dgvloan.DataSource = SeedFundDeduction.GenerateEmployeeLoan();
                        MessageBox.Show("Successfully Saved.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to Release Amount?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    long id = Convert.ToInt64(dgvloan.CurrentRow.Cells["ID"].Value);
                    bool flag = SeedFundDeduction.Release(id);
                    if (flag)
                    {
                        dgvloan.DataSource = null;
                        dgvloan.DataSource = SeedFundDeduction.GenerateEmployeeLoan();
                        MessageBox.Show("Successfully Released.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void voidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure to set this as Void?", "System Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    long id = Convert.ToInt64(dgvloan.CurrentRow.Cells["ID"].Value);
                    bool flag = SeedFundDeduction.Void(id);
                    if (flag)
                    {
                        dgvloan.DataSource = null;
                        dgvloan.DataSource = SeedFundDeduction.GenerateEmployeeLoan();
                        MessageBox.Show("Successfully Released.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvloan_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvloan.Rows[e.RowIndex].Selected = true;
                this.dgvloan.CurrentCell = this.dgvloan.Rows[e.RowIndex].Cells[1];
                this.contextmenustripoptions.Show(this.dgvloan, e.Location);
                contextmenustripoptions.Show(Cursor.Position);
            }
        }

    }
}
