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
    public partial class CustomerPage : Form
    {
        User user;
        int quan;
        public CustomerPage()
        {
            InitializeComponent();
        }
        public CustomerPage(User user)
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

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            CustomerService c = new CustomerService();
            dataGridView1.DataSource = c.GetAll("Online");
            dataGridView1.Columns[3].Visible = false;
        }

       private void btnConfirm_Click(object sender, EventArgs e)
        {
           Orders or = new Orders();
           CustomerService cusService = new CustomerService();
           try
           {
               if (txtItem.Text == string.Empty || txtQuantity.Text == string.Empty || txtPayment.Text == string.Empty || txtLocation.Text == string.Empty)
               {
                   MessageBox.Show("Requirement must be fillup");
               }
               else
               {

                   or.ItemName = txtItem.Text;
                   or.Quantity = Convert.ToInt32(txtQuantity.Text);
                   or.Payment = Convert.ToInt32(txtPayment.Text);
                   or.Location = txtLocation.Text;

                   string itemName = txtItem.Text;
                   int odrQuan = Convert.ToInt32(txtQuantity.Text);
                   int newQuan = quan - odrQuan;

                   if (odrQuan < quan)
                   {
                       int result = cusService.Insert(or);
                       if (result > 0)
                       {
                           MessageBox.Show("Inserted");
                       }
                       else MessageBox.Show("Insert Error!!");


                       int result1 = cusService.Update(newQuan, itemName);
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
           catch(Exception ex)
           {
               MessageBox.Show(ex.Message);
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
            CustomerService cs = new CustomerService();
            dataGridView1.DataSource = cs.GetAll("Online");
        }
        public void Clear()
        {
            txtItem.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtLocation.Text = "";
            txtPayment.Text = "";
        }

        private void chooseitembutton_Click(object sender, EventArgs e)
        {
            CustomerReview cr = new CustomerReview();
            this.Hide();
            cr.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
