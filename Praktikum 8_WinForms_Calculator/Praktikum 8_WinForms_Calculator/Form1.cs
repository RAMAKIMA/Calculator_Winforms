using System.Threading.Tasks;

namespace Praktikum_8_WinForms_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (username.Text == "")
            {
                Login.Enabled = false;
            }
            else if (password.Text == "")
            {
                Login.Enabled = false;
            }
            else
            {
                Login.Enabled = true;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();

            form2.Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                Login.Enabled = false;
            }
            else if (password.Text == "")
            {
                Login.Enabled = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                Login.Enabled = false;
            }
            else
            {
                Login.Enabled = true;
            }
        }
    }
}
