using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class frmKategoria : Form
    {
        public frmKategoria()
        {
            InitializeComponent();
        }
        private bool ValidoKategorine()
        {
            if (string.IsNullOrWhiteSpace(txtEmriKategorise.Text))
            {
                MessageBox.Show("Ju lutem shkruani emrin e kategorise!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!ValidoKategorine())
                return;

            MessageBox.Show("Kategoria u shtua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmKategoria_Load(object sender, EventArgs e)
        {

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

        }

        private void btnFurnitoret_Click(object sender, EventArgs e)
        {

            FrmFurnitoret frm = new FrmFurnitoret();
            frm.Show();
            this.Hide();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {

            Raport frm = new Raport();
            frm.Show();
            this.Hide();
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Jeni te sigurt qe doni te fshini?",
       "Konfirmim",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("U fshi me sukses!",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            txtEmriKategorise.Clear();
            dgvKategorite.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKategorite.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ju lutem zgjidhni nje rresht nga lista!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidoKategorine())
                return;

            MessageBox.Show("U ndryshua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    

