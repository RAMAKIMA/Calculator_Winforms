using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_8_WinForms_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            int angka1 = int.Parse(value1.Text);
            int angka2 = int.Parse(value2.Text);

            if (opsi1.Checked)
            {
                value3.Text = (angka1 + angka2).ToString();
            }
            else if (opsi2.Checked)
            {
                value3.Text = (angka1 - angka2).ToString();
            }
            else if (opsi3.Checked)
            {
                value3.Text = (angka1 * angka2).ToString();
            }
            else if (opsi4.Checked)
            {
                value3.Text = (angka1 / angka2).ToString();
            }
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }
    }
}
