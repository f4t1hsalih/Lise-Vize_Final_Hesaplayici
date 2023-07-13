using System;
using System.Windows.Forms;

namespace Vize_Final_Hesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, vize, final, tamnot;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            vize = (a / 100) * 40;
            label1.Text = vize.ToString();

            final = (b / 100) * 60;
            label2.Text = final.ToString();

            tamnot = (vize + final);
            label3.Text = tamnot.ToString();

            if (tamnot > 50)
                MessageBox.Show("Tebrikler Geçtiniz");
            else
                MessageBox.Show("Malesef Geçemediniz");
        }

    }
}
