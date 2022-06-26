using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystem.Model.dbEntity;
using PayrollSystem.Model;

namespace PayrollSystem.UserControls
{
    public partial class usercontrolHoliday : UserControl
    {
        public usercontrolHoliday()
        {
            InitializeComponent();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            string holidayname = txtholidayname.Text.Trim();
            string type = cmbtype.Text;
            DateTime date = dtpholidaydate.Value;
            bool flag =true;
            if (String.IsNullOrEmpty(holidayname)) flag = false;
            if (flag)
            {
                try
                {
                    tbl_holiday data = new tbl_holiday { holiday_name = holidayname, date = date, type = type };
                    var res = HolidayModel.Save(data);
                    if (res.id > 0)
                    {
                        GetList();
                        txtholidayname.Text = string.Empty;
                        MessageBox.Show("Holiday successfully added.");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else {
                MessageBox.Show("Holiday Name is required.");
                txtholidayname.Focus();
            }
        }

        private void usercontrolHoliday_Load(object sender, EventArgs e)
        {
            cmbtype.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> typeSource = new List<string> { "SPECIAL", "REGULAR" };
            cmbtype.DataSource = typeSource;
            GetList();
        }

        void GetList() {
            var holidaylist = HolidayModel.Get();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Type");
            dt.Columns.Add("Holiday Name");
            dt.Columns.Add("Date");
            if (holidaylist.Any())
            {
                foreach (var i in holidaylist)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = i.id;
                    row["Type"] = i.type.ToUpper();
                    row["Holiday Name"] = i.holiday_name.ToUpper();
                    row["Date"] = i.date.Value.ToShortDateString();

                    dt.Rows.Add(row);
                }
            }
            dgvholiday.DataSource = null;
            dgvholiday.DataSource = dt;
        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
