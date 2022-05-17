
namespace KutuphaneOtomasyon
{
    partial class KayıtOl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calisanAd_textBox = new System.Windows.Forms.TextBox();
            this.CalisanSoyad_textBox = new System.Windows.Forms.TextBox();
            this.calisanSifre_textBox = new System.Windows.Forms.TextBox();
            this.calisanMail_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(71, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail :";
            // 
            // calisanAd_textBox
            // 
            this.calisanAd_textBox.Location = new System.Drawing.Point(131, 47);
            this.calisanAd_textBox.Name = "calisanAd_textBox";
            this.calisanAd_textBox.Size = new System.Drawing.Size(255, 22);
            this.calisanAd_textBox.TabIndex = 4;
            // 
            // CalisanSoyad_textBox
            // 
            this.CalisanSoyad_textBox.Location = new System.Drawing.Point(131, 111);
            this.CalisanSoyad_textBox.Name = "CalisanSoyad_textBox";
            this.CalisanSoyad_textBox.Size = new System.Drawing.Size(255, 22);
            this.CalisanSoyad_textBox.TabIndex = 5;
            // 
            // calisanSifre_textBox
            // 
            this.calisanSifre_textBox.Location = new System.Drawing.Point(131, 253);
            this.calisanSifre_textBox.Name = "calisanSifre_textBox";
            this.calisanSifre_textBox.Size = new System.Drawing.Size(255, 22);
            this.calisanSifre_textBox.TabIndex = 6;
            // 
            // calisanMail_textBox
            // 
            this.calisanMail_textBox.Location = new System.Drawing.Point(131, 184);
            this.calisanMail_textBox.Name = "calisanMail_textBox";
            this.calisanMail_textBox.Size = new System.Drawing.Size(255, 22);
            this.calisanMail_textBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calisanMail_textBox);
            this.Controls.Add(this.calisanSifre_textBox);
            this.Controls.Add(this.CalisanSoyad_textBox);
            this.Controls.Add(this.calisanAd_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KayıtOl";
            this.Text = "KayıtOl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox calisanAd_textBox;
        private System.Windows.Forms.TextBox CalisanSoyad_textBox;
        private System.Windows.Forms.TextBox calisanSifre_textBox;
        private System.Windows.Forms.TextBox calisanMail_textBox;
        private System.Windows.Forms.Button button1;
    }
}