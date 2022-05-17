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
    public partial class EmanetIslemleri : Form
    {
        public EmanetIslemleri()
        {
            InitializeComponent();
        }
        Connection baglanti = new Connection();
        private void EmanetIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kütüphaneDataSet19.EmanetTablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.emanetTabloTableAdapter4.Fill(this.kütüphaneDataSet19.EmanetTablo);
         

            SqlCommand komut = new SqlCommand("Select * From Kitaplar",baglanti.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kitap_comboBox.DisplayMember = "KitapAd";
            kitap_comboBox.ValueMember = "KitapNo";
            kitap_comboBox.DataSource = dt;
            baglanti.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select * From Uyeler", baglanti.baglanti());
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            uye_comboBox.DisplayMember = "UyeAd";
            uye_comboBox.ValueMember = "UyeNo";
            uye_comboBox.DataSource = dt2;
            baglanti.baglanti().Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            no_label.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            uye_comboBox.DisplayMember = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kitap_comboBox.DisplayMember = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            verilmeTarihi_textBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            geriAlmaTarihi_textBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            islem_textBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            not_TextBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if(dataGridView1.Rows[secilen].Cells[7].Value.ToString().Equals("true"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Boolean izin = false;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutIzin = new SqlCommand("Select UyeNo from BanTablo where UyeNo = @p1", baglanti.baglanti());
            komutIzin.Parameters.AddWithValue("@p1", Convert.ToInt32(uye_comboBox.SelectedValue.ToString()));
            SqlDataReader drIzın = komutIzin.ExecuteReader();
            while (drIzın.Read())
            {
                izin = false;
            }
            baglanti.baglanti().Close();
            if (izin)
            {
                SqlCommand komut = new SqlCommand("Insert into EmanetTablo (UyeNo, KitapNo, EmanetVermeTarih, EmanetGeriAlmaTarih, EmanetKod" +
                ", EmanetNot, EmanetTeslimEdildi) " +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglanti.baglanti());
                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(uye_comboBox.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@p2", Convert.ToInt32(kitap_comboBox.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@p3", verilmeTarihi_textBox.Text);
                komut.Parameters.AddWithValue("@p4", geriAlmaTarihi_textBox.Text);
                komut.Parameters.AddWithValue("@p5", islem_textBox.Text);
                komut.Parameters.AddWithValue("@p6", not_TextBox.Text);
                if (radioButton1.Checked)
                {
                    komut.Parameters.AddWithValue("@p7", true);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p7", false);
                }
                komut.ExecuteNonQuery();
                baglanti.baglanti().Close();
            }
            else
            {
                MessageBox.Show("Uye yasaklıdır.");
            }
            

            this.emanetTabloTableAdapter4.Fill(this.kütüphaneDataSet19.EmanetTablo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update EmanetTablo Set  UyeNo = @p1, KitapNo = @p2, EmanetVermeTarih = @p3, " +
                "EmanetGeriAlmaTarih = @p4, EmanetKod = @p5, EmanetNot = @p6 ,EmanetTeslimEdildi= @p7 where EmanetNo=@p8", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(uye_comboBox.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p2", Convert.ToInt32(kitap_comboBox.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@p3", verilmeTarihi_textBox.Text);
            komut.Parameters.AddWithValue("@p4", geriAlmaTarihi_textBox.Text);
            komut.Parameters.AddWithValue("@p5", islem_textBox.Text);
            komut.Parameters.AddWithValue("@p6", not_TextBox.Text);
            if (radioButton1.Checked)
            {
                komut.Parameters.AddWithValue("@p7", true);
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", false);
            }
            komut.Parameters.AddWithValue("@p8", no_label.Text);
            komut.ExecuteNonQuery();
            this.emanetTabloTableAdapter4.Fill(this.kütüphaneDataSet19.EmanetTablo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From EmanetTablo Where EmanetNo = @p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", no_label.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            this.emanetTabloTableAdapter4.Fill(this.kütüphaneDataSet19.EmanetTablo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from EmanetTablo Where EmanetKod = @p1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", ara_textBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                no_label.Text = dr[0].ToString();
                uye_comboBox.Text = dr[1].ToString();
                kitap_comboBox.Text = dr[2].ToString();
                verilmeTarihi_textBox.Text = dr[3].ToString();
                geriAlmaTarihi_textBox.Text = dr[4].ToString();
                islem_textBox.Text = dr[5].ToString();
                not_TextBox.Text = dr[6].ToString();
                if(dr[7].ToString().Equals("true"))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton1.Checked = false;
                }
            }
            baglanti.baglanti().Close();
        }
    }
}
