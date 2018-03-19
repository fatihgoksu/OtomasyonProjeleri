using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Site_Emlak_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Kullanıcı Adı ve Şifre Doğrulaması yapan buton
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")//Eğer Kullanıcı Adı ve Şifre doğruysa Yönetici Panelini açan kod
            {
                Form2 emlakkayit = new Form2(); 
                emlakkayit.Show();
                this.Hide();
            }
            else                                                //Eğer Kullanıcı Adı ve Şifre yanlışsa ekranda uyarı verdiren kod
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış Yeniden Deneyiniz!!!");
            }
        }
      

        private void button2_Click(object sender, EventArgs e) //Satılık İlanlar Paneline gitmemizi sağlayan buton
        {
            Form3 satilik = new Form3();
            satilik.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;//Formun full pencere boyutunda görüntülenmesi için kullandığımız kod
        }

        private void button3_Click(object sender, EventArgs e)//Kiralık İlanlar Paneline gitmemizi sağlayan buton
        {
            Form4 kiralik = new Form4();
            kiralik.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
