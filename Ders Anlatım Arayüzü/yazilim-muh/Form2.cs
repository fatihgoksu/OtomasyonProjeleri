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
    public partial class frm_admin_paneli : Form
    {
        public frm_admin_paneli()
        {
            InitializeComponent();
        }

        private void btn_0anamenu_don_Click(object sender, EventArgs e)
        {
            frm_ana_sayfa anapaneli = new frm_ana_sayfa();
            anapaneli.Show();
            this.Hide();
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_ana_sayfa anapaneli = new frm_ana_sayfa();
            anapaneli.Show();
            this.Hide();
            tabControl1.SelectedIndex = 0;
        }
    }
}
