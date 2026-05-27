using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (SessionUser.Roli == "Operator")
            {
                btnKategorite.Visible = false;
                btnFurnitoret.Visible = false;
                btnRaport.Visible = false;
                lblOperatori.Text = "Operator: " + SessionUser.Emri;
            }
            else
            {
                lblOperatori.Text = "Administrator";
            }
        }
        private bool ValidoProduktin()
        {
            if (string.IsNullOrWhiteSpace(txtEmriProduktit.Text))
            {
                MessageBox.Show("Ju lutem shkruani emrin e produktit!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbKategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Ju lutem zgjidhni kategorine!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbFurnitori.SelectedIndex == -1)
            {
                MessageBox.Show("Ju lutem zgjidhni furnitorin!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSasia.Text))
            {
                MessageBox.Show("Ju lutem shkruani sasine!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (int.Parse(txtSasia.Text) <= 0)
            {
                MessageBox.Show("Sasia duhet te jete me e madhe se 0!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCmimi.Text))
            {
                MessageBox.Show("Ju lutem shkruani cmimin!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (decimal.Parse(txtCmimi.Text) <= 0)
            {
                MessageBox.Show("Cmimi duhet te jete me i madh se 0!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!ValidoProduktin())
                return;

            MessageBox.Show("Produkti u shtua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnProduktet_Click(object sender, EventArgs e)
        {

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

        private void txtSasia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSasia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCmimi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
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
            txtEmriProduktit.Clear();
            txtSasia.Clear();
            txtCmimi.Clear();
            cmbKategoria.SelectedIndex = -1;
            cmbFurnitori.SelectedIndex = -1;
            dgvProduktet.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProduktet.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ju lutem zgjidhni nje rresht nga lista!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidoProduktin())
                return;

            MessageBox.Show("U ndryshua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
