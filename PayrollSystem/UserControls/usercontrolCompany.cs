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
    public partial class usercontrolCompany : UserControl
    {
        public usercontrolCompany()
        {
            InitializeComponent();
        }

        private void usercontrolCompany_Load(object sender, EventArgs e)
        {
            //List<tbl_company> res = CompanyModel.GetList();
            //if (res.Any())
            //{
            //    dgvcompanylist.DataSource = res;
            //}
        }

        private void btnaddcompany_Click_1(object sender, EventArgs e)
        {
            string name = txtcompanyname.Text.Trim();
            string address = txtaddress.Text.Trim();

            bool flag = true;
            if (String.IsNullOrEmpty(name)) flag = false;
            if (string.IsNullOrEmpty(address)) flag = false;

            if (flag)
            {
                try
                {
                    tbl_company c = new tbl_company { name = name, address = address };
                    c = CompanyModel.Save(c);
                    long id = c.id;
                    if (id > 0)
                    {
                        MessageBox.Show("Company Added");
                        //dgvcompanylist.DataSource = CompanyModel.GetList();
                        txtcompanyname.Text = string.Empty;
                        txtaddress.Text = string.Empty;
                    }

                    SettingWinForm.CurrentForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("All fields are required.");
            }
        }

        private void btnupdatecompany_Click_1(object sender, EventArgs e)
        {
            string id = txthiddencompanyID.Text.Trim();
            string name = txtcompanyname.Text.Trim();
            string address = txtaddress.Text.Trim();

            bool flag = true;
            if (String.IsNullOrEmpty(name)) flag = false;
            if (string.IsNullOrEmpty(address)) flag = false;

            if (flag)
            {
                try
                {
                    tbl_company src = new tbl_company();
                    src.id = Convert.ToInt64(id);
                    src.name = name;
                    src.address = address;
                    var srcc = CompanyModel.Update(src);
                    long idd = srcc.id;
                    if (idd>0)
                    {
                        MessageBox.Show("Company Successfully Updated");
                        txthiddencompanyID.Text = string.Empty;
                        txtcompanyname.Text = string.Empty;
                        txtaddress.Text = string.Empty;
                    }
                    SettingWinForm.CurrentForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("All fields are required.");
            }
        }
    }
}
