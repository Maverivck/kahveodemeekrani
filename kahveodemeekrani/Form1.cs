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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kull, sifre;
            kull = textBox1.Text;
            sifre = textBox2.Text;



            if (kull == "kerem" && sifre == "1234")
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else if (kull != "kerem")
            {
                MessageBox.Show("Kullanıcı Adı Hatalı");
                Application.Exit();
            }
            else if (sifre != "1234")
            {
                MessageBox.Show("Şifre Hatalı");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
    }
}
