using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliYikamaTakipSistemi
{
    public partial class Form1 : Form
    {
        private List<Musteri> musteriler = new List<Musteri>();

        public Form1()
        {
            InitializeComponent();
        }
        
  

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                   string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                   string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                   string.IsNullOrWhiteSpace(txtAdres.Text))
                {
                    MessageBox.Show("Lütfen tüm müşteri bilgilerini doldurun.");
                    return;
                }

                Musteri m = new Musteri()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Adres = txtAdres.Text
                };
                musteriler.Add(m);
                listBoxMusteriler.Items.Add(m.ToString());

                MessageBox.Show("Müşteri başarıyla eklendi!");

                // Temizle
                txtAd.Clear();
                txtSoyad.Clear();
                txtTelefon.Clear();
                txtAdres.Clear();
            }
        }

        private void btnHaliEkle_Click_1(object sender, EventArgs e)
        {
            if (listBoxMusteriler.SelectedItem is Musteri seciliMusteri)
            {
                Hali h = new Hali()
                {
                    Metrekare = double.Parse(txtMetreKare.Text),
                    AlinmaTarihi = dtpAlinma.Value,
                    TahminiTeslimTarihi = dtpTeslim.Value,
                    YikamaDurumu = Durum.Yikamada
                };

                seciliMusteri.Halilar.Add(h);
                listBoxYikamada.Items.Add(h.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
            }
            txtMetreKare.Clear();
            dtpAlinma.Value = DateTime.Now;
            dtpTeslim.Value = DateTime.Now.AddDays(5); 
        }

        private void btnDurumGuncelle_Click_1(object sender, EventArgs e)
        {
            if (listBoxYikamada.SelectedItem is Hali seciliHali)
            {
                seciliHali.YikamaDurumu = Durum.TeslimEdildi;
                listBoxTeslim.Items.Add(seciliHali);
                listBoxYikamada.Items.Remove(seciliHali);
            }
        }

      
    }
}
