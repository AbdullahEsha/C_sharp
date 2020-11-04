using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Ice_Cream_shop_management
{
    public partial class JOBApplication : Form
    {
        string imgLoc = "";
        public JOBApplication()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png | jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgLoc = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           /* byte[] images = null;
            FileStream stream = new FileStream(imgLoc,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);*/
            SignUpService signUpService = new SignUpService();
            CV cv = new CV();
            try
            {
                if (txtUName.Text == string.Empty || dateTimePicker1.Text == string.Empty || txtPhone.Text == string.Empty || rtbEduQuali.Text == string.Empty || rtbEXP.Text == string.Empty || rtbSkill.Text == string.Empty || (rbtnParttime.Checked == false && rbtnFulltime.Checked == false) || (rbtnMale.Checked == false && rbtnFemale.Checked == false) || (rbtnManager.Checked == false && rbtnSalesman.Checked == false))
                {
                    MessageBox.Show("Requirement must be fillup");
                }
                else
                {
                    cv.UserName = txtUName.Text;
                    cv.Dob = Convert.ToDateTime(dateTimePicker1.Value);
                    cv.Phone = Convert.ToInt32(txtPhone.Text);

                    cv.JobType = "";
                    if (rbtnParttime.Checked)
                        cv.JobType = "Part Time";
                    if (rbtnFulltime.Checked)
                        cv.JobType = "Full Time";

                    cv.Gender = "";
                    if (rbtnMale.Checked)
                        cv.Gender = "Male";
                    if (rbtnFemale.Checked)
                        cv.Gender = "Female";

                    cv.JobPost = "";
                    if (rbtnManager.Checked)
                        cv.JobPost = "Manager";
                    if (rbtnSalesman.Checked)
                        cv.JobPost = "Salesman";

                    cv.Qualification = rtbEduQuali.Text;
                    cv.Experience = rtbEXP.Text;
                    cv.Skills = rtbSkill.Text;
                    // cv.Image = (byte)pictureBox1.Image;

                    int result = signUpService.CVInsert(cv);
                    if (result > 0)
                    {
                        MessageBox.Show("Your CV Application Is Approved!!");
                        Login fl1 = new Login();
                        this.Hide();
                        fl1.Show();
                    }
                    else MessageBox.Show("Error!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }


        
    }
}
