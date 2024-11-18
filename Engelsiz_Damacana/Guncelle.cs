using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engelsiz_Damacana
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        public string Yeni_AdSoyad { get; private set; }
        public string Yeni_Telefon { get; private set; }
        public string Yeni_Adres { get; private set; }

        private void Kayit()
        {
            MessageBox.Show("Kayıt İşlemi Başarılı");
        }

        public void Guncellenen_Veriler(string eski_AdSoyad, string eski_telefon, string eski_adres)
        {
            ad_guncel.Text = eski_AdSoyad;
            tel_guncel.Text = eski_telefon;
            adres_guncel.Text = eski_adres;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Yeni_AdSoyad = ad_guncel.Text;
            Yeni_Telefon = tel_guncel.Text;
            Yeni_Adres = adres_guncel.Text;
            Kayit();
            Kullanici_Bilgi kullanici_Bilgi = new Kullanici_Bilgi();
            kullanici_Bilgi.Show();
        }
    }
}
