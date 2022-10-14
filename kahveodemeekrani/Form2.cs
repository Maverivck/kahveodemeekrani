using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kahveodemeekrani
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int caysayisi = 0;
        int coldsayisi = 0;
        int susayisi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int coldsayisi;
            coldsayisi = Convert.ToInt32(label4.Text);
            coldsayisi++;
            label4.Text = Convert.ToString(coldsayisi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(label5.Text);


            caysayisi++;
            label5.Text = Convert.ToString(caysayisi);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int susayisi = Convert.ToInt32(label6.Text);
            susayisi++;
            label6.Text = Convert.ToString(susayisi);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int coldsayisi = Convert.ToInt32(label4.Text);
            if (coldsayisi > 0)
            {
                coldsayisi--;
                label4.Text = Convert.ToString(coldsayisi);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(label5.Text);
            if (caysayisi > 0)
            {
                caysayisi--;
                label5.Text = Convert.ToString(caysayisi);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int susayisi = Convert.ToInt32(label6.Text);
            if (susayisi > 0)
            {
                susayisi--;
                label6.Text = Convert.ToString(susayisi);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            caysayisi = 0;
            coldsayisi = 0;
            susayisi = 0;

            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş Özeti" + "\n Cold Brew : " + label4.Text + "\n Çay :" + label5.Text + "\n Su : " + label6.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme Başarılı bir şekilde tamamlandı");

            Application.Exit();
        }
    }
}
