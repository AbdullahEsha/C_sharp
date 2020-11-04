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
    public partial class ManageCustomer : Form
    {
        User user;
        string userType;
        public ManageCustomer()
        {
            InitializeComponent();
        }
        public ManageCustomer(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            ManagerButtonService mbs = new ManagerButtonService();
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



                    int result = mbs.UserInsert(userName, pass, phone, gender, "customer");
                    if (result > 0)
                    {
                        MessageBox.Show("Changed");
                        Clear();
                        RClear();
                        UpdateEmp();

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
            ManagerButtonService mbs = new ManagerButtonService();
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
            ManagerButtonService mbs = new ManagerButtonService();
            dataGridView1.DataSource = mbs.UserTypeMember("customer");
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            ManagerButtonService mbs = new ManagerButtonService();
            dataGridView1.DataSource = mbs.UserTypeMember("customer");
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            userType = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPage mp = new ManagerPage(this.user);
            this.Hide();
            mp.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            RClear();
            UpdateEmp();
        }

    }
}
