namespace Store
{
    partial class Raport
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
            label1 = new Label();
            btnShfaqRaport = new Button();
            dvgRaport = new DataGridView();
            panel1 = new Panel();
            btnDil = new Button();
            btnShitje = new Button();
            btnKlientet = new Button();
            btnProduktet = new Button();
            pictureBox1 = new PictureBox();
            dtNga = new DateTimePicker();
            dtDeri = new DateTimePicker();
            lblNgaData = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgRaport).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(944, -28);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 63;
            label1.Text = "Shitje";
            // 
            // btnShfaqRaport
            // 
            btnShfaqRaport.BackColor = Color.Tan;
            btnShfaqRaport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShfaqRaport.Location = new Point(745, 497);
            btnShfaqRaport.Margin = new Padding(4, 3, 4, 3);
            btnShfaqRaport.Name = "btnShfaqRaport";
            btnShfaqRaport.Size = new Size(235, 59);
            btnShfaqRaport.TabIndex = 60;
            btnShfaqRaport.Text = "Shfaqe Raportin";
            btnShfaqRaport.UseVisualStyleBackColor = false;
            // 
            // dvgRaport
            // 
            dvgRaport.BackgroundColor = SystemColors.ButtonHighlight;
            dvgRaport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRaport.Location = new Point(614, 72);
            dvgRaport.Name = "dvgRaport";
            dvgRaport.RowHeadersWidth = 62;
            dvgRaport.Size = new Size(761, 339);
            dvgRaport.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(btnDil);
            panel1.Controls.Add(btnShitje);
            panel1.Controls.Add(btnKlientet);
            panel1.Controls.Add(btnProduktet);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-29, -60);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 728);
            panel1.TabIndex = 52;
            // 
            // btnDil
            // 
            btnDil.BackColor = Color.Moccasin;
            btnDil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDil.Location = new Point(82, 630);
            btnDil.Margin = new Padding(4, 3, 4, 3);
            btnDil.Name = "btnDil";
            btnDil.Size = new Size(134, 38);
            btnDil.TabIndex = 4;
            btnDil.Text = "Dil";
            btnDil.UseVisualStyleBackColor = false;
            // 
            // btnShitje
            // 
            btnShitje.BackColor = Color.Moccasin;
            btnShitje.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShitje.Location = new Point(82, 332);
            btnShitje.Margin = new Padding(4, 3, 4, 3);
            btnShitje.Name = "btnShitje";
            btnShitje.Size = new Size(134, 38);
            btnShitje.TabIndex = 3;
            btnShitje.Text = "Shitje";
            btnShitje.UseVisualStyleBackColor = false;
            // 
            // btnKlientet
            // 
            btnKlientet.BackColor = Color.Moccasin;
            btnKlientet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKlientet.Location = new Point(82, 273);
            btnKlientet.Margin = new Padding(4, 3, 4, 3);
            btnKlientet.Name = "btnKlientet";
            btnKlientet.Size = new Size(134, 38);
            btnKlientet.TabIndex = 2;
            btnKlientet.Text = "Klientet";
            btnKlientet.UseVisualStyleBackColor = false;
            // 
            // btnProduktet
            // 
            btnProduktet.BackColor = Color.Moccasin;
            btnProduktet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduktet.Location = new Point(82, 206);
            btnProduktet.Margin = new Padding(4, 3, 4, 3);
            btnProduktet.Name = "btnProduktet";
            btnProduktet.Size = new Size(134, 38);
            btnProduktet.TabIndex = 1;
            btnProduktet.Text = "Produktet";
            btnProduktet.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imazh1;
            pictureBox1.Location = new Point(65, 63);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dtNga
            // 
            dtNga.CalendarMonthBackground = Color.Tan;
            dtNga.CalendarTitleBackColor = Color.Tan;
            dtNga.CalendarTrailingForeColor = Color.Tan;
            dtNga.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtNga.Location = new Point(289, 92);
            dtNga.Name = "dtNga";
            dtNga.Size = new Size(300, 34);
            dtNga.TabIndex = 64;
            // 
            // dtDeri
            // 
            dtDeri.CalendarMonthBackground = Color.Tan;
            dtDeri.CalendarTitleBackColor = Color.Tan;
            dtDeri.CalendarTrailingForeColor = Color.Tan;
            dtDeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtDeri.Location = new Point(289, 220);
            dtDeri.Name = "dtDeri";
            dtDeri.Size = new Size(300, 34);
            dtDeri.TabIndex = 65;
            // 
            // lblNgaData
            // 
            lblNgaData.AutoSize = true;
            lblNgaData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNgaData.Location = new Point(289, 47);
            lblNgaData.Name = "lblNgaData";
            lblNgaData.Size = new Size(107, 28);
            lblNgaData.TabIndex = 66;
            lblNgaData.Text = "Nga Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(289, 180);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 67;
            label3.Text = "Deri ne:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(628, 11);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 68;
            label2.Text = "Raport";
            // 
            // Raport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1337, 609);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblNgaData);
            Controls.Add(dtDeri);
            Controls.Add(dtNga);
            Controls.Add(label1);
            Controls.Add(btnShfaqRaport);
            Controls.Add(dvgRaport);
            Controls.Add(panel1);
            Name = "Raport";
            Text = "Raport";
            ((System.ComponentModel.ISupportInitialize)dvgRaport).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnShfaqRaport;
        private DataGridView dvgRaport;
        private Panel panel1;
        private Button btnDil;
        private Button btnShitje;
        private Button btnKlientet;
        private Button btnProduktet;
        private PictureBox pictureBox1;
        private DateTimePicker dtNga;
        private DateTimePicker dtDeri;
        private Label lblNgaData;
        private Label label3;
        private Label label2;
    }
}