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
    public partial class Kullanici_Bilgi : Form
    {
        SqlConnection db = new SqlConnection("Data Source=NESLIHAN\\SQLEXPRESS;Initial Catalog=AloDamacanaDB;Integrated Security=True");

        public Kullanici_Bilgi()
        {
            InitializeComponent();
        }

        private void Kullanici_Bilgi_Load(object sender, EventArgs e)
        {
            try
            {
                db.Open();

                //En son eklenen kullanıcıyı getiren SQL sorgusu
                string sorgu = "SELECT TOP 1 adSoyad, telefon, eposta,adres  FROM Kullanici ORDER BY kullaniciID DESC";

                using (SqlCommand cmd = new SqlCommand(sorgu, db))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Veri okuma işlemi
                        if (reader.Read())
                        {
                            string adSoyad = reader["adSoyad"].ToString();
                            string telefon = reader["telefon"].ToString();
                            string eposta = reader["eposta"].ToString();
                            string adres = reader["adres"].ToString();

                            // Okunan verileri ekrana yazdır
                            //MessageBox.Show($"En Son Eklenen Kullanıcı:\nAd Soyad: {adSoyad}\nTelefon: {telefon}\nAdres: {adres}\nMail: {mail}");

                            adSoyad_lbl.Text = adSoyad;
                            telefon_lbl.Text = telefon;
                            mail_lbl.Text = eposta;
                            adres_lbl.Text = adres;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guncelle guncelle = new Guncelle();
            //guncelle.Guncellenen_Veriler(adSoyad_lbl.Text, telefon_lbl.Text, adres_lbl.Text);
            //guncelle.Show();
            //adSoyad_lbl.Text = guncelle.Yeni_AdSoyad;
            //telefon_lbl.Text = guncelle.Yeni_Telefon;
            //adres_lbl.Text = guncelle.Yeni_Adres;

            //string eskiAdSoyad = adSoyad_lbl.Text;
            //string eskiTelefon = telefon_lbl.Text;
            //string eskiAdres = adres_lbl.Text;
            //string eski_mail = mail_lbl.Text;

            //Guncelle guncelleForm = new Guncelle();
            //guncelleForm.Guncellenen_Veriler(eskiAdSoyad, eskiTelefon, eski_mail, eskiAdres);
            //guncelleForm.ShowDialog();

            //string yeniAdSoyad = guncelleForm.Yeni_AdSoyad;
            //string yeniTelefon = guncelleForm.Yeni_Telefon;
            //string yeniAdres = guncelleForm.Yeni_Adres;
            //string yeniMail = guncelleForm.Yeni_Mail;

            //adSoyad_lbl.Text = yeniAdSoyad;
            //telefon_lbl.Text = yeniTelefon;
            //adres_lbl.Text = yeniAdres;
            //mail_lbl.Text = yeniMail;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            index index=new index();
            index.Show();
            this.Hide();
        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            tuketim_grafik tuketim_Grafik = new tuketim_grafik();
            tuketim_Grafik.Show();
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            aylik_tuketim aylik_Tuketim = new aylik_tuketim();
            aylik_Tuketim.Show();
        }

        //private void btnHaftalik_MouseEnter(object sender, EventArgs e)
        //{
        //    btnHaftalik.BackColor = Color.LightSteelBlue;
        //}

        //private void btnHaftalik_MouseLeave(object sender, EventArgs e)
        //{
        //    btnAylik.BackColor = Color.LightSkyBlue;
        //}

        //private void btnAylik_MouseEnter(object sender, EventArgs e)
        //{
        //    btnHaftalik.BackColor = Color.LightSteelBlue;
        //}

        //private void btnAylik_MouseLeave(object sender, EventArgs e)
        //{
        //    btnAylik.BackColor = Color.LightSkyBlue;
        //}
    }
}
