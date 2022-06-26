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
    public partial class usercontrolDTR : UserControl
    {
        public usercontrolDTR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usercontrolDTR_Load(object sender, EventArgs e)
        {
            var employee = EmployeeModel.GetEmployeeById(GlobalVariable.SelectedEmployee);
            lblempname.Text = employee.firstname.ToUpper() + " " + employee.lastname.ToUpper();
            DateTime date_from = GlobalVariable.SelectedDateFrom;
            DateTime date_to = GlobalVariable.SelectedDateTo;
            GenerateDTR(date_from, date_to, employee.id);
            dgvDTR.RowPrePaint += dgvDTR_RowPrePaint;
        }

        void dgvDTR_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvDTR.Rows[e.RowIndex].Cells["Day"].Value.ToString().ToUpper().Trim() == "SUN")
                dgvDTR.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            if (dgvDTR.Rows[e.RowIndex].Cells["Remarks"].Value.ToString().ToUpper().Trim() == "A")
            {
                dgvDTR.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Maroon;
                dgvDTR.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        public void GenerateDTR(DateTime datestart, DateTime dateend, long empid)
        {
            
            dgvDTR.DataSource = null;
            dgvDTR.DataSource = DTRModel.GenerateDTR(datestart, dateend, empid);
        }

        private void dgvDTR_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvDTR.Rows[e.RowIndex].Selected = true;
                this.dgvDTR.CurrentCell = this.dgvDTR.Rows[e.RowIndex].Cells[1];
                this.contextmenustripdtrentry.Show(this.dgvDTR, e.Location);
                contextmenustripdtrentry.Show(Cursor.Position);
            }
        }

        private void viewDTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariable.SelectedDate = Convert.ToDateTime(dgvDTR.CurrentRow.Cells["Date"].Value);
                Form frm = new Form();
                usercontrolEntryDTR uc = new usercontrolEntryDTR();

                uc.Location = new Point(0, 0);
                frm.Controls.Add(uc);
                frm.ClientSize = new Size(uc.Width, uc.Height);
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.StartPosition = FormStartPosition.CenterScreen;
                SettingWinForm.DynamicForm = frm;
                GlobalControls.SelectedDataGridView = this.dgvDTR;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
