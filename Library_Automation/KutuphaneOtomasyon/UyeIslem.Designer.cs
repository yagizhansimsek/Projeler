
namespace KutuphaneOtomasyon
{
    partial class UyeIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ara_textBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mail_textBox = new System.Windows.Forms.TextBox();
            this.telefon_textBox = new System.Windows.Forms.TextBox();
            this.soyisim_textBox = new System.Windows.Forms.TextBox();
            this.isim_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.no_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ban_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ban_label = new System.Windows.Forms.Label();
            this.kütüphaneDataSet8 = new KutuphaneOtomasyon.KütüphaneDataSet8();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyelerTableAdapter = new KutuphaneOtomasyon.KütüphaneDataSet8TableAdapters.UyelerTableAdapter();
            this.uyeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeEpostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeBanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Adres_TextBox = new System.Windows.Forms.RichTextBox();
            this.kütüphaneDataSet9 = new KutuphaneOtomasyon.KütüphaneDataSet9();
            this.banTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banTabloTableAdapter = new KutuphaneOtomasyon.KütüphaneDataSet9TableAdapters.BanTabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banTabloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeNoDataGridViewTextBoxColumn,
            this.uyeAdDataGridViewTextBoxColumn,
            this.uyeSoyadDataGridViewTextBoxColumn,
            this.uyeTelefonDataGridViewTextBoxColumn,
            this.uyeEpostaDataGridViewTextBoxColumn,
            this.uyeAdresDataGridViewTextBoxColumn,
            this.uyeSifreDataGridViewTextBoxColumn,
            this.uyeBanDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.uyelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 309);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ara_textBox
            // 
            this.ara_textBox.Location = new System.Drawing.Point(842, 187);
            this.ara_textBox.Name = "ara_textBox";
            this.ara_textBox.Size = new System.Drawing.Size(184, 22);
            this.ara_textBox.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(939, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 65);
            this.button4.TabIndex = 30;
            this.button4.Text = "ARA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(873, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 67);
            this.button3.TabIndex = 29;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(939, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 67);
            this.button2.TabIndex = 28;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 67);
            this.button1.TabIndex = 27;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mail_textBox
            // 
            this.mail_textBox.Location = new System.Drawing.Point(554, 45);
            this.mail_textBox.Name = "mail_textBox";
            this.mail_textBox.Size = new System.Drawing.Size(184, 22);
            this.mail_textBox.TabIndex = 26;
            // 
            // telefon_textBox
            // 
            this.telefon_textBox.Location = new System.Drawing.Point(185, 187);
            this.telefon_textBox.Name = "telefon_textBox";
            this.telefon_textBox.Size = new System.Drawing.Size(184, 22);
            this.telefon_textBox.TabIndex = 25;
            this.telefon_textBox.TextChanged += new System.EventHandler(this.telefon_textBox_TextChanged);
            // 
            // soyisim_textBox
            // 
            this.soyisim_textBox.Location = new System.Drawing.Point(185, 137);
            this.soyisim_textBox.Name = "soyisim_textBox";
            this.soyisim_textBox.Size = new System.Drawing.Size(184, 22);
            this.soyisim_textBox.TabIndex = 24;
            // 
            // isim_textBox
            // 
            this.isim_textBox.Location = new System.Drawing.Point(185, 89);
            this.isim_textBox.Name = "isim_textBox";
            this.isim_textBox.Size = new System.Drawing.Size(184, 22);
            this.isim_textBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(413, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Uye E-posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Uye Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Uye Soyisim :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Uye İsim :";
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.no_label.Location = new System.Drawing.Point(221, 43);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(0, 24);
            this.no_label.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Uye No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(413, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Uye Adres :";
            // 
            // sifre_textBox
            // 
            this.sifre_textBox.Location = new System.Drawing.Point(185, 243);
            this.sifre_textBox.Name = "sifre_textBox";
            this.sifre_textBox.Size = new System.Drawing.Size(184, 22);
            this.sifre_textBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Uye Sifre :";
            // 
            // ban_button
            // 
            this.ban_button.BackColor = System.Drawing.Color.Crimson;
            this.ban_button.Location = new System.Drawing.Point(812, 233);
            this.ban_button.Name = "ban_button";
            this.ban_button.Size = new System.Drawing.Size(121, 67);
            this.ban_button.TabIndex = 37;
            this.ban_button.Text = "BANLA";
            this.ban_button.UseVisualStyleBackColor = false;
            this.ban_button.Click += new System.EventHandler(this.ban_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(413, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Uye Ban Durumu :";
            // 
            // ban_label
            // 
            this.ban_label.AutoSize = true;
            this.ban_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ban_label.Location = new System.Drawing.Point(612, 215);
            this.ban_label.Name = "ban_label";
            this.ban_label.Size = new System.Drawing.Size(0, 24);
            this.ban_label.TabIndex = 39;
            // 
            // kütüphaneDataSet8
            // 
            this.kütüphaneDataSet8.DataSetName = "KütüphaneDataSet8";
            this.kütüphaneDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "Uyeler";
            this.uyelerBindingSource.DataSource = this.kütüphaneDataSet8;
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // uyeNoDataGridViewTextBoxColumn
            // 
            this.uyeNoDataGridViewTextBoxColumn.DataPropertyName = "UyeNo";
            this.uyeNoDataGridViewTextBoxColumn.HeaderText = "UyeNo";
            this.uyeNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeNoDataGridViewTextBoxColumn.Name = "uyeNoDataGridViewTextBoxColumn";
            this.uyeNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeAdDataGridViewTextBoxColumn
            // 
            this.uyeAdDataGridViewTextBoxColumn.DataPropertyName = "UyeAd";
            this.uyeAdDataGridViewTextBoxColumn.HeaderText = "UyeAd";
            this.uyeAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeAdDataGridViewTextBoxColumn.Name = "uyeAdDataGridViewTextBoxColumn";
            this.uyeAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeSoyadDataGridViewTextBoxColumn
            // 
            this.uyeSoyadDataGridViewTextBoxColumn.DataPropertyName = "UyeSoyad";
            this.uyeSoyadDataGridViewTextBoxColumn.HeaderText = "UyeSoyad";
            this.uyeSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeSoyadDataGridViewTextBoxColumn.Name = "uyeSoyadDataGridViewTextBoxColumn";
            this.uyeSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeTelefonDataGridViewTextBoxColumn
            // 
            this.uyeTelefonDataGridViewTextBoxColumn.DataPropertyName = "UyeTelefon";
            this.uyeTelefonDataGridViewTextBoxColumn.HeaderText = "UyeTelefon";
            this.uyeTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeTelefonDataGridViewTextBoxColumn.Name = "uyeTelefonDataGridViewTextBoxColumn";
            this.uyeTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeEpostaDataGridViewTextBoxColumn
            // 
            this.uyeEpostaDataGridViewTextBoxColumn.DataPropertyName = "UyeEposta";
            this.uyeEpostaDataGridViewTextBoxColumn.HeaderText = "UyeEposta";
            this.uyeEpostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeEpostaDataGridViewTextBoxColumn.Name = "uyeEpostaDataGridViewTextBoxColumn";
            this.uyeEpostaDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeAdresDataGridViewTextBoxColumn
            // 
            this.uyeAdresDataGridViewTextBoxColumn.DataPropertyName = "UyeAdres";
            this.uyeAdresDataGridViewTextBoxColumn.HeaderText = "UyeAdres";
            this.uyeAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeAdresDataGridViewTextBoxColumn.Name = "uyeAdresDataGridViewTextBoxColumn";
            this.uyeAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeSifreDataGridViewTextBoxColumn
            // 
            this.uyeSifreDataGridViewTextBoxColumn.DataPropertyName = "UyeSifre";
            this.uyeSifreDataGridViewTextBoxColumn.HeaderText = "UyeSifre";
            this.uyeSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeSifreDataGridViewTextBoxColumn.Name = "uyeSifreDataGridViewTextBoxColumn";
            this.uyeSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeBanDataGridViewCheckBoxColumn
            // 
            this.uyeBanDataGridViewCheckBoxColumn.DataPropertyName = "UyeBan";
            this.uyeBanDataGridViewCheckBoxColumn.HeaderText = "UyeBan";
            this.uyeBanDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.uyeBanDataGridViewCheckBoxColumn.Name = "uyeBanDataGridViewCheckBoxColumn";
            this.uyeBanDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Adres_TextBox
            // 
            this.Adres_TextBox.Location = new System.Drawing.Point(554, 103);
            this.Adres_TextBox.Name = "Adres_TextBox";
            this.Adres_TextBox.Size = new System.Drawing.Size(215, 89);
            this.Adres_TextBox.TabIndex = 40;
            this.Adres_TextBox.Text = "";
            // 
            // kütüphaneDataSet9
            // 
            this.kütüphaneDataSet9.DataSetName = "KütüphaneDataSet9";
            this.kütüphaneDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banTabloBindingSource
            // 
            this.banTabloBindingSource.DataMember = "BanTablo";
            this.banTabloBindingSource.DataSource = this.kütüphaneDataSet9;
            // 
            // banTabloTableAdapter
            // 
            this.banTabloTableAdapter.ClearBeforeFill = true;
            // 
            // UyeIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 626);
            this.Controls.Add(this.Adres_TextBox);
            this.Controls.Add(this.ban_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ban_button);
            this.Controls.Add(this.sifre_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ara_textBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mail_textBox);
            this.Controls.Add(this.telefon_textBox);
            this.Controls.Add(this.soyisim_textBox);
            this.Controls.Add(this.isim_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no_label);
            this.Controls.Add(this.label1);
            this.Name = "UyeIslem";
            this.Text = "UyeIslem";
            this.Load += new System.EventHandler(this.UyeIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banTabloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ara_textBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mail_textBox;
        private System.Windows.Forms.TextBox telefon_textBox;
        private System.Windows.Forms.TextBox soyisim_textBox;
        private System.Windows.Forms.TextBox isim_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label no_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ban_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ban_label;
        private KütüphaneDataSet8 kütüphaneDataSet8;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private KütüphaneDataSet8TableAdapters.UyelerTableAdapter uyelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeEpostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uyeBanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.RichTextBox Adres_TextBox;
        private KütüphaneDataSet9 kütüphaneDataSet9;
        private System.Windows.Forms.BindingSource banTabloBindingSource;
        private KütüphaneDataSet9TableAdapters.BanTabloTableAdapter banTabloTableAdapter;
    }
}