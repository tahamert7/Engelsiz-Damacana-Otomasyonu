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
    public partial class Kullanici_Bilgi : Form
    {
        public Kullanici_Bilgi()
        {
            InitializeComponent();
        }

        private void Bilgiler()
        {
            adSoyad_lbl.Text = "Neslihan Bozak";
            telefon_lbl.Text = "0530 892 2481";
            adres_lbl.Text = "Akınlar Mah. 2656 sokak No:4 Daire:5 Kat:1 Düzce/Merkez";
        }

        private void Kullanici_Bilgi_Load(object sender, EventArgs e)
        {
            Bilgiler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.Guncellenen_Veriler(adSoyad_lbl.Text, telefon_lbl.Text, adres_lbl.Text);
            guncelle.Show();
            adSoyad_lbl.Text = guncelle.Yeni_AdSoyad;
            telefon_lbl.Text = guncelle.Yeni_Telefon;
            adres_lbl.Text = guncelle.Yeni_Adres;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_adres_Click(object sender, EventArgs e)
        {

        }
    }
}
