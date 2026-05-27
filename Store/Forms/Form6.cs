using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class FrmFurnitoret : Form
    {
        public FrmFurnitoret()
        {
            InitializeComponent();
        }
        private bool ValidoFurnitorin()
        {
            if (string.IsNullOrWhiteSpace(txtEmriFurnitorit.Text))
            {
                MessageBox.Show("Ju lutem shkruani emrin e furnitorit!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNrTelefoniFurnitorit.Text))
            {
                MessageBox.Show("Ju lutem shkruani nr telefonit!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNrTelefoniFurnitorit.Text.Length < 10)
            {
                MessageBox.Show("Nr telefonit duhet te kete te pakten 10 shifra!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmailFurnitorit.Text))
            {
                MessageBox.Show("Ju lutem shkruani emailin!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtEmailFurnitorit.Text.Contains("@") || !txtEmailFurnitorit.Text.Contains("."))
            {
                MessageBox.Show("Ju lutem shkruani email valid! (psh: emri@gmail.com)",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Ju lutem shkruani adresen!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!ValidoFurnitorin())
                return;

            MessageBox.Show("Furnitori u shtua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmFurnitoret_Load(object sender, EventArgs e)
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
            frmKategoria frm = new frmKategoria();
            frm.Show();
            this.Hide();
        }
        private void btnFurnitoret_Click(object sender, EventArgs e)
        {

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvFurnitoret.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ju lutem zgjidhni nje rresht nga lista!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidoFurnitorin())
                return;

            MessageBox.Show("U ndryshua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            txtEmriFurnitorit.Clear();
            txtNrTelefoniFurnitorit.Clear();
            txtEmailFurnitorit.Clear();
            txtAdresa.Clear();
            dgvFurnitoret.ClearSelection();
        }
    }
}
    
