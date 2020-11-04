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
    public partial class OwnerReview : Form
    {
        User user;
        int id;
        public OwnerReview()
        {
            InitializeComponent();
        }
        public OwnerReview(User user) 
        {
            InitializeComponent();
            this.user = user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OwnerPage mp = new OwnerPage(this.user);
            this.Hide();
            mp.Show();
        }
        private void OwnerReview_Load(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            dataGridView1.DataSource = os.ReviewGetAll();
            dataGridView1.Columns[0].Visible = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
                {
                    lblSelect.Visible = true;
                }
                else
                {
                    lblSelect.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Click error");
            }
            
        }
        private void btnDrop_Click(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            if (id > 0)
            {
                int result = os.ReviewDelete(id);
                if (result > 0)
                {
                    UpdateTable();
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
            lblSelect.Visible = false;
        }
        public void UpdateTable()
        {
            OwnerService os = new OwnerService();
            dataGridView1.DataSource = os.ReviewGetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
            UpdateTable();
        }

        
    }
}
