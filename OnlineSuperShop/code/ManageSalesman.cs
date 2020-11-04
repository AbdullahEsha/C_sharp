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
    public partial class ManageSalesman : Form
    {
        string userType;
        User user;
        public ManageSalesman()
        {
            InitializeComponent();
        }
        public ManageSalesman(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPage mp = new ManagerPage(this.user);
            this.Hide();
            mp.Show();
        }

        private void ChangeEmployee_Load(object sender, EventArgs e)
        {
            ManagerButtonService mbs = new ManagerButtonService();
            dataGridView1.DataSource = mbs.UserTypeMember("salesman");
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
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



                    int result = mbs.UserInsert(userName, pass, phone, gender, "salesman");
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

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            userType = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                MessageBox.Show("Select a row first");
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
            dataGridView1.DataSource = mbs.UserTypeMember("salesman");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            RClear();
            UpdateEmp();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            ManagerButtonService mbs = new ManagerButtonService();
            try
            {
                if (txtName.Text == string.Empty || txtPhone.Text == string.Empty)
                {
                    MessageBox.Show("Please select one row from girdview");
                }
                else
                {
                    int phone = Convert.ToInt32(txtPhone.Text);
                    string name = txtName.Text;

                    int result = mbs.UserNameUpdate(name, phone);
                    if (result > 0)
                    {
                        MessageBox.Show("Updated");
                        UpdateGridView();
                        Clear();
                    }
                    else MessageBox.Show("Update Error!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateGridView()
        {
            ManagerButtonService mbs = new ManagerButtonService();
            dataGridView1.DataSource = mbs.UserTypeMember("salesman");
        }
    }
}
