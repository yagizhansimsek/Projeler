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
    public partial class UyeIslem : Form
    {
        public UyeIslem()
        {
            InitializeComponent();
        }
        Connection baglanti = new Connection();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UyeIslem_Load(object sender, EventArgs e)
        {
           
            this.uyelerTableAdapter.Fill(this.kütüphaneDataSet8.Uyeler);
            SqlCommand komut = new SqlCommand("Delete From BanTablo Where UyeNo = @p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", no_label.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            no_label.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            isim_textBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyisim_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            telefon_textBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mail_textBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Adres_TextBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            sifre_textBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if(dataGridView1.Rows[secilen].Cells[7].Value.ToString().ToString().Equals("True"))
            {
                ban_label.Text = "banlı";
                ban_button.BackColor = Color.GreenYellow;
                ban_button.Text = "BANI KALDIR";
            }
            else
            {
                ban_label.Text = "";
                ban_button.BackColor = Color.Crimson;
                ban_button.Text = "BANLA";
            }
            this.uyelerTableAdapter.Fill(this.kütüphaneDataSet8.Uyeler);
        }

        private void telefon_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ban_button_Click(object sender, EventArgs e)
        {
            if(ban_button.Text.ToString().Equals("BANLA"))
            {
                SqlCommand komut = new SqlCommand("Insert into BanTablo (UyeNo, UyeAd, UyeSoyad, UyeBanTarih) values (@p1, @p2, @p3, @p4)", baglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", no_label.Text);
                komut.Parameters.AddWithValue("@p2", isim_textBox.Text);
                komut.Parameters.AddWithValue("@p3", soyisim_textBox.Text);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);
                komut.ExecuteNonQuery();
                baglanti.baglanti().Close();

                SqlCommand komut2 = new SqlCommand("Update Uyeler Set UyeBan = @p1 where UyeNo = @p2", baglanti.baglanti());
                komut2.Parameters.AddWithValue("@p1", 1);
                komut2.Parameters.AddWithValue("@p2", no_label.Text);
                komut2.ExecuteNonQuery();
                baglanti.baglanti().Close();
                ban_button.BackColor = Color.GreenYellow;
                ban_button.Text = "BANI KALDIR";
            }
            else
            {
                SqlCommand komut = new SqlCommand("Delete From BanTablo Where UyeNo = @p1", baglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", no_label.Text);
                komut.ExecuteNonQuery();
                baglanti.baglanti().Close();

                SqlCommand komut2 = new SqlCommand("Update Uyeler Set UyeBan = @p1 where UyeNo = @p2", baglanti.baglanti());
                komut2.Parameters.AddWithValue("@p1", 0);
                komut2.Parameters.AddWithValue("@p2", no_label.Text);
                komut2.ExecuteNonQuery();
                baglanti.baglanti().Close();
                ban_button.BackColor = Color.Crimson;
                ban_button.Text = "BANLA";
            }
            this.uyelerTableAdapter.Fill(this.kütüphaneDataSet8.Uyeler);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Uyeler Where UyeSifre = @p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1",ara_textBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                no_label.Text = dr[0].ToString();
                isim_textBox.Text = dr[1].ToString();
                soyisim_textBox.Text = dr[2].ToString();
                telefon_textBox.Text = dr[3].ToString();
                mail_textBox.Text = dr[4].ToString();
                Adres_TextBox.Text = dr[5].ToString();
                sifre_textBox.Text = dr[6].ToString();
                if (dr[7].ToString().Equals("True"))
                {
                    ban_label.Text = "banlı";
                    ban_button.BackColor = Color.GreenYellow;
                    ban_button.Text = "BANI KALDIR.";
                }
                else
                {
                    ban_label.Text = "";
                    ban_button.BackColor = Color.Crimson;
                    ban_button.Text = "BANLA";
                }
            }
            baglanti.baglanti().Close();
            this.uyelerTableAdapter.Fill(this.kütüphaneDataSet8.Uyeler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Uyeler Where UyeNo = @p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", no_label.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            this.uyelerTableAdapter.Fill(this.kütüphaneDataSet8.Uyeler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Uyeler (UyeAd, UyeSoyad, UyeTelefon, UyeEposta, UyeAdres, UyeSifre) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", isim_textBox.Text);
            komut.Parameters.AddWithValue("@p2", soyisim_textBox.Text);
            komut.Parameters.AddWithValue("@p3", telefon_textBox.Text);
            komut.Parameters.AddWithValue("@p4", mail_textBox.Text);
            komut.Parameters.AddWithValue("@p5", Adres_TextBox.Text);
            komut.Parameters.AddWithValue("@p6", sifre_textBox.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            this.uyelerTableAdapter.Fill(this.kütüphaneDataSet8.Uyeler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Uyeler Set  UyeAd = @p1, UyeSoyad = @p2,UyeTelefon = @p3, " +
                "UyeEposta = @p4, UyeAdres = @p5, UyeSifre = @p6 where UyeNo=@p7", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", isim_textBox.Text);
            komut.Parameters.AddWithValue("@p2", soyisim_textBox.Text);
            komut.Parameters.AddWithValue("@p3", telefon_textBox.Text);
            komut.Parameters.AddWithValue("@p4", mail_textBox.Text);
            komut.Parameters.AddWithValue("@p5", Adres_TextBox.Text);
            komut.Parameters.AddWithValue("@p6", sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p7", no_label.Text);
            komut.ExecuteNonQuery();
            this.uyelerTableAdapter.Fill(this.kütüphaneDataSet8.Uyeler);
        }
    }
}
