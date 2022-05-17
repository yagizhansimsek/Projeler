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
    public partial class CalisanIslem : Form
    {
        public CalisanIslem()
        {
            InitializeComponent();
        }
        Connection baglan = new Connection();
        private void CalisanIslem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneDataSet7.CalisanTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTabloTableAdapter3.Fill(this.kütüphaneDataSet7.CalisanTablo);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

 
        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from CalisanTablo where CalisanMail = @p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", ara_textBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                no_label.Text = dr[0].ToString();
                isim_textBox.Text = dr[1].ToString();
                soyisim_textBox.Text = dr[2].ToString();
                mail_textBox.Text = dr[4].ToString();
                sifre_textBox.Text = dr[3].ToString();
            }
            this.calisanTabloTableAdapter3.Fill(this.kütüphaneDataSet7.CalisanTablo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into CalisanTablo (CalisanAd, CalisanSoyad, CalisanSifre, CalisanMail) " +
                "values (@p1,@p2,@p3,@p4)", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", isim_textBox.Text);
            komut.Parameters.AddWithValue("@p2", soyisim_textBox.Text);
            komut.Parameters.AddWithValue("@p3", sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p4", mail_textBox.Text);
            komut.ExecuteNonQuery();
            this.calisanTabloTableAdapter3.Fill(this.kütüphaneDataSet7.CalisanTablo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update CalisanTablo set CalisanAd=@p1, CalisanSoyad=@p2, CalisanSifre=@p3, CalisanMail=@p4", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", isim_textBox.Text);
            komut.Parameters.AddWithValue("@p2", soyisim_textBox.Text);
            komut.Parameters.AddWithValue("@p3", sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p4", mail_textBox.Text);
            komut.ExecuteNonQuery();
            this.calisanTabloTableAdapter3.Fill(this.kütüphaneDataSet7.CalisanTablo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from CalisanTablo where CalisanAd=@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", isim_textBox.Text);
            komut.ExecuteNonQuery();
            this.calisanTabloTableAdapter3.Fill(this.kütüphaneDataSet7.CalisanTablo);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            no_label.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            isim_textBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyisim_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mail_textBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            sifre_textBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }
    }
}
