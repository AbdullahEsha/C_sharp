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
    public partial class ManagerPage : Form
    {
        User user;
        int quan;
        public ManagerPage()
        {
            InitializeComponent();
        }

        public ManagerPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();
        }

        private void ManagerPage_Load(object sender, EventArgs e)
        {
            ManagerService ms = new ManagerService();
            dataGridView1.DataSource = ms.GetAll();
            dataGridView1.Columns[3].Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == string.Empty || txtQuantity.Text == string.Empty || txtPayment.Text == string.Empty )
            {
                MessageBox.Show("Requirement must be fillup");
            }
            else
            {
                Orders or = new Orders();
                ManagerService manService = new ManagerService();
                
                or.ItemName = txtItem.Text;
                or.Quantity = Convert.ToInt32(txtQuantity.Text);
                or.Payment = Convert.ToInt32(txtPayment.Text);
                int sId = user.UserID;

                string itemName = txtItem.Text;
                int odrQuan = Convert.ToInt32(txtQuantity.Text);
                int newQuan = quan - odrQuan;

                if (odrQuan < quan)
                {
                    int result = manService.InsertSold(or.ItemName, or.Quantity, or.Payment, sId);
                    if (result > 0)
                    {
                        MessageBox.Show("Inserted");
                    }
                    else MessageBox.Show("Insert Error!!");


                    int result1 = manService.Update(newQuan, itemName);
                    if (result1 > 0)
                    {
                        MessageBox.Show("Updated");
                        UpdateGridView();
                        Clear();
                    }
                    else MessageBox.Show("Update Error!!");
                }
                else
                {
                    MessageBox.Show("Sorry we don't have that much...");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            quan = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                int newQuantity = Convert.ToInt32(txtQuantity.Text);
                int price1 = Convert.ToInt32(txtPrice.Text);
                txtPayment.Text = Convert.ToString(newQuantity * price1);
            }   
        }
        public void UpdateGridView()
        {
            ManagerService ms = new ManagerService();
            dataGridView1.DataSource = ms.GetAll();
        }
        public void Clear()
        {
            txtItem.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtPayment.Text = "";
        }
       

        private void btnChangeEmp_Click(object sender, EventArgs e)
        {
            ManageSalesman ce = new ManageSalesman(this.user);
            this.Hide();
            ce.Show();
        }

        private void btnChangeItem_Click(object sender, EventArgs e)
        {
            ChangeItem ci = new ChangeItem(this.user);
            this.Hide();
            ci.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomer ce = new ManageCustomer(this.user);
            this.Hide();
            ce.Show();
        }

      
        
    }
}
