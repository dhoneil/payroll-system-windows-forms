using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.UserControls
{
    public partial class usercontrolForgotPassword : UserControl
    {
        public usercontrolForgotPassword()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string question = cmbquestion.Text.ToUpper();
            string answer = txtanswer.Text.ToUpper();
            string confirmanswer = txtconfirmanswer.Text.ToUpper();


        }
    }
}
