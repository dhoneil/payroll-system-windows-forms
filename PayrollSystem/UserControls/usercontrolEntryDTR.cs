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
    public partial class usercontrolEntryDTR : UserControl
    {
        public usercontrolEntryDTR()
        {
            InitializeComponent();
        }

        private void usercontrolEntryDTR_Load(object sender, EventArgs e)
        {
            lbldateentry.Text = GlobalVariable.SelectedDate.ToShortDateString();
            DateTime timeindefaultvalue = new DateTime(2019, 03, 1, 0, 0, 0);
            DateTime timeoutdefaultvalue = new DateTime(2019, 03, 1, 0, 0, 0);
            var dtrentryrecords = DTRModel.GetEmployeeDTR(GlobalVariable.SelectedEmployee, GlobalVariable.SelectedDate);
            if (dtrentryrecords.Any())
            {
                foreach (var i in dtrentryrecords)
                {
                    if (i.check_in.HasValue) timeindefaultvalue = i.check_in.Value;
                    if (i.check_out.HasValue) timeoutdefaultvalue = i.check_out.Value;
                }
            }
            dtptimein.Format = DateTimePickerFormat.Custom;
            dtptimein.CustomFormat = "HH:mm";
            dtptimeout.Format = DateTimePickerFormat.Custom;
            dtptimeout.CustomFormat = "HH:mm";
            dtptimein.Value = timeindefaultvalue;
            dtptimeout.Value = timeoutdefaultvalue;

            this.cmbmode.DropDownStyle = ComboBoxStyle.DropDownList;
            Dictionary<string, string> modeSource = new Dictionary<string, string>();
            modeSource.Add("IN/OUT", "Time In & Time Out");
            modeSource.Add("IN", "Time In");
            modeSource.Add("OUT", "Time Out");
            cmbmode.DataSource = modeSource.ToList();
            cmbmode.DisplayMember = "Value";
            cmbmode.ValueMember = "Key";
        }

        private void cmbmode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = cmbmode.SelectedValue.ToString().ToUpper();
            switch (value)
            {
                case "IN/OUT": dtptimein.Enabled = true; dtptimeout.Enabled = true; break;
                case "IN": dtptimein.Enabled = true; dtptimeout.Enabled = false; break;
                case "OUT": dtptimein.Enabled = false; dtptimeout.Enabled = true; break;
            }
        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string mode = cmbmode.SelectedValue.ToString().ToUpper();
            DateTime? dtrtimein = new DateTime();
            DateTime? dtrtimeout = new DateTime();
            DateTime? timein = null;
            DateTime? timeout = null;
            if (String.IsNullOrEmpty(mode))
            {
                cmbmode.Focus();
                MessageBox.Show("Please select Mode");
            }
            else
            {
                switch (mode)
                {
                    case "IN/OUT": dtrtimein = dtptimein.Value; dtrtimeout = dtptimeout.Value; break;
                    case "IN": dtrtimein = dtptimein.Value; dtrtimeout = null; break;
                    case "OUT": dtrtimein = null; dtrtimeout = dtptimeout.Value; break;
                }

                try
                {
                    long empID = GlobalVariable.SelectedEmployee;
                    DateTime date = GlobalVariable.SelectedDate;
                    var employee = EmployeeModel.GetEmployeeById(empID);
                    var entrylist = DTRModel.GetEmployeeDTR(empID, date);
                    if (entrylist.Any())
                    {
                        tbl_dtr data = new tbl_dtr { emp_id = empID, date = date, check_in = dtrtimein, check_out = dtrtimeout };
                        DTRModel.UpdateEntry(data);
                    }
                    else
                    {
                        tbl_dtr dtrrecord = new tbl_dtr { emp_id = empID, date = date, check_in = dtrtimein, check_out = dtrtimeout, year = date.Year.ToString() };
                        DTRModel.Save(dtrrecord);
                    }

                    tbl_dtr dtrentryrecords = DTRModel.GetEntry(empID, date);
                    var schedule = ScheduleModel.GetById(employee.schedule.Value);
                    bool isholiday = HolidayModel.IsHoliday(date);

                    /**SET DEFAULT SUNDAY AS RD**/
                    bool isRD = date.DayOfWeek.ToString().ToUpper() == "SUNDAY" ? true : false;

                    DateTime schedtimein = schedule.time_in.Value;
                    DateTime schedtimeout = schedule.time_out.Value;

                    double lates = 0;
                    double overtime = 0;
                    double undertime = 0;
                    double totaldutyhours = 0;
                    double holidayhours = 0;

                    if (dtrentryrecords.check_in.HasValue) timein = dtrentryrecords.check_in.Value;
                    if (dtrentryrecords.check_out.HasValue) timeout = dtrentryrecords.check_out.Value;

                    if (timein.HasValue == false || timeout.HasValue == false) flag = false;
                    else
                    {
                        //TimeSpan _totaldytyhours = (timeout.Value.Subtract(timein.Value));
                        //totaldutyhours = _totaldytyhours.TotalHours;
                        totaldutyhours = timeout.Value.Subtract(timein.Value).TotalHours;

                        if (timein.Value.TimeOfDay > schedtimein.TimeOfDay) lates = timein.Value.TimeOfDay.Subtract(schedtimein.TimeOfDay).TotalMinutes;
                        if (timeout.Value.TimeOfDay > schedtimeout.AddHours(1).TimeOfDay) overtime = timeout.Value.TimeOfDay.Subtract(schedtimeout.AddHours(1).TimeOfDay).TotalHours;
                        if (timeout.Value.TimeOfDay < schedtimeout.TimeOfDay) undertime = schedtimeout.TimeOfDay.Subtract(timeout.Value.TimeOfDay).TotalMinutes;
                        if (isholiday) holidayhours = timeout.Value.AddHours(-1).TimeOfDay.Subtract(schedtimein.TimeOfDay).TotalHours;

                        tbl_dtr dtrrecordupdate = new tbl_dtr
                        {
                            emp_id = empID,
                            date = date,
                            year = date.Year.ToString(),
                            total_duty_hours = Convert.ToDecimal(totaldutyhours),
                            lates = Convert.ToDecimal(lates),
                            undertime = Convert.ToDecimal(undertime),
                            total_overtime = Convert.ToDecimal(overtime),
                            holiday_work_hours = Convert.ToDecimal(holidayhours),
                            isHoliday = isholiday,
                            isRD = isRD
                        };

                        flag = DTRModel.UpdateEntry(dtrrecordupdate);

                        if (flag)
                        {
                            GlobalControls.SelectedDataGridView.DataSource = null;
                            GlobalControls.SelectedDataGridView.DataSource = DTRModel.GenerateDTR(GlobalVariable.SelectedDateFrom, GlobalVariable.SelectedDateTo, GlobalVariable.SelectedEmployee);
                            Form frm = SettingWinForm.DynamicForm;
                            frm.Close();
                            MessageBox.Show("Posted entry successfully saved.");
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
