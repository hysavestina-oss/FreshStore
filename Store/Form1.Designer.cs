namespace Store
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnHyr = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(78, 128);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 24);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(78, 218);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(109, 24);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            lblPassword.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Tan;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(78, 155);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 31);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Tan;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(78, 245);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnHyr
            // 
            btnHyr.BackColor = Color.Tan;
            btnHyr.Font = new Font("Arial", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHyr.ForeColor = Color.Black;
            btnHyr.Location = new Point(309, 461);
            btnHyr.Name = "btnHyr";
            btnHyr.Size = new Size(112, 34);
            btnHyr.TabIndex = 5;
            btnHyr.Text = "Hyr";
            btnHyr.UseVisualStyleBackColor = false;
            btnHyr.Click += btnHyr_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Imazh1;
            pictureBox1.Location = new Point(446, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Tan;
            comboBox1.Font = new Font("Arial", 10F, FontStyle.Bold | FontStyle.Italic);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Operator" });
            comboBox1.Location = new Point(78, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 32);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Zgjidh Rolin:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(819, 558);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnHyr);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "Form1";
            Text = "Fresh Store";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnHyr;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}
