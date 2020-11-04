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
    public partial class Splash : Form
    {
        int a = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_tick(object sender, EventArgs e)
        {
            if (a == 0)
                label1.Text = "Loading.....";
            if (a == 5)
                label1.Text = "Loading Sweet delights shop management system....";
            if (a == 10)
                label1.Text = "Please Wait....";
            if (a == 20)
                label1.Text = "Loading....";
            if (a == 30)
                label1.Text = "loading Sweet delights shop management system....";
            if (a == 45)
                label1.Text = "Welcome...";
            a += 1;
            if (a >= 50)
            {
                this.Hide();
                timer1.Enabled = false;
                Login frm = new Login();
                frm.ShowDialog();

            }
            progressBar1.Value = a;
        }
        private void frmSplash_Load(object sender, EventArgs e)
        {
        }

        private void frmSplash_Load_1(object sender, EventArgs e)
        {

        }
    }
}
