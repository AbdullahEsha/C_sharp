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
    public partial class CVList : Form
    {
        User user;
        int phone;
        public CVList()
        {
            InitializeComponent();
        }
        public CVList(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CVList_Load(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            dataGridView1.DataSource = os.CVGetAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OwnerPage op = new OwnerPage(this.user);
            this.Hide();
            op.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            phone = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                lblSelect.Visible = true;
            }
            else
            {
                lblSelect.Visible = false;
            }
        }
        private void btnDrop_Click(object sender, EventArgs e)
        {
            OwnerService os = new OwnerService();
            if (phone > 0)
            {
                int result = os.CVDelete(phone);
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
            dataGridView1.DataSource = os.CVGetAll();
        }
        
    }
}
