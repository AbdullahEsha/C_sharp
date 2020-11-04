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
    public partial class CustomerReview : Form
    {
        public CustomerReview()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            CustomerPage cp = new CustomerPage();
            this.Hide();
            cp.Show();
        }

        private void CustomerReview_Load(object sender, EventArgs e)
        {
            CustomerReviewService crs = new CustomerReviewService();
            dataGridView1.DataSource = crs.GetAll();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerReviewService crs = new CustomerReviewService();
            Reviews rv = new Reviews();
            try
            {
                if (txtItem.Text == string.Empty || rtbReview.Text == string.Empty || (radioAverage.Checked == false && radioGood.Checked == false && radioExcellent.Checked == false))
                {
                    MessageBox.Show("Requirement must be fillup and you can't select rating more than one");
                }

                else
                {

                    rv.ItemName = txtItem.Text;
                    rv.Review = rtbReview.Text;
                    rv.Rating = "";
                    if (radioAverage.Checked)
                        rv.Rating = "Average";
                    if (radioGood.Checked)
                        rv.Rating = "Good";
                    if (radioExcellent.Checked)
                        rv.Rating = "Excellent";

                    int result = crs.Insert(rv);
                    if (result > 0)
                    {
                        MessageBox.Show("Insert complete.");
                        UpdateGridView();
                        Clear();
                    }
                    else MessageBox.Show("Error!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void UpdateGridView()
        {
            CustomerReviewService cs = new CustomerReviewService();
            dataGridView1.DataSource = cs.GetAll();
        }

        public void Clear()
        {
            txtItem.Text = "";
            rtbReview.Text = "";
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 
    }
}
