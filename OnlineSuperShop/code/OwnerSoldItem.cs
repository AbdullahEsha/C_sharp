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
    public partial class OwnerSoldItem : Form
    {
        User user;
        public OwnerSoldItem()
        {
            InitializeComponent();
        }
        public OwnerSoldItem(User user) 
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerPage mp = new OwnerPage(user);
            this.Hide();
            mp.Show();
        }

        private void ManagerSoldItem_Load(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            dataGridView1.DataSource = os.SoldItemsGetAll();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearch.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            string item1 = txtSearch.Text;
            if (txtSearch.Text != "")
            {
                try
                {
                   dataGridView1.DataSource = os.GetSearchItems(item1);
                   Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("Select a row first.");
            }
        }
        public void Clear()
        {
            txtSearch.Text = "";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            dataGridView1.DataSource = os.SoldItemsGetAll();
            Clear();
        }
    }
}
