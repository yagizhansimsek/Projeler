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
    public partial class KitapIslem : Form
    {
        public KitapIslem()
        {
            InitializeComponent();
        }
        Connection baglanti = new Connection();
        private void KitapIslem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneDataSet13.EmanetTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'kütüphaneDataSet10.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kütüphaneDataSet10.Kitaplar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Kitaplar (KitapAd, KitapYazari, KitapBaskiYil, KitapSayfaSayi, KitapDil, KitapYayinEvi, KitapAciklama) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", kitap_textBox.Text);
            komut.Parameters.AddWithValue("@p2", yazar_textBox.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(yıl_textBox.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(sayfa_textBox.Text));
            komut.Parameters.AddWithValue("@p5", dil_textBox.Text);
            komut.Parameters.AddWithValue("@p6", yayın_textBox.Text);
            komut.Parameters.AddWithValue("@p7", acıklama_TextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            this.kitaplarTableAdapter.Fill(this.kütüphaneDataSet10.Kitaplar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Kitaplar Set  KitapAd = @p1, KitapYazari = @p2, KitapBaskiYil = @p3, " +
                "KitapSayfaSayi = @p4, KitapDil = @p5, KitapYayinEvi = @p6 ,KitapAciklama= @p7 where KitapNo=@p8", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", kitap_textBox.Text);
            komut.Parameters.AddWithValue("@p2", yazar_textBox.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(yıl_textBox.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(sayfa_textBox.Text));
            komut.Parameters.AddWithValue("@p5", dil_textBox.Text);
            komut.Parameters.AddWithValue("@p6", yayın_textBox.Text);
            komut.Parameters.AddWithValue("@p7", acıklama_TextBox.Text);
            komut.Parameters.AddWithValue("@p8", no_label.Text);
            komut.ExecuteNonQuery();
            this.kitaplarTableAdapter.Fill(this.kütüphaneDataSet10.Kitaplar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Kitaplar Where KitapNo = @p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", no_label.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            this.kitaplarTableAdapter.Fill(this.kütüphaneDataSet10.Kitaplar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Kitaplar Where KitapAd = @p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", ara_textBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                no_label.Text = dr[0].ToString();
                kitap_textBox.Text = dr[1].ToString();
                yazar_textBox.Text = dr[2].ToString();
                yıl_textBox.Text = dr[3].ToString();
                sayfa_textBox.Text = dr[4].ToString();
                dil_textBox.Text = dr[5].ToString();
                yayın_textBox.Text = dr[6].ToString();
                acıklama_TextBox.Text = dr[7].ToString();
            }
            baglanti.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            no_label.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kitap_textBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yazar_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            yıl_textBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            sayfa_textBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dil_textBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            yayın_textBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            acıklama_TextBox.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void KitapIslem_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
