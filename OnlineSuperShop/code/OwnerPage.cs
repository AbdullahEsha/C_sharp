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
    public partial class OwnerPage : Form
    {
        User user;
        string userType;
        public OwnerPage()
        {
            InitializeComponent();
        }
        public OwnerPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }          
        private void btnReview_Click(object sender, EventArgs e)
        {
            OwnerReview or = new OwnerReview(this.user);
            this.Hide();
            or.Show();
        }    
        private void btnSold_Click(object sender, EventArgs e)
        {
            OwnerSoldItem or = new OwnerSoldItem(this.user);
            this.Hide();
            or.Show();
        }

        

        private void OwnerPage_Load(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            try
            {
                dataGridView1.DataSource = os.GetTypeMember("Manager");
                dataGridView1.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            OwnerService mbs = new OwnerService();
            try
            {
                if (txtName.Text == string.Empty || txtPass.Text == string.Empty || txtPhone.Text == string.Empty
                || (rbtnmale.Checked == false && rbtnfemale.Checked == false))
                {
                    MessageBox.Show("Requirement must be fillup");
                }
                else
                {


                    string userName = txtName.Text;
                    string pass = txtPass.Text;
                    int phone = Convert.ToInt32(txtPhone.Text);

                    string gender = "";
                    if (rbtnmale.Checked)
                        gender = "Male";
                    else
                        gender = "Female";



                    int result = mbs.UserInsert(userName, pass, phone, gender, "manager");
                    if (result > 0)
                    {
                        Clear();
                        RClear();
                        UpdateEmp();
                        MessageBox.Show("Changed");

                    }
                    else MessageBox.Show("Insert Error!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            OwnerService mbs = new OwnerService();
            try
            {
                int phone = Convert.ToInt32(txtPhone.Text);
                if (txtPhone.Text != "")
                {
                    int result = mbs.UserDelete(phone);
                    if (result > 0)
                    {
                        UpdateEmp();
                        Clear();
                        MessageBox.Show("Deleted");
                    }
                    else
                        MessageBox.Show("Delete not successful");
                }
                else
                {
                    MessageBox.Show("Select a row first or you can not delete yourself.");
                    Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtName.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
        }

        public void RClear()
        {
            rbtnmale.Checked = false;
            rbtnfemale.Checked = false;
        }
        public void UpdateEmp()
        {
            OwnerService os = new OwnerService();
            dataGridView1.DataSource = os.GetTypeMember("Manager");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            userType = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            this.Hide();
            ln.Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCvlist_Click(object sender, EventArgs e)
        {
            CVList cl = new CVList(this.user);
            this.Hide();
            cl.Show();
        }

    }
}
