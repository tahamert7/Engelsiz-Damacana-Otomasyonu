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
    public partial class Siparis : Form
    {
        SqlConnection db = new SqlConnection("Data Source=NESLIHAN\\SQLEXPRESS;Initial Catalog=AloDamacanaDB;Integrated Security=True");

        public Siparis()
        {
            InitializeComponent();
        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            MarkaComboBox();
        }

        private void MarkaComboBox()
        {
            try
            {
                db.Open();

                string komut = "SELECT ad FROM Marka";// Marka tablosundaki marka adlarını al

                using (SqlCommand cmd = new SqlCommand(komut, db))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string markaAd = reader["ad"].ToString();// Her bir marka adını ComboBox'a ekle
                            comboMarka.Items.Add(markaAd);
                        }
                    }
                }
            }
            finally
            {
                db.Close();
            }
        }
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();

                string markaAd = comboMarka.Text;
                int adet = Convert.ToInt32(txtAdet.Text);

                string markaID = "SELECT markaID FROM Marka WHERE ad = @ad";// Seçilen markanın ID'sini almak için SQL sorgusu
                string kullaniciID = "SELECT TOP 1 kullaniciID FROM Kullanici ORDER BY kullaniciID DESC";

                using (SqlCommand markaIDCmd = new SqlCommand(markaID, db))
                {
                    markaIDCmd.Parameters.AddWithValue("@ad", markaAd);

                    int markaId = Convert.ToInt32(markaIDCmd.ExecuteScalar()); // Seçilen markanın ID'sini al

                    using (SqlCommand kullaniciIDCmd = new SqlCommand(kullaniciID, db))
                    {
                        int kullaniciId = Convert.ToInt32(kullaniciIDCmd.ExecuteScalar()); // En son eklenen kullanıcının ID'sini al
                        string sorgu = "INSERT INTO Siparis (kullaniciID, markaID, adet) VALUES (@kullaniciID, @markaID, @adet)";// Sipariş tablosuna veri eklemek için SQL sorgusu

                    using (SqlCommand cmd = new SqlCommand(sorgu, db))
                    {
                            cmd.Parameters.AddWithValue("@kullaniciID", kullaniciId);
                            cmd.Parameters.AddWithValue("@markaID", markaId);
                        cmd.Parameters.AddWithValue("@adet", adet);

                        cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                    }
                    }
                }

                MessageBox.Show("Sipariş başarıyla verildi.");
                index anasayfa = new index();
                anasayfa.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş verme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                db.Close();
            }

        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(txtAdet.Text);
            if (adet > 5)
            {
                MessageBox.Show("En fazla 5 adet damacana sipariş verilebilir.");
                return;
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            index anasayfa = new index();
            anasayfa.Show();
            this.Hide();
        }
    }
}
