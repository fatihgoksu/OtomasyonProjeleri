using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yazilim_muh
{
    public partial class frm_ana_sayfa : Form
    {
        public frm_ana_sayfa()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            pnl_sifre_girme.Hide(); 
           this.WindowState = FormWindowState.Maximized;
        }

        private void btn_nesne_nedir_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

 
        private void btn_sinif_olusturma_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btn_nesne_olusturma_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btn_yapici_fonksiyon_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnl_sifre_girme.Show();
            
        }

        private void btn_yonetici_giris_Click(object sender, EventArgs e)
        {
            if (tb_kullanici_adi.Text=="admin" && tb_sifre.Text=="123")
            {
               frm_admin_paneli adminpaneli = new frm_admin_paneli();
            adminpaneli.Show();
            this.Hide();   
            }
            else
            {
                lbl_uyari.Text = "Kullanıcı Adı veya Şifre Yanlış";
            }
        }

        private void btn_anamenu_don_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sinif_olusturma_Click(object sender, EventArgs e)
        {
        }

        private void btn_1anamenu_don_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_1cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void ana_sayfa_Click(object sender, EventArgs e)
        {

        }
    }
}
