using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma_Analizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = textKullanıcıAdı.Text.Trim(); // .Trim() ile boşlukları temizler
            string girilenSifre = textSifre.Text;

            // Örnek Giriş Kontrolü (Veritabanı kurulana kadar sabit kontrol)
            if (girilenKullaniciAdi == "Yagmur" && girilenSifre == "12345")
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana Sayfayı açarken kullanıcı adını gönderiyoruz
                AnaSayfa anaSayfa = new AnaSayfa(girilenKullaniciAdi);

                anaSayfa.Show();
                this.Hide();

            }
            else if (girilenKullaniciAdi == "Admin" && girilenSifre == "12345")
            {
                MessageBox.Show("Giriş Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana Sayfayı açarken kullanıcı adını gönderiyoruz
                Admin admin = new Admin();

                admin.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı şifre veya kullanıcı adı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSifre.Clear();
                textSifre.Focus();
            }
            
            
        }

        private void linkKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kayıt Formunu açıyoruz
            Kayıt kayitEkrani = new Kayıt();
            kayitEkrani.Show();
            this.Hide();
        }
    }
}
