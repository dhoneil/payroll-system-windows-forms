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

namespace PayrollSystem.UserControls
{
    public partial class usercontrolAttendance : UserControl
    {
        public usercontrolAttendance()
        {
            InitializeComponent();
        }

        private void usercontrolAttendance_Load(object sender, EventArgs e)
        {
            tmrDateTime.Tick += tmrDateTime_Tick;
            tmrDateTime.Start();
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("MMMM dd,yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
