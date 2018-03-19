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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e) //Formun Loadında tüm panelleri kapalı hale getirmek için kullandığımız kod
        {
            label12.Hide();
            this.WindowState = FormWindowState.Maximized;
        }



        private void button5_Click(object sender, EventArgs e)//Ana Sayfaya Dönmemizi sağlayan buton
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)  //Fotoğraf seçimi ve önizlemesini sağlayan buton
        {
            OpenFileDialog od = new OpenFileDialog();

            od.InitialDirectory = @"C:\Users\Pictures\";       //Dosya seçimi için başlagıçta açılan konum 
            od.Filter = "resimdosyaları|*.jpg;*.bmp;*.gif";    //Seçim yapabileceğimiz veri türleri kısıtlayan kod
            od.Multiselect = true;
            if (od.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                int k = 0;
                foreach (string item in od.FileNames)
                {
                    label12.Show();

                    PictureBox pb = new PictureBox();                        //Dinamik olarak PictureBox oluşturmak için kullandığımız kod
                    pb.Location = new Point(12 + i * 120, 522 );   //Seçilen fotoğrafların gösterileceği konumu belirttiğimiz kod
                    pb.Size = new Size(100, 100);                            //Seçilen fotoğrafların boyutunu belirttiğimiz kod
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;           //Seçilen fotoğrafların gösterim türünü belirttiğimiz kod

                    pb.Image = Image.FromFile(item);
                    this.Controls.Add(pb);
                    i++;
                    if (i >= 10)                                 //En fazla 10 fotoğraf yüklenebilir
                    {
                        i = 0;
                        k++;
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e) //Doldurduğumuz Verileri veritabanına göndermek için kullandığımız buton
        {
            MessageBox.Show("Kayıt Başarılı");                //İşlem gerçekleştiğinde ekrana "Kayıt Başarılı" yazdıran kod
        }

        private void button3_Click(object sender, EventArgs e)  //Gayrimenkul Bilgi Aç butonu
        {
            panel1.Show();
            button3.Hide();
            button8.Show();
            button8.Size = new Size(141, 23);
            button8.Location=new Point(59, 16);
        }

        private void button8_Click(object sender, EventArgs e)//Gayrimenkul Bilgi Gizle butonu
        {
            panel1.Hide();
            button8.Hide();
            button3.Show();
            button3.Size = new Size(141, 23);
            button3.Location = new Point(59, 16);
            
        }


        private void button6_Click(object sender, EventArgs e)//Özellik Aç butonu
        {
            panel2.Show();
            button6.Hide();
            button10.Show();
            button10.Size = new Size(141, 23);
            button10.Location = new Point(218, 16);
        }

        private void button10_Click(object sender, EventArgs e)//Özellik Gizle  butonu
        {
            panel2.Hide();
            button10.Hide();
            button6.Show();
            button6.Size = new Size(141, 23);
            button6.Location = new Point(218, 16);
        }

        private void button4_Click(object sender, EventArgs e)//Adres Aç  butonu
        {
            panel3.Show();
            button4.Hide();
            button11.Show();
            button11.Size = new Size(141, 23);
            button11.Location = new Point(59, 63);
        }

        private void button11_Click(object sender, EventArgs e)//Adres Gizle  butonu
        {
            panel3.Hide();
            button11.Hide();
            button4.Show();
            button4.Size = new Size(141, 23);
            button4.Location = new Point(59, 63);
        }

        private void button7_Click(object sender, EventArgs e)//İlan Sahibi Aç  butonu
        {
            panel4.Show();
            button7.Hide();
            button9.Show();
            button9.Size = new Size(141, 23);
            button9.Location = new Point(218, 63);
        }

        private void button9_Click(object sender, EventArgs e)//İlan Sahibi Gizle  butonu
        {
            panel4.Hide();
            button9.Hide();
            button7.Show();
            button7.Size = new Size(141, 23);
            button7.Location = new Point(218, 63);
        }




    }
}
