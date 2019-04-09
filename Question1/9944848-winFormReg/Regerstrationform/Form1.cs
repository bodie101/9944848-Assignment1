using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regerstrationform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnreg_Click(object sender, EventArgs e)
        {
            int UserName = GenerateUName.UserName();

            string Passconfirm = Validatepass.Passconfirm(pass1.Text, pass2.Text);


            lbluserName.Text = GenerateUName.Student(fname.Text, lname.Text, email.Text, UserName);


        }

        private void pass2_TextChanged(object sender, EventArgs e)
        {
            if (pass2.Text == pass1.Text)
            {
                label6.ForeColor = Color.Green;
                label6.Text = "The password was successful";
            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Passwords did not match";
            }
        }
    }
}



          
       

       


