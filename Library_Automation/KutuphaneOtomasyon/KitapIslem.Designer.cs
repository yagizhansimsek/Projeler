
namespace KutuphaneOtomasyon
{
    partial class KitapIslem
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
            this.acıklama_TextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sayfa_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneDataSet10 = new KutuphaneOtomasyon.KütüphaneDataSet10();
            this.ara_textBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dil_textBox = new System.Windows.Forms.TextBox();
            this.yıl_textBox = new System.Windows.Forms.TextBox();
            this.yazar_textBox = new System.Windows.Forms.TextBox();
            this.kitap_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.no_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yayın_textBox = new System.Windows.Forms.TextBox();
            this.kitaplarTableAdapter = new KutuphaneOtomasyon.KütüphaneDataSet10TableAdapters.KitaplarTableAdapter();
            this.kütüphaneDataSet13 = new KutuphaneOtomasyon.KütüphaneDataSet13();
            this.emanetTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emanetTabloTableAdapter = new KutuphaneOtomasyon.KütüphaneDataSet13TableAdapters.EmanetTabloTableAdapter();
            this.kitapAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYayinEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfaSayiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBaskiYilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetTabloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // acıklama_TextBox
            // 
            this.acıklama_TextBox.Location = new System.Drawing.Point(528, 133);
            this.acıklama_TextBox.Name = "acıklama_TextBox";
            this.acıklama_TextBox.Size = new System.Drawing.Size(287, 150);
            this.acıklama_TextBox.TabIndex = 63;
            this.acıklama_TextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(409, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "Yayın Evi :";
            // 
            // sayfa_textBox
            // 
            this.sayfa_textBox.Location = new System.Drawing.Point(190, 228);
            this.sayfa_textBox.Name = "sayfa_textBox";
            this.sayfa_textBox.Size = new System.Drawing.Size(184, 22);
            this.sayfa_textBox.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(55, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 58;
            this.label7.Text = "Sayfa Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(409, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Acıklama :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapNoDataGridViewTextBoxColumn,
            this.kitapAdDataGridViewTextBoxColumn,
            this.kitapYazariDataGridViewTextBoxColumn,
            this.kitapBaskiYilDataGridViewTextBoxColumn,
            this.kitapSayfaSayiDataGridViewTextBoxColumn,
            this.kitapDilDataGridViewTextBoxColumn,
            this.kitapYayinEviDataGridViewTextBoxColumn,
            this.kitapAciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 309);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kitapNoDataGridViewTextBoxColumn
            // 
            this.kitapNoDataGridViewTextBoxColumn.DataPropertyName = "KitapNo";
            this.kitapNoDataGridViewTextBoxColumn.HeaderText = "KitapNo";
            this.kitapNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapNoDataGridViewTextBoxColumn.Name = "kitapNoDataGridViewTextBoxColumn";
            this.kitapNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kütüphaneDataSet10;
            // 
            // kütüphaneDataSet10
            // 
            this.kütüphaneDataSet10.DataSetName = "KütüphaneDataSet10";
            this.kütüphaneDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ara_textBox
            // 
            this.ara_textBox.Location = new System.Drawing.Point(847, 172);
            this.ara_textBox.Name = "ara_textBox";
            this.ara_textBox.Size = new System.Drawing.Size(184, 22);
            this.ara_textBox.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(847, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 65);
            this.button4.TabIndex = 54;
            this.button4.Text = "ARA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 67);
            this.button3.TabIndex = 53;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(944, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 67);
            this.button2.TabIndex = 52;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 67);
            this.button1.TabIndex = 51;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dil_textBox
            // 
            this.dil_textBox.Location = new System.Drawing.Point(528, 40);
            this.dil_textBox.Name = "dil_textBox";
            this.dil_textBox.Size = new System.Drawing.Size(184, 22);
            this.dil_textBox.TabIndex = 50;
            // 
            // yıl_textBox
            // 
            this.yıl_textBox.Location = new System.Drawing.Point(190, 172);
            this.yıl_textBox.Name = "yıl_textBox";
            this.yıl_textBox.Size = new System.Drawing.Size(184, 22);
            this.yıl_textBox.TabIndex = 49;
            // 
            // yazar_textBox
            // 
            this.yazar_textBox.Location = new System.Drawing.Point(190, 122);
            this.yazar_textBox.Name = "yazar_textBox";
            this.yazar_textBox.Size = new System.Drawing.Size(184, 22);
            this.yazar_textBox.TabIndex = 48;
            // 
            // kitap_textBox
            // 
            this.kitap_textBox.Location = new System.Drawing.Point(190, 74);
            this.kitap_textBox.Name = "kitap_textBox";
            this.kitap_textBox.Size = new System.Drawing.Size(184, 22);
            this.kitap_textBox.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(465, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Dil :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(73, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Basım Yılı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kitap :";
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.no_label.Location = new System.Drawing.Point(226, 28);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(0, 24);
            this.no_label.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kitap No :";
            // 
            // yayın_textBox
            // 
            this.yayın_textBox.Location = new System.Drawing.Point(528, 90);
            this.yayın_textBox.Name = "yayın_textBox";
            this.yayın_textBox.Size = new System.Drawing.Size(184, 22);
            this.yayın_textBox.TabIndex = 64;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // kütüphaneDataSet13
            // 
            this.kütüphaneDataSet13.DataSetName = "KütüphaneDataSet13";
            this.kütüphaneDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetTabloBindingSource
            // 
            this.emanetTabloBindingSource.DataMember = "EmanetTablo";
            this.emanetTabloBindingSource.DataSource = this.kütüphaneDataSet13;
            // 
            // emanetTabloTableAdapter
            // 
            this.emanetTabloTableAdapter.ClearBeforeFill = true;
            // 
            // kitapAciklamaDataGridViewTextBoxColumn
            // 
            this.kitapAciklamaDataGridViewTextBoxColumn.DataPropertyName = "KitapAciklama";
            this.kitapAciklamaDataGridViewTextBoxColumn.HeaderText = "KitapAciklama";
            this.kitapAciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAciklamaDataGridViewTextBoxColumn.Name = "kitapAciklamaDataGridViewTextBoxColumn";
            this.kitapAciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYayinEviDataGridViewTextBoxColumn
            // 
            this.kitapYayinEviDataGridViewTextBoxColumn.DataPropertyName = "KitapYayinEvi";
            this.kitapYayinEviDataGridViewTextBoxColumn.HeaderText = "KitapYayinEvi";
            this.kitapYayinEviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYayinEviDataGridViewTextBoxColumn.Name = "kitapYayinEviDataGridViewTextBoxColumn";
            this.kitapYayinEviDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapDilDataGridViewTextBoxColumn
            // 
            this.kitapDilDataGridViewTextBoxColumn.DataPropertyName = "KitapDil";
            this.kitapDilDataGridViewTextBoxColumn.HeaderText = "KitapDil";
            this.kitapDilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapDilDataGridViewTextBoxColumn.Name = "kitapDilDataGridViewTextBoxColumn";
            this.kitapDilDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapSayfaSayiDataGridViewTextBoxColumn
            // 
            this.kitapSayfaSayiDataGridViewTextBoxColumn.DataPropertyName = "KitapSayfaSayi";
            this.kitapSayfaSayiDataGridViewTextBoxColumn.HeaderText = "KitapSayfaSayi";
            this.kitapSayfaSayiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapSayfaSayiDataGridViewTextBoxColumn.Name = "kitapSayfaSayiDataGridViewTextBoxColumn";
            this.kitapSayfaSayiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBaskiYilDataGridViewTextBoxColumn
            // 
            this.kitapBaskiYilDataGridViewTextBoxColumn.DataPropertyName = "KitapBaskiYil";
            this.kitapBaskiYilDataGridViewTextBoxColumn.HeaderText = "KitapBaskiYil";
            this.kitapBaskiYilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapBaskiYilDataGridViewTextBoxColumn.Name = "kitapBaskiYilDataGridViewTextBoxColumn";
            this.kitapBaskiYilDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYazariDataGridViewTextBoxColumn
            // 
            this.kitapYazariDataGridViewTextBoxColumn.DataPropertyName = "KitapYazari";
            this.kitapYazariDataGridViewTextBoxColumn.HeaderText = "KitapYazari";
            this.kitapYazariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazariDataGridViewTextBoxColumn.Name = "kitapYazariDataGridViewTextBoxColumn";
            this.kitapYazariDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdDataGridViewTextBoxColumn
            // 
            this.kitapAdDataGridViewTextBoxColumn.DataPropertyName = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.HeaderText = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdDataGridViewTextBoxColumn.Name = "kitapAdDataGridViewTextBoxColumn";
            this.kitapAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // KitapIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 613);
            this.Controls.Add(this.yayın_textBox);
            this.Controls.Add(this.acıklama_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sayfa_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ara_textBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dil_textBox);
            this.Controls.Add(this.yıl_textBox);
            this.Controls.Add(this.yazar_textBox);
            this.Controls.Add(this.kitap_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no_label);
            this.Controls.Add(this.label1);
            this.Name = "KitapIslem";
            this.Text = "KitapIslem";
            this.Load += new System.EventHandler(this.KitapIslem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KitapIslem_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetTabloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox acıklama_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sayfa_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ara_textBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dil_textBox;
        private System.Windows.Forms.TextBox yıl_textBox;
        private System.Windows.Forms.TextBox yazar_textBox;
        private System.Windows.Forms.TextBox kitap_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label no_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yayın_textBox;
        private KütüphaneDataSet10 kütüphaneDataSet10;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KütüphaneDataSet10TableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapNoDataGridViewTextBoxColumn;
        private KütüphaneDataSet13 kütüphaneDataSet13;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBaskiYilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfaSayiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYayinEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource emanetTabloBindingSource;
        private KütüphaneDataSet13TableAdapters.EmanetTabloTableAdapter emanetTabloTableAdapter;
    }
}