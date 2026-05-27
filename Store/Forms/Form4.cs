using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
        private bool ValidoShitjen()
        {
            if (cmbIdKlienti.SelectedIndex == -1)
            {
                MessageBox.Show("Ju lutem zgjidhni klientin!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbIdProdukti.SelectedIndex == -1)
            {
                MessageBox.Show("Ju lutem zgjidhni produktin!",
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
            return true;
        }
        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!ValidoShitjen())
                return;

            MessageBox.Show("Shitja u shtua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtCmimi_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSasia.Text, out decimal sasia) &&
       decimal.TryParse(txtCmimi.Text, out decimal cmimi))
            {
                txtTotal.Text = (sasia * cmimi).ToString("0.00");
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSasia_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSasia.Text, out decimal sasia) &&
       decimal.TryParse(txtCmimi.Text, out decimal cmimi))
            {
                txtTotal.Text = (sasia * cmimi).ToString("0.00");
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvShitje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ju lutem zgjidhni nje rresht nga lista!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidoShitjen())
                return;

            MessageBox.Show("U ndryshua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            cmbIdKlienti.SelectedIndex = -1;
            txtEmerKlienti.Clear();
            cmbIdProdukti.SelectedIndex = -1;
            txtIDKlienti.Clear();
            txtSasia.Clear();
            txtCmimi.Clear();
            txtTotal.Clear();
            dgvShitje.ClearSelection();
        }

        private void btnRuajFaturen_Click(object sender, EventArgs e)
        {

            if (dgvShitje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ju lutem zgjidhni nje shitje nga lista!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Fatura u ruajt me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    