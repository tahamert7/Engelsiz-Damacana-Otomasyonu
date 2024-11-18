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

namespace Engelsiz_Damacana
{
    public partial class Guncelle : Form
    {
        SqlConnection db = new SqlConnection("Data Source=NESLIHAN\\SQLEXPRESS;Initial Catalog=AloDamacanaDB;Integrated Security=True");

        public Guncelle()
        {
            InitializeComponent();
        }

        public string Yeni_AdSoyad { get; private set; }
        public string Yeni_Telefon { get; private set; }
        public string Yeni_Adres { get; private set; }
        public string Yeni_Mail { get; private set; }

        private void Kayit()
        {
            MessageBox.Show("Kayıt İşlemi Başarılı");
        }

        public void Guncellenen_Veriler(string eski_AdSoyad, string eski_telefon, string eski_mail, string eski_adres)
        {
            ad_guncel.Text = eski_AdSoyad;
            tel_guncel.Text = eski_telefon;
            adres_guncel.Text = eski_adres;
            txt_eposta.Text = eski_adres;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            //buraya sql komutu yaz ki sql e kayıt atsın 
            //Yeni_AdSoyad = ad_guncel.Text;
            //Yeni_Telefon = tel_guncel.Text;
            //Yeni_Adres = adres_guncel.Text;
            //Yeni_Mail = txt_eposta.Text;
            //Kayit();
            //DialogResult = DialogResult.OK;
            //Kullanici_Bilgi kullanici_Bilgi = new Kullanici_Bilgi();
            //kullanici_Bilgi.Show();
            try
            {
                // INSERT SQL sorgusu
                string komut = "INSERT INTO Kullanici (adSoyad, telefon, eposta, adres ) VALUES (@adSoyad, @telefon, @eposta, @adres )";

                using (SqlCommand cmd = new SqlCommand(komut, db))
                {
                    // Parametreleri ekleyerek SQL sorgusunu güncelle
                    cmd.Parameters.AddWithValue("@adSoyad", ad_guncel.Text);
                    cmd.Parameters.AddWithValue("@telefon", tel_guncel.Text);
                    cmd.Parameters.AddWithValue("@eposta", txt_eposta.Text);
                    cmd.Parameters.AddWithValue("@adres", adres_guncel.Text);

                    // Bağlantıyı açın ve sorguyu çalıştırın
                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                }

                MessageBox.Show("Kayıt İşlemi Başarılı");
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            //ad_guncel.Text = Yeni_AdSoyad;
            //tel_guncel.Text = Yeni_Telefon;
            //adres_guncel.Text = Yeni_Adres;
            //txt_eposta .Text = Yeni_Mail;
        }


    }
}
