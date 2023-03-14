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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text)).ToString();
        }
    }
}
