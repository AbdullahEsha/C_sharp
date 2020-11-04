namespace Ice_Cream_shop_management
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.id = new System.Windows.Forms.Label();
            this.Phonetext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(17, 284);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(258, 38);
            this.id.TabIndex = 3;
            this.id.Text = "Phone Number:";
            // 
            // Phonetext
            // 
            this.Phonetext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Phonetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetext.Location = new System.Drawing.Point(23, 325);
            this.Phonetext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phonetext.Name = "Phonetext";
            this.Phonetext.Size = new System.Drawing.Size(319, 34);
            this.Phonetext.TabIndex = 4;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(15, 373);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(180, 38);
            this.password.TabIndex = 5;
            this.password.Text = "Password:";
            // 
            // passtext
            // 
            this.passtext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.Location = new System.Drawing.Point(23, 414);
            this.passtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(319, 34);
            this.passtext.TabIndex = 6;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton.BackgroundImage")));
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(23, 479);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(125, 52);
            this.loginbutton.TabIndex = 7;
            this.loginbutton.Text = "Log In";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpbutton.BackgroundImage")));
            this.SignUpbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignUpbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbutton.Location = new System.Drawing.Point(821, 19);
            this.SignUpbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(65, 61);
            this.SignUpbutton.TabIndex = 8;
            this.SignUpbutton.UseVisualStyleBackColor = false;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(818, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sign Up";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(325, 495);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(330, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "if you forgot your password then click.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 54);
            this.label5.TabIndex = 81;
            this.label5.Text = "SWEET DELIGHTS ";
            // 
            // btnJob
            // 
            this.btnJob.BackColor = System.Drawing.Color.Transparent;
            this.btnJob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJob.BackgroundImage")));
            this.btnJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJob.Location = new System.Drawing.Point(707, 25);
            this.btnJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(73, 55);
            this.btnJob.TabIndex = 82;
            this.btnJob.UseVisualStyleBackColor = false;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 556);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUpbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Phonetext);
            this.Controls.Add(this.id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox Phonetext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJob;
    }
}