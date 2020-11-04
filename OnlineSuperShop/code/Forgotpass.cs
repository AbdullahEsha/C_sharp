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
    public partial class Forgotpass : Form
    {
        public Forgotpass()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             LoginService ls = new LoginService();
            try
            {
                if (txtPhone.Text == string.Empty || txtRPass.Text == string.Empty || txtCPass.Text == string.Empty)
                {
                    MessageBox.Show("Requirement must be fillup");
                }
                else
                {

                    int phone = Convert.ToInt32(txtPhone.Text);
                    string rpass = txtRPass.Text;

                    int result = ls.UserUpdate(rpass, phone);
                    if (result > 0)
                    {
                        MessageBox.Show("Resetting password is complete!!");
                        Login fl1 = new Login();
                        this.Hide();
                        fl1.Show();
                    }
                    else MessageBox.Show("Error!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void confirmpasstext_TextChanged(object sender, EventArgs e)
        {
            if (txtCPass.Text != txtRPass.Text)
            {
                lblerror.Visible = true;
                return;
            }
            else
            {
                lblerror.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login m = new Login();
            this.Hide();
            m.Show();
        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        private void txtRPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
