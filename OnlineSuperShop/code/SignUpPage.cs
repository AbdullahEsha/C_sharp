using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Cream_shop_management
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCPassword.Text != txtPassword.Text)
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == string.Empty || txtPassword.Text == string.Empty || txtCPassword.Text == string.Empty || txtPhoneNumber.Text == string.Empty||( rbtnMale.Checked == false && rbtnFemale.Checked == false))
            {
                MessageBox.Show("Requirement must be fillup");
            }
            else
            {
                SignUpService signUpService = new SignUpService();
                
                string uname = txtUName.Text;
                string password = txtPassword.Text;
                string gender = "";
                if (rbtnMale.Checked)
                    gender = "Male";
                if (rbtnFemale.Checked)
                    gender = "Female";

                int phoneNum = Convert.ToInt32(txtPhoneNumber.Text);
                int result = signUpService.CheckDuplicate(phoneNum);
                if(result == 0)
                {
                    int result1 = signUpService.UserRegistration(uname, password, phoneNum, gender, "customer");
                    if (result1 > 0)
                    {
                        MessageBox.Show("Sign up complete!!");
                        Login fl1 = new Login();
                        this.Hide();
                        fl1.Show();
                    }
                    else MessageBox.Show("Error!!");
                }
                else
                {
                    MessageBox.Show("Already exists, please try with another Phone Number");
                }
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();
        }
    }
}
