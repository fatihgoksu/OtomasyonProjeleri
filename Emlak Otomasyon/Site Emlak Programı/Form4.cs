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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) //Formun Loadında tüm panelleri kapalı hale getirmek için kullandığımız kod
        {
            panel1.Hide();
            panel3.Hide();
            panel4.Hide();
            this.WindowState = FormWindowState.Maximized;//Formun full pencere boyutunda görüntülenmesi için kullandığımız kod
        }

        private void button5_Click(object sender, EventArgs e) //Ana Sayfaya Dönmemizi sağlayan buton
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //Kiralık Daireleri göstermek için kullandığımız buton
        {
            panel2.Show();
            panel2.Size = new Size(610, 373);
            panel2.Location = new Point(370, 246);
            panel1.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//Kiralık Ofisleri göstermek için kullandığımız buton
        {
            panel1.Show();
            panel1.Size = new Size(610, 373);
            panel1.Location = new Point(370, 246);
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//Kiralık Arsalari göstermek için kullandığımız buton
        {
            panel3.Show();
            panel3.Size = new Size(610, 373);
            panel3.Location = new Point(370, 246);
            panel1.Hide();
            panel2.Hide();
            panel4.Hide();
        }

        private void button8_Click(object sender, EventArgs e)//Kiralık Tarlalari göstermek için kullandığımız buton
        {
            panel4.Show();
            panel4.Size = new Size(610, 373);
            panel4.Location = new Point(370, 246);
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
