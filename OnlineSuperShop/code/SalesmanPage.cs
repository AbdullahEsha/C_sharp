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
    public partial class SalesmanPage : Form
    {
        User user;
        int id;
        public SalesmanPage()
        {
            InitializeComponent();
        }

        public SalesmanPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();
        }

        private void SalesmanPage_Load(object sender, EventArgs e)
        {
            SalesmanService ss = new SalesmanService();
            dataGridView1.DataSource = ss.GetAll();
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            txtItem.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnAccpet_Click(object sender, EventArgs e)
        {
            SalesmanService ss = new SalesmanService();
            if(txtItem.Text != "")
            {
                int result = ss.Delete(id);
                if (result > 0)
                {
                    UpdateGridView();
                    dataGridView1.Enabled = false;
                    MessageBox.Show("Deleted");
                }
                else MessageBox.Show("Delete Error!!");
            }
            else
                MessageBox.Show("Select an item first.");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            SalesmanService salesmanService = new SalesmanService();
            string itemName = txtItem.Text;
            int quan = Convert.ToInt32(txtQuantity.Text);
            int earn = Convert.ToInt32(txtPayment.Text);
            int sId = user.UserID;

            int result = salesmanService.InsertSold(itemName, quan, earn, sId);
            if (result > 0)
            {
                MessageBox.Show("Insert complete.");
                dataGridView1.Enabled = true;
                Clear();
            }
            else MessageBox.Show("Error!!");

        }

        public void UpdateGridView()
        {
            SalesmanService ss = new SalesmanService();
            dataGridView1.DataSource = ss.GetAll();
            //dataGridView1.Columns[0].Visible = false;
        }
        public void Clear()
        {
            txtItem.Text = "";
            txtQuantity.Text = "";
            txtPayment.Text = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();

        }
    }
}
