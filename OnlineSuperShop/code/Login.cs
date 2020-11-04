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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();

           try
           {
                if (Phonetext.Text == string.Empty || passtext.Text == string.Empty)
                {
                    MessageBox.Show("Username or Password can not be empty.");
                }

                else
                {
                    User ur = new User();
                    ur.Phone = Convert.ToInt32(Phonetext.Text);
                    ur.Password = passtext.Text;
                    User result = loginService.LoginValidation(ur);
                    if (result.UserType != null)
                    {
                        if (result.UserType == "customer")
                        {
                            CustomerPage cp = new CustomerPage(result);
                            this.Hide();
                            cp.Show();
                        }
                        else if (result.UserType == "salesman")
                        {
                            SalesmanPage sp = new SalesmanPage(result);
                            this.Hide();
                            sp.Show();
                        }
                        else if (result.UserType == "manager")
                        {
                            ManagerPage mp = new ManagerPage(result);
                            this.Hide();
                            mp.Show();
                        }
                        else if(result.UserType == "owner")
                        {
                            OwnerPage op = new OwnerPage();
                            this.Hide();
                            op.Show();
                        }
                        else
                        {
                            MessageBox.Show("User does not exist.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Phone number or Password invalid.");
            }
        }      
        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Forgotpass fp = new Forgotpass();
            this.Hide();
            fp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            JOBApplication jb = new JOBApplication();
            this.Hide();
            jb.Show();
        }


    }
}
