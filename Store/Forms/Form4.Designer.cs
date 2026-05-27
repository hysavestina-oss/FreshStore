namespace Store
{
    partial class Form4
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
            btnFshij = new Button();
            btnUpdate = new Button();
            btnPastro = new Button();
            btnShto = new Button();
            dgvShitje = new DataGridView();
            lblIdProdukti = new Label();
            lblEmerKlienti = new Label();
            lblIDKlienti = new Label();
            txtEmerKlienti = new TextBox();
            txtIDKlienti = new TextBox();
            panel1 = new Panel();
            btnDil = new Button();
            btnShitje = new Button();
            btnKlientet = new Button();
            btnProduktet = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbIdKlienti = new ComboBox();
            cmbIdProdukti = new ComboBox();
            lblEmriProduktit = new Label();
            lblSasia = new Label();
            lblData = new Label();
            lblCmimi = new Label();
            txtSasia = new TextBox();
            txtCmimi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnRuajFaturen = new Button();
            txtTotal = new TextBox();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShitje).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFshij
            // 
            btnFshij.BackColor = Color.Tan;
            btnFshij.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFshij.Location = new Point(809, 588);
            btnFshij.Margin = new Padding(4, 3, 4, 3);
            btnFshij.Name = "btnFshij";
            btnFshij.Size = new Size(134, 38);
            btnFshij.TabIndex = 41;
            btnFshij.Text = "Fshije";
            btnFshij.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Tan;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(579, 588);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 38);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnPastro
            // 
            btnPastro.BackColor = Color.Tan;
            btnPastro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPastro.Location = new Point(1038, 588);
            btnPastro.Margin = new Padding(4, 3, 4, 3);
            btnPastro.Name = "btnPastro";
            btnPastro.Size = new Size(134, 38);
            btnPastro.TabIndex = 39;
            btnPastro.Text = "Pastro";
            btnPastro.UseVisualStyleBackColor = false;
            // 
            // btnShto
            // 
            btnShto.BackColor = Color.Tan;
            btnShto.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShto.Location = new Point(337, 588);
            btnShto.Margin = new Padding(4, 3, 4, 3);
            btnShto.Name = "btnShto";
            btnShto.Size = new Size(134, 38);
            btnShto.TabIndex = 38;
            btnShto.Text = "Shto";
            btnShto.UseVisualStyleBackColor = false;
            // 
            // dgvShitje
            // 
            dgvShitje.BackgroundColor = SystemColors.ButtonHighlight;
            dgvShitje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShitje.Location = new Point(609, 166);
            dgvShitje.Name = "dgvShitje";
            dgvShitje.RowHeadersWidth = 62;
            dgvShitje.Size = new Size(761, 339);
            dgvShitje.TabIndex = 37;
            // 
            // lblIdProdukti
            // 
            lblIdProdukti.AutoSize = true;
            lblIdProdukti.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdProdukti.Location = new Point(315, 166);
            lblIdProdukti.Name = "lblIdProdukti";
            lblIdProdukti.Size = new Size(117, 28);
            lblIdProdukti.TabIndex = 36;
            lblIdProdukti.Text = "Id Produkti";
            // 
            // lblEmerKlienti
            // 
            lblEmerKlienti.AutoSize = true;
            lblEmerKlienti.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmerKlienti.Location = new Point(310, 101);
            lblEmerKlienti.Name = "lblEmerKlienti";
            lblEmerKlienti.Size = new Size(122, 28);
            lblEmerKlienti.TabIndex = 35;
            lblEmerKlienti.Text = "EmerKlienti";
            // 
            // lblIDKlienti
            // 
            lblIDKlienti.AutoSize = true;
            lblIDKlienti.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIDKlienti.Location = new Point(307, 28);
            lblIDKlienti.Name = "lblIDKlienti";
            lblIDKlienti.Size = new Size(92, 28);
            lblIDKlienti.TabIndex = 34;
            lblIDKlienti.Text = "IdKlienti";
            lblIDKlienti.Click += lblKlienti_Click;
            // 
            // txtEmerKlienti
            // 
            txtEmerKlienti.BackColor = Color.Tan;
            txtEmerKlienti.Location = new Point(310, 132);
            txtEmerKlienti.Name = "txtEmerKlienti";
            txtEmerKlienti.Size = new Size(182, 31);
            txtEmerKlienti.TabIndex = 32;
            // 
            // txtIDKlienti
            // 
            txtIDKlienti.BackColor = Color.Tan;
            txtIDKlienti.Location = new Point(310, 274);
            txtIDKlienti.Name = "txtIDKlienti";
            txtIDKlienti.Size = new Size(182, 31);
            txtIDKlienti.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(btnDil);
            panel1.Controls.Add(btnShitje);
            panel1.Controls.Add(btnKlientet);
            panel1.Controls.Add(btnProduktet);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-23, -4);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 728);
            panel1.TabIndex = 30;
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
            btnShitje.Location = new Point(82, 293);
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
            btnKlientet.Location = new Point(82, 237);
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
            btnProduktet.Location = new Point(82, 174);
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
            pictureBox1.Location = new Point(73, 17);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(839, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 42;
            label1.Text = "Shitje";
            // 
            // cmbIdKlienti
            // 
            cmbIdKlienti.BackColor = Color.Tan;
            cmbIdKlienti.FormattingEnabled = true;
            cmbIdKlienti.Location = new Point(310, 59);
            cmbIdKlienti.Name = "cmbIdKlienti";
            cmbIdKlienti.Size = new Size(182, 33);
            cmbIdKlienti.TabIndex = 43;
            // 
            // cmbIdProdukti
            // 
            cmbIdProdukti.BackColor = Color.Tan;
            cmbIdProdukti.FormattingEnabled = true;
            cmbIdProdukti.Location = new Point(307, 197);
            cmbIdProdukti.Name = "cmbIdProdukti";
            cmbIdProdukti.Size = new Size(182, 33);
            cmbIdProdukti.TabIndex = 44;
            // 
            // lblEmriProduktit
            // 
            lblEmriProduktit.AutoSize = true;
            lblEmriProduktit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmriProduktit.Location = new Point(310, 243);
            lblEmriProduktit.Name = "lblEmriProduktit";
            lblEmriProduktit.Size = new Size(150, 28);
            lblEmriProduktit.TabIndex = 45;
            lblEmriProduktit.Text = "Emri Produktit";
            // 
            // lblSasia
            // 
            lblSasia.AutoSize = true;
            lblSasia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSasia.Location = new Point(315, 308);
            lblSasia.Name = "lblSasia";
            lblSasia.Size = new Size(60, 28);
            lblSasia.TabIndex = 46;
            lblSasia.Text = "Sasia";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblData.Location = new Point(1155, 73);
            lblData.Name = "lblData";
            lblData.Size = new Size(57, 28);
            lblData.TabIndex = 47;
            lblData.Text = "Data";
            // 
            // lblCmimi
            // 
            lblCmimi.AutoSize = true;
            lblCmimi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCmimi.Location = new Point(310, 373);
            lblCmimi.Name = "lblCmimi";
            lblCmimi.Size = new Size(72, 28);
            lblCmimi.TabIndex = 48;
            lblCmimi.Text = "Cmimi";
            // 
            // txtSasia
            // 
            txtSasia.BackColor = Color.Tan;
            txtSasia.Location = new Point(310, 339);
            txtSasia.Name = "txtSasia";
            txtSasia.Size = new Size(182, 31);
            txtSasia.TabIndex = 49;
            // 
            // txtCmimi
            // 
            txtCmimi.BackColor = Color.Tan;
            txtCmimi.Location = new Point(307, 404);
            txtCmimi.Name = "txtCmimi";
            txtCmimi.Size = new Size(182, 31);
            txtCmimi.TabIndex = 50;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Tan;
            dateTimePicker1.CalendarTitleBackColor = Color.Tan;
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(1070, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 34);
            dateTimePicker1.TabIndex = 51;
            // 
            // btnRuajFaturen
            // 
            btnRuajFaturen.BackColor = Color.Tan;
            btnRuajFaturen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRuajFaturen.Location = new Point(1244, 588);
            btnRuajFaturen.Name = "btnRuajFaturen";
            btnRuajFaturen.Size = new Size(112, 34);
            btnRuajFaturen.TabIndex = 52;
            btnRuajFaturen.Text = "Ruaj Faturen";
            btnRuajFaturen.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Tan;
            txtTotal.Location = new Point(304, 484);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(182, 31);
            txtTotal.TabIndex = 54;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(307, 453);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 28);
            lblTotal.TabIndex = 53;
            lblTotal.Text = "Total";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1409, 698);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnRuajFaturen);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtCmimi);
            Controls.Add(txtSasia);
            Controls.Add(lblCmimi);
            Controls.Add(lblData);
            Controls.Add(lblSasia);
            Controls.Add(lblEmriProduktit);
            Controls.Add(cmbIdProdukti);
            Controls.Add(cmbIdKlienti);
            Controls.Add(label1);
            Controls.Add(btnFshij);
            Controls.Add(btnUpdate);
            Controls.Add(btnPastro);
            Controls.Add(btnShto);
            Controls.Add(dgvShitje);
            Controls.Add(lblIdProdukti);
            Controls.Add(lblEmerKlienti);
            Controls.Add(lblIDKlienti);
            Controls.Add(txtEmerKlienti);
            Controls.Add(txtIDKlienti);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Shitje";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShitje).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFshij;
        private Button btnUpdate;
        private Button btnPastro;
        private Button btnShto;
        private DataGridView dgvShitje;
        private Label lblIdProdukti;
        private Label lblEmerKlienti;
        private Label lblIDKlienti;
        private TextBox txtEmerKlienti;
        private TextBox txtIDKlienti;
        private Panel panel1;
        private Button btnDil;
        private Button btnShitje;
        private Button btnKlientet;
        private Button btnProduktet;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbIdKlienti;
        private ComboBox cmbIdProdukti;
        private Label lblEmriProduktit;
        private Label lblSasia;
        private Label lblData;
        private Label lblCmimi;
        private TextBox txtSasia;
        private TextBox txtCmimi;
        private DateTimePicker dateTimePicker1;
        private Button btnRuajFaturen;
        private TextBox txtTotal;
        private Label lblTotal;
    }
}