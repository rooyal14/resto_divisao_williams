using System;
using System.Windows.Forms;

namespace resto_divisão_williams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyPressInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Insira todas as informações", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToDouble(textBox2.Text) == 0)
            {
                MessageBox.Show("Impossível dividir por zero", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }
                textBox3.Text = (Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text)).ToString();
        }

        
    }
}
