using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }
        Connection baglan = new Connection();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into CalisanTablo (CalisanAd, CalisanSoyad, CalisanSifre, CalisanMail) " +
                "values (@p1,@p2,@p3,@p4)",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", calisanAd_textBox.Text);
            komut.Parameters.AddWithValue("@p2", CalisanSoyad_textBox.Text);
            komut.Parameters.AddWithValue("@p3", calisanSifre_textBox.Text);
            komut.Parameters.AddWithValue("@p4", calisanMail_textBox.Text);
            komut.ExecuteNonQuery();
            this.Visible = false;

        }
    }
}
