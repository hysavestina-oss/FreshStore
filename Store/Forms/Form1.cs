namespace Store
{
    public partial class Form1 : Form
    {
        private int tentativa = 0;
        private const string passwordAdmin = "admin123";
        private const string passwordOperator = "operator123";
        public Form1()
        {
            InitializeComponent();

        }
        private bool ValidoPassword(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Passwordi duhet te kete te pakten 8 karaktere!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHyr_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ju lutem shkruani passwordin!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidoPassword(password))
                return;

            if (password == passwordAdmin)
            {
                tentativa = 0;
                SessionUser.Roli = "Admin"; 
                SessionUser.Emri = "Administrator";
                MessageBox.Show("Mire se vini Administrator!",
                    "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else if (password == passwordOperator)
            {
                tentativa = 0;
                string emri = Microsoft.VisualBasic.Interaction.InputBox(
                    "Shkruaj emrin tend:", "Operator", "");

                if (string.IsNullOrWhiteSpace(emri))
                {
                    MessageBox.Show("Ju lutem shkruani emrin tuaj!",
                        "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SessionUser.Roli = "Operator";
                SessionUser.Emri = emri;
                MessageBox.Show($"Mire se vini {emri}!",
                    "Operator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                tentativa++;
                if (tentativa >= 3)
                {
                    MessageBox.Show("Keni tejkaluar numrin e perpjekjeve! Aplikacioni do te mbyllet.",
                        "Bllokuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Password i gabuar! Ju kane mbetur {3 - tentativa} perpjekje.",
                        "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
   