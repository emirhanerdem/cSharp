namespace HaliYikamaTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.listBoxMusteriler = new System.Windows.Forms.ListBox();
            this.txtMetreKare = new System.Windows.Forms.TextBox();
            this.dtpAlinma = new System.Windows.Forms.DateTimePicker();
            this.dtpTeslim = new System.Windows.Forms.DateTimePicker();
            this.btnHaliEkle = new System.Windows.Forms.Button();
            this.listBoxYikamada = new System.Windows.Forms.ListBox();
            this.listBoxTeslim = new System.Windows.Forms.ListBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(49, 58);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(120, 22);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(49, 101);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(120, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(49, 152);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(120, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(49, 198);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(120, 22);
            this.txtAdres.TabIndex = 3;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(49, 236);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(120, 37);
            this.btnMusteriEkle.TabIndex = 4;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click_1);
            // 
            // listBoxMusteriler
            // 
            this.listBoxMusteriler.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxMusteriler.FormattingEnabled = true;
            this.listBoxMusteriler.ItemHeight = 16;
            this.listBoxMusteriler.Location = new System.Drawing.Point(49, 292);
            this.listBoxMusteriler.Name = "listBoxMusteriler";
            this.listBoxMusteriler.Size = new System.Drawing.Size(120, 84);
            this.listBoxMusteriler.TabIndex = 5;
            // 
            // txtMetreKare
            // 
            this.txtMetreKare.Location = new System.Drawing.Point(580, 58);
            this.txtMetreKare.Name = "txtMetreKare";
            this.txtMetreKare.Size = new System.Drawing.Size(200, 22);
            this.txtMetreKare.TabIndex = 6;
            // 
            // dtpAlinma
            // 
            this.dtpAlinma.Location = new System.Drawing.Point(580, 99);
            this.dtpAlinma.Name = "dtpAlinma";
            this.dtpAlinma.Size = new System.Drawing.Size(200, 22);
            this.dtpAlinma.TabIndex = 7;
            // 
            // dtpTeslim
            // 
            this.dtpTeslim.Location = new System.Drawing.Point(580, 150);
            this.dtpTeslim.Name = "dtpTeslim";
            this.dtpTeslim.Size = new System.Drawing.Size(200, 22);
            this.dtpTeslim.TabIndex = 8;
            // 
            // btnHaliEkle
            // 
            this.btnHaliEkle.Location = new System.Drawing.Point(580, 197);
            this.btnHaliEkle.Name = "btnHaliEkle";
            this.btnHaliEkle.Size = new System.Drawing.Size(200, 23);
            this.btnHaliEkle.TabIndex = 9;
            this.btnHaliEkle.Text = "Halı Ekle";
            this.btnHaliEkle.UseVisualStyleBackColor = true;
            this.btnHaliEkle.Click += new System.EventHandler(this.btnHaliEkle_Click_1);
            // 
            // listBoxYikamada
            // 
            this.listBoxYikamada.FormattingEnabled = true;
            this.listBoxYikamada.ItemHeight = 16;
            this.listBoxYikamada.Location = new System.Drawing.Point(300, 292);
            this.listBoxYikamada.Name = "listBoxYikamada";
            this.listBoxYikamada.Size = new System.Drawing.Size(120, 84);
            this.listBoxYikamada.TabIndex = 10;
            // 
            // listBoxTeslim
            // 
            this.listBoxTeslim.FormattingEnabled = true;
            this.listBoxTeslim.ItemHeight = 16;
            this.listBoxTeslim.Location = new System.Drawing.Point(477, 292);
            this.listBoxTeslim.Name = "listBoxTeslim";
            this.listBoxTeslim.Size = new System.Drawing.Size(120, 84);
            this.listBoxTeslim.TabIndex = 11;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Location = new System.Drawing.Point(425, 397);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnDurumGuncelle.TabIndex = 12;
            this.btnDurumGuncelle.Text = "Durumu Teslim Et";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.listBoxTeslim);
            this.Controls.Add(this.listBoxYikamada);
            this.Controls.Add(this.btnHaliEkle);
            this.Controls.Add(this.dtpTeslim);
            this.Controls.Add(this.dtpAlinma);
            this.Controls.Add(this.txtMetreKare);
            this.Controls.Add(this.listBoxMusteriler);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ListBox listBoxMusteriler;
        private System.Windows.Forms.TextBox txtMetreKare;
        private System.Windows.Forms.DateTimePicker dtpAlinma;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.Button btnHaliEkle;
        private System.Windows.Forms.ListBox listBoxYikamada;
        private System.Windows.Forms.ListBox listBoxTeslim;
        private System.Windows.Forms.Button btnDurumGuncelle;
    }
}

