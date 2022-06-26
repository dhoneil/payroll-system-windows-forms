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
    public partial class usercontrolSchedule : UserControl
    {
        public usercontrolSchedule()
        {
            InitializeComponent();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            string name = txtschedname.Text.Trim();
            DateTime timein = dtptimein.Value;
            DateTime timeout = dtptimeout.Value;
            if (String.IsNullOrEmpty(name))
            {
                txtschedname.Focus();
                MessageBox.Show("Schedule Title is required.");
            }
            else
            {
                try
                {
                    tbl_schedule data = new tbl_schedule { name = name, time_in = timein, time_out = timeout };
                    data = ScheduleModel.Save(data);
                    if (data.id > 0)
                    {
                        txtschedname.Text = string.Empty;
                        GetList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void usercontrolSchedule_Load(object sender, EventArgs e)
        {
            DateTime timedefaultvalue = new DateTime(2019, 03, 1, 0, 0, 0);

            dtptimein.Format = DateTimePickerFormat.Custom;
            dtptimein.CustomFormat = "HH:mm";

            dtptimeout.Format = DateTimePickerFormat.Custom;
            dtptimeout.CustomFormat = "HH:mm";

            dtptimegrace.Format = DateTimePickerFormat.Custom;
            dtptimegrace.CustomFormat = "HH:mm";

            dtptimein.Value = timedefaultvalue;
            dtptimeout.Value = timedefaultvalue;
            dtptimegrace.Value = timedefaultvalue;

            GetList();
        }

        void GetList()
        {
            var list = ScheduleModel.Get();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Schedule Title");
            dt.Columns.Add("Time In");
            dt.Columns.Add("Time Out");
            dt.Columns.Add("Grace Time");
            if (list.Any())
            {
                foreach (var i in list)
                {
                    DataRow row = dt.NewRow();
                    row["ID"] = i.id;
                    row["Schedule Title"] = i.name.ToUpper();
                    row["Time In"] = i.time_in.Value.ToString("HH:mm");
                    row["Time Out"] = i.time_out.Value.ToString("HH:mm");
                    row["Grace Time"] = i.grace_time.HasValue ? i.grace_time.Value.ToString("HH:mm") : "";

                    dt.Rows.Add(row);
                }
            }

            dgvschedule.DataSource = null;
            dgvschedule.DataSource = dt;
        }

    }
}
