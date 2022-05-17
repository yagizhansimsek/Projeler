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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            SqlCommand create = new SqlCommand("create table BanTablo (UyeNo int, UyeAd varchar(50), UyeSoyad varchar(50),UyeBanTarih date)",baglan.baglanti());
            create.ExecuteNonQuery();
            baglan.baglanti().Close();

            SqlCommand create2 = new SqlCommand("create table CalisanTablo (CalisanNo int, CalisanAd varchar(50), CalisanSoyad varchar(50),CalisanSifre varchar(50), CalisanMail varchar(50))", baglan.baglanti());
            create2.ExecuteNonQuery();
            baglan.baglanti().Close();

            SqlCommand create3 = new SqlCommand("create table EmanetTablo (EmanetNo int, UyeNo int, KitapNo int," +
                "EmanetVermeTarih varchar(50), EmanetGeriAlmaTarih varchar(50), EmanetKod varchar(50), EmanetNot nvarchar(255), EmanetTeslimEdildi nvarchar(50))", baglan.baglanti());
            create3.ExecuteNonQuery();
            baglan.baglanti().Close();

            SqlCommand create4 = new SqlCommand("create table Kitaplar (KitapNo int, KitapAd nvarchar(50), KitapYazari nvarchar(50)," +
                "KitapBaskiYil int, KitapSayfaSayi int, KitapDil nvarchar(50), KitapYayınEvi nvarchar(50), KitapAcıklama text)", baglan.baglanti());
            create4.ExecuteNonQuery();
            baglan.baglanti().Close();

            SqlCommand create5 = new SqlCommand("create table BanTablo (UyeNo int, UyeAd varchar(50), UyeSoyad varchar(50),UyeTelefon nvarchar(50)" +
                "UyeEposta nvarchar(50), UyeAdres nvarchar(MAX), UyeSifre nvarchar(50), UyeBan bit", baglan.baglanti());
            create5.ExecuteNonQuery();
            baglan.baglanti().Close();
            */

        }
        Connection baglan = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            KayıtOl form = new KayıtOl();
            form.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from CalisanTablo where CalisanMail = @p1 and CalisanSifre = @p2",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                main main = new main();
                main.Visible = true;
                this.Visible = false;
            }       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "aliveli@gmail.com";
            textBox2.Text = "123456789";
        }

    }
}
