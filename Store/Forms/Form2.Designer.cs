namespace Store
{
    partial class Form2
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
            panel1 = new Panel();
            btnRaport = new Button();
            btnFurnitoret = new Button();
            btnKategorite = new Button();
            btnDil = new Button();
            btnShitje = new Button();
            btnKlientet = new Button();
            btnProduktet = new Button();
            pictureBox1 = new PictureBox();
            txtEmriProduktit = new TextBox();
            txtSasia = new TextBox();
            txtCmimi = new TextBox();
            lblEmriProduktit = new Label();
            lblKategoria = new Label();
            lblSasia = new Label();
            lblCmimi = new Label();
            cmbKategoria = new ComboBox();
            dgvProduktet = new DataGridView();
            btnShto = new Button();
            btnPastro = new Button();
            btnUpdate = new Button();
            btnFshij = new Button();
            label1 = new Label();
            cmbFurnitori = new ComboBox();
            lblFurnitori = new Label();
            lblOperatori = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduktet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(btnRaport);
            panel1.Controls.Add(btnFurnitoret);
            panel1.Controls.Add(btnKategorite);
            panel1.Controls.Add(btnDil);
            panel1.Controls.Add(btnShitje);
            panel1.Controls.Add(btnKlientet);
            panel1.Controls.Add(btnProduktet);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-37, -3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 616);
            panel1.TabIndex = 0;
            // 
            // btnRaport
            // 
            btnRaport.BackColor = Color.Moccasin;
            btnRaport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaport.Location = new Point(73, 465);
            btnRaport.Margin = new Padding(4, 3, 4, 3);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(134, 38);
            btnRaport.TabIndex = 7;
            btnRaport.Text = "Raport";
            btnRaport.UseVisualStyleBackColor = false;
            btnRaport.Click += btnRaport_Click;
            // 
            // btnFurnitoret
            // 
            btnFurnitoret.BackColor = Color.Moccasin;
            btnFurnitoret.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFurnitoret.Location = new Point(73, 401);
            btnFurnitoret.Margin = new Padding(4, 3, 4, 3);
            btnFurnitoret.Name = "btnFurnitoret";
            btnFurnitoret.Size = new Size(134, 38);
            btnFurnitoret.TabIndex = 6;
            btnFurnitoret.Text = "Furintoret";
            btnFurnitoret.UseVisualStyleBackColor = false;
            btnFurnitoret.Click += btnFurnitoret_Click;
            // 
            // btnKategorite
            // 
            btnKategorite.BackColor = Color.Moccasin;
            btnKategorite.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKategorite.Location = new Point(73, 345);
            btnKategorite.Margin = new Padding(4, 3, 4, 3);
            btnKategorite.Name = "btnKategorite";
            btnKategorite.Size = new Size(134, 38);
            btnKategorite.TabIndex = 5;
            btnKategorite.Text = "Kategorite";
            btnKategorite.UseVisualStyleBackColor = false;
            btnKategorite.Click += btnKategorite_Click;
            // 
            // btnDil
            // 
            btnDil.BackColor = Color.Moccasin;
            btnDil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDil.Location = new Point(102, 547);
            btnDil.Margin = new Padding(4, 3, 4, 3);
            btnDil.Name = "btnDil";
            btnDil.Size = new Size(134, 38);
            btnDil.TabIndex = 4;
            btnDil.Text = "Dil";
            btnDil.UseVisualStyleBackColor = false;
            btnDil.Click += btnDil_Click;
            // 
            // btnShitje
            // 
            btnShitje.BackColor = Color.Moccasin;
            btnShitje.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShitje.Location = new Point(73, 292);
            btnShitje.Margin = new Padding(4, 3, 4, 3);
            btnShitje.Name = "btnShitje";
            btnShitje.Size = new Size(134, 38);
            btnShitje.TabIndex = 3;
            btnShitje.Text = "Shitje";
            btnShitje.UseVisualStyleBackColor = false;
            btnShitje.Click += btnShitje_Click;
            // 
            // btnKlientet
            // 
            btnKlientet.BackColor = Color.Moccasin;
            btnKlientet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKlientet.Location = new Point(73, 235);
            btnKlientet.Margin = new Padding(4, 3, 4, 3);
            btnKlientet.Name = "btnKlientet";
            btnKlientet.Size = new Size(134, 38);
            btnKlientet.TabIndex = 2;
            btnKlientet.Text = "Klientet";
            btnKlientet.UseVisualStyleBackColor = false;
            btnKlientet.Click += btnKlientet_Click;
            // 
            // btnProduktet
            // 
            btnProduktet.BackColor = Color.Moccasin;
            btnProduktet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduktet.Location = new Point(73, 175);
            btnProduktet.Margin = new Padding(4, 3, 4, 3);
            btnProduktet.Name = "btnProduktet";
            btnProduktet.Size = new Size(134, 38);
            btnProduktet.TabIndex = 1;
            btnProduktet.Text = "Produktet";
            btnProduktet.UseVisualStyleBackColor = false;
            btnProduktet.Click += btnProduktet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imazh1;
            pictureBox1.Location = new Point(73, 17);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtEmriProduktit
            // 
            txtEmriProduktit.BackColor = Color.Tan;
            txtEmriProduktit.Location = new Point(293, 81);
            txtEmriProduktit.Name = "txtEmriProduktit";
            txtEmriProduktit.Size = new Size(182, 34);
            txtEmriProduktit.TabIndex = 1;
            // 
            // txtSasia
            // 
            txtSasia.BackColor = Color.Tan;
            txtSasia.Location = new Point(293, 305);
            txtSasia.Name = "txtSasia";
            txtSasia.Size = new Size(182, 34);
            txtSasia.TabIndex = 3;
            txtSasia.TextChanged += txtSasia_TextChanged;
            txtSasia.KeyPress += txtSasia_KeyPress;
            // 
            // txtCmimi
            // 
            txtCmimi.BackColor = Color.Tan;
            txtCmimi.Location = new Point(293, 373);
            txtCmimi.Name = "txtCmimi";
            txtCmimi.Size = new Size(182, 34);
            txtCmimi.TabIndex = 4;
            txtCmimi.KeyPress += txtCmimi_KeyPress;
            // 
            // lblEmriProduktit
            // 
            lblEmriProduktit.AutoSize = true;
            lblEmriProduktit.Location = new Point(293, 50);
            lblEmriProduktit.Name = "lblEmriProduktit";
            lblEmriProduktit.Size = new Size(150, 28);
            lblEmriProduktit.TabIndex = 6;
            lblEmriProduktit.Text = "Emri Produktit";
            // 
            // lblKategoria
            // 
            lblKategoria.AutoSize = true;
            lblKategoria.Location = new Point(293, 123);
            lblKategoria.Name = "lblKategoria";
            lblKategoria.Size = new Size(104, 28);
            lblKategoria.TabIndex = 7;
            lblKategoria.Text = "Kategoria";
            // 
            // lblSasia
            // 
            lblSasia.AutoSize = true;
            lblSasia.Location = new Point(293, 274);
            lblSasia.Name = "lblSasia";
            lblSasia.Size = new Size(60, 28);
            lblSasia.TabIndex = 8;
            lblSasia.Text = "Sasia";
            // 
            // lblCmimi
            // 
            lblCmimi.AutoSize = true;
            lblCmimi.Location = new Point(293, 342);
            lblCmimi.Name = "lblCmimi";
            lblCmimi.Size = new Size(72, 28);
            lblCmimi.TabIndex = 9;
            lblCmimi.Text = "Cmimi";
            // 
            // cmbKategoria
            // 
            cmbKategoria.BackColor = Color.Tan;
            cmbKategoria.FormattingEnabled = true;
            cmbKategoria.Location = new Point(293, 154);
            cmbKategoria.Name = "cmbKategoria";
            cmbKategoria.Size = new Size(182, 36);
            cmbKategoria.TabIndex = 10;
            // 
            // dgvProduktet
            // 
            dgvProduktet.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProduktet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduktet.Location = new Point(564, 50);
            dgvProduktet.Name = "dgvProduktet";
            dgvProduktet.RowHeadersWidth = 62;
            dgvProduktet.Size = new Size(761, 400);
            dgvProduktet.TabIndex = 11;
            // 
            // btnShto
            // 
            btnShto.BackColor = Color.Tan;
            btnShto.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShto.Location = new Point(305, 522);
            btnShto.Margin = new Padding(4, 3, 4, 3);
            btnShto.Name = "btnShto";
            btnShto.Size = new Size(138, 38);
            btnShto.TabIndex = 12;
            btnShto.Text = "Shto";
            btnShto.UseVisualStyleBackColor = false;
            btnShto.Click += btnShto_Click;
            // 
            // btnPastro
            // 
            btnPastro.BackColor = Color.Tan;
            btnPastro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPastro.Location = new Point(1175, 522);
            btnPastro.Margin = new Padding(4, 3, 4, 3);
            btnPastro.Name = "btnPastro";
            btnPastro.Size = new Size(134, 38);
            btnPastro.TabIndex = 13;
            btnPastro.Text = "Pastro";
            btnPastro.UseVisualStyleBackColor = false;
            btnPastro.Click += btnPastro_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Tan;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(628, 522);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 38);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFshij
            // 
            btnFshij.BackColor = Color.Tan;
            btnFshij.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFshij.Location = new Point(899, 522);
            btnFshij.Margin = new Padding(4, 3, 4, 3);
            btnFshij.Name = "btnFshij";
            btnFshij.Size = new Size(134, 38);
            btnFshij.TabIndex = 15;
            btnFshij.Text = "Fshije";
            btnFshij.UseVisualStyleBackColor = false;
            btnFshij.Click += btnFshij_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(899, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 16;
            label1.Text = "Produktet";
            // 
            // cmbFurnitori
            // 
            cmbFurnitori.BackColor = Color.Tan;
            cmbFurnitori.FormattingEnabled = true;
            cmbFurnitori.Location = new Point(293, 235);
            cmbFurnitori.Name = "cmbFurnitori";
            cmbFurnitori.Size = new Size(182, 36);
            cmbFurnitori.TabIndex = 18;
            // 
            // lblFurnitori
            // 
            lblFurnitori.AutoSize = true;
            lblFurnitori.Location = new Point(293, 204);
            lblFurnitori.Name = "lblFurnitori";
            lblFurnitori.Size = new Size(94, 28);
            lblFurnitori.TabIndex = 17;
            lblFurnitori.Text = "Furnitori";
            // 
            // lblOperatori
            // 
            lblOperatori.AutoSize = true;
            lblOperatori.Location = new Point(1151, 9);
            lblOperatori.Name = "lblOperatori";
            lblOperatori.Size = new Size(0, 28);
            lblOperatori.TabIndex = 19;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1337, 609);
            Controls.Add(lblOperatori);
            Controls.Add(cmbFurnitori);
            Controls.Add(lblFurnitori);
            Controls.Add(label1);
            Controls.Add(btnFshij);
            Controls.Add(btnUpdate);
            Controls.Add(btnPastro);
            Controls.Add(btnShto);
            Controls.Add(dgvProduktet);
            Controls.Add(cmbKategoria);
            Controls.Add(lblCmimi);
            Controls.Add(lblSasia);
            Controls.Add(lblKategoria);
            Controls.Add(lblEmriProduktit);
            Controls.Add(txtCmimi);
            Controls.Add(txtSasia);
            Controls.Add(txtEmriProduktit);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Produktet";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduktet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnShitje;
        private Button btnKlientet;
        private Button btnProduktet;
        private Button btnDil;
        private TextBox txtEmriProduktit;
        private TextBox txtSasia;
        private TextBox txtCmimi;
        private Label lblEmriProduktit;
        private Label lblKategoria;
        private Label lblSasia;
        private Label lblCmimi;
        private ComboBox cmbKategoria;
        private DataGridView dgvProduktet;
        private Button btnShto;
        private Button btnPastro;
        private Button btnUpdate;
        private Button btnFshij;
        private Label label1;
        private ComboBox cmbFurnitori;
        private Label lblFurnitori;
        private Button btnRaport;
        private Button btnFurnitoret;
        private Button btnKategorite;
        private Label lblOperatori;
    }
}