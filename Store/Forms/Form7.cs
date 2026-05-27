using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class Raport : Form
    {
        public Raport()
        {
            InitializeComponent();
        }

        private void btnProduktet_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void btnKlientet_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void btnShitje_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();

        }

        private void btnKategorite_Click(object sender, EventArgs e)
        {
            frmKategoria frm = new frmKategoria();
            frm.Show();
            this.Hide();

        }

        private void btnFurnitoret_Click(object sender, EventArgs e)
        {
            frmKategoria frm = new frmKategoria();
            frm.Show();
            this.Hide();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {

        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShfaqRaport_Click(object sender, EventArgs e)
        {
            if (dtNga.Value > dtDeri.Value)
            {
                MessageBox.Show("Data 'Nga' nuk mund te jete me e madhe se data 'Deri'!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
