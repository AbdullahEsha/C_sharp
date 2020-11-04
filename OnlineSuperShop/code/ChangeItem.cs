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
    public partial class ChangeItem : Form
    {
        string itemName;
        int quan;
        User user;

        public ChangeItem()
        {
            InitializeComponent();
        }
        public ChangeItem(User user)
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
        private void btnPrice_Click(object sender, EventArgs e)
        {
            ManagerService ms = new ManagerService();
            try
            {
                if (txtItem.Text == string.Empty || txtPrice.Text == string.Empty)
                {
                    MessageBox.Show("Please select one row from girdview");
                }
                else
                {
                    int price1 = Convert.ToInt32(txtPrice.Text);
                    itemName = txtItem.Text;

                    int result1 = ms.UpdatePrice(price1, itemName);
                    if (result1 > 0)
                    {
                        MessageBox.Show("Updated");
                        UpdateGridView();
                        Clear();
                    }
                    else MessageBox.Show("Update Error!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quan = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;

        }
        

        private void ChangeItem_Load(object sender, EventArgs e)
        {
            ManagerService ms = new ManagerService();
            dataGridView1.DataSource = ms.GetAll();
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItem.Text == string.Empty || txtQuantity.Text == string.Empty)
                {
                    MessageBox.Show("Please select one row from girdview");
                }
                else
                {
                    ManagerService ms = new ManagerService();

                    int newquan = quan + Convert.ToInt32(txtQuantity.Text);
                    itemName = txtItem.Text;

                    int result1 = ms.Update(newquan, itemName);
                    if (result1 > 0)
                    {
                        MessageBox.Show("Updated");
                        UpdateGridView();
                        Clear();
                    }
                    else MessageBox.Show("Update Error!!");
                }

            }
            catch
            {
                MessageBox.Show("Please select one row from girdview");
            }
           
            

        }

        private void btnItemType_Click(object sender, EventArgs e)
        {
            ManagerService ms = new ManagerService();
            try
            {
                if (txtItem.Text == string.Empty || (rbtnOnline.Checked == false && rbtnOffline.Checked == false))
                {
                    MessageBox.Show("Please select one row from girdview");
                }
                else
                {

                    string itemType = "";
                    if (rbtnOnline.Checked)
                        itemType = "Online";
                    if (rbtnOffline.Checked)
                        itemType = "Offline";

                    itemName = txtItem.Text;

                    int result1 = ms.UpdateItemType(itemType, itemName);
                    if (result1 > 0)
                    {
                        MessageBox.Show("Updated");
                        UpdateGridView();
                        RClear();
                        Clear();
                    }
                    else MessageBox.Show("Update Error!!");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            ManagerService manService = new ManagerService();
            try
            {
                if (txtItem.Text == string.Empty || txtQuantity.Text == string.Empty || txtPrice.Text == string.Empty
                || (rbtnOffline.Checked == false && rbtnOnline.Checked == false))
                {
                    MessageBox.Show("Requirement must be fillup");
                }
                else
                {


                    string itemName = txtItem.Text;
                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    int price = Convert.ToInt32(txtPrice.Text);

                    string itemType = "";
                    if (rbtnOffline.Checked)
                        itemType = "Offline";
                    else
                        itemType = "Online";


                    int result = manService.ItemInsert(itemName, quantity, price, itemType);
                    if (result > 0)
                    {
                        MessageBox.Show("Inserted");
                        UpdateGridView();
                        RClear();
                        Clear();
                    }
                    else MessageBox.Show("Insert Error!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            ManagerService ms = new ManagerService();
            try
            {
                string itemName = txtItem.Text;
                if (txtItem.Text != "")
                {
                    int result = ms.DeleteItem(itemName);
                    if (result > 0)
                    {
                        UpdateGridView();
                        Clear();
                        MessageBox.Show("Deleted");
                    }
                    else
                        MessageBox.Show("Delete not successful");
                }
                else
                {
                    MessageBox.Show("Select a row first.");
                }
            }            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        }

        public void RClear()
        {
            rbtnOffline.Checked = false;
            rbtnOnline.Checked = false;
        }
    }
}
