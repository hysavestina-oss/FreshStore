using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
        private bool ValidoKlientin()
        {
            if (string.IsNullOrWhiteSpace(txtKlienti.Text))
            {
                MessageBox.Show("Ju lutem shkruani emrin e klientit!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNrTelefoni.Text))
            {
                MessageBox.Show("Ju lutem shkruani nr telefonit!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNrTelefoni.Text.Length < 10)
            {
                MessageBox.Show("Nr telefonit duhet te kete te pakten 10 shifra!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Ju lutem shkruani emailin!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Ju lutem shkruani email valid! (psh: emri@gmail.com)",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!ValidoKlientin())
                return;

            MessageBox.Show("Klienti u shtua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKlientet_Click(object sender, EventArgs e)
        {

        }

        private void btnProduktet_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
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
            txtKlienti.Clear();
            txtNrTelefoni.Clear();
            txtEmail.Clear();
            dgvKlientet.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKlientet.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ju lutem zgjidhni nje rresht nga lista!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidoKlientin())
                return;

            MessageBox.Show("U ndryshua me sukses!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
