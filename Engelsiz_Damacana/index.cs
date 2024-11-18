using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;


namespace Engelsiz_Damacana
{
    public partial class index : Form
    {
        private int su_miktar = 5;        

        public index()
        {
            
            InitializeComponent();
            GuncelMiktar();
        }

        private void siparis_alindi()
        {
            MessageBox.Show("Siparişiniz oluşturuldu");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = su_miktar.ToString();
        }
        private void Su_miktar()
        {

            if (su_miktar <= 5)
            {
                string uyarıMetni = "Damacanadaki kalan su miktarı " + su_miktar + " Litre. Su miktarı azaldı.";
                MessageBox.Show(uyarıMetni, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //SesliOku(uyarıMetni);
            }
            else
            {
                //MessageBox.Show("Damacanadaki kalan su miktarı " + su_miktar + " Litre.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void GuncelMiktar()
        {
            switch(su_miktar)
            {
                case 0:
                    {
                        pictureBox1.Image = Properties.Resources.miktar1;
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Properties.Resources.miktar2;
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Properties.Resources.miktar2;
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Properties.Resources.miktar3;
                        break;
                    }
                case 4:
                    {
                        pictureBox1.Image = Properties.Resources.miktar4;
                        break;
                    }
                case 5:
                    {
                        pictureBox1.Image = Properties.Resources.miktar4;
                        break;
                    }
                case 6:
                    {
                        pictureBox1.Image = Properties.Resources.miktar5;
                        break;
                    }
                case 7:
                    {
                        pictureBox1.Image = Properties.Resources.miktar6;
                        break;
                    }
                case 8:
                    {
                        pictureBox1.Image = Properties.Resources.miktar7;
                        break;
                    }
                case 9:
                    {
                        pictureBox1.Image = Properties.Resources.miktar8;
                        break;
                    }
                case 10:
                    {
                        pictureBox1.Image = Properties.Resources.miktar9;
                        break;
                    }
                case 11:
                    {
                        pictureBox1.Image = Properties.Resources.miktar10;
                        break;
                    }
                case 12:
                    {
                        pictureBox1.Image = Properties.Resources.miktar11;
                        break;
                    }
                case 13:
                    {
                        pictureBox1.Image = Properties.Resources.miktar12;
                        break;
                    }
                case 14:
                    {
                        pictureBox1.Image = Properties.Resources.miktar12;
                        break;
                    }
                case 15:
                    {
                        pictureBox1.Image = Properties.Resources.miktar13;
                        break;
                    }
                case 16:
                    {
                        pictureBox1.Image = Properties.Resources.miktar14;
                        break;
                    }
                case 17:
                    {
                        pictureBox1.Image = Properties.Resources.miktar15;
                        break;
                    }
                case 18:
                    {
                        pictureBox1.Image = Properties.Resources.miktar16;
                        break;
                    }
                case 19:
                    {
                        pictureBox1.Image = Properties.Resources.miktar16;
                        break;
                    }
            }
        }

        //private void SesliOku(string metin)
        //{
        //    // Windows'un sesli okuma API'sini kullanarak metni sesli olarak okuma
        //    if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
        //    {
        //        var parameters = new SAPI.SPVSKBPhrase
        //        {
        //            RateAdjust = -2,
        //            StreamNum = 1,
        //            LangID = 409 // İngilizce için. Farklı bir dil kullanacaksanız uygun dil ID'sini kullanmalısınız.
        //        };

        //        SAPI.SynthVoiceSpeak(metin, ref parameters);
        //    }
        //}
        //public class SAPI
        //{
        //    [DllImport("sapi.dll", SetLastError = true)]
        //    public static extern int SynthVoiceSpeak(string Text, ref SPVSKBPhrase VoiceParameters);

        //    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        //    public struct SPVSKBPhrase
        //    {
        //        public int RateAdjust;
        //        public int StreamNum;
        //        public int LangID;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            siparis_alindi();          
            
        }      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Su_miktar();
            textBox1.Text=su_miktar.ToString();
            GuncelMiktar();
        }

        private void btn_haftalik_Click(object sender, EventArgs e)
        {
            tuketim_grafik tuketim_Grafik=new tuketim_grafik();
            tuketim_Grafik.Show();
        }

        private void btn_aylik_Click(object sender, EventArgs e)
        {
            aylik_tuketim aylik_Tuketim=new aylik_tuketim();
            aylik_Tuketim.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void btn_aylik_MouseEnter(object sender, EventArgs e)
        {
            btn_aylik.BackColor = Color.LightSteelBlue;
        }

        private void btn_aylik_MouseLeave(object sender, EventArgs e)
        {
            btn_aylik.BackColor = Color.LightSkyBlue;
        }

        private void btn_haftalik_MouseEnter(object sender, EventArgs e)
        {
            btn_haftalik.BackColor = Color.LightSteelBlue;
        }

        private void btn_haftalik_MouseLeave(object sender, EventArgs e)
        {
            btn_haftalik.BackColor = Color.LightSkyBlue;
        }
    }
}
//haftaya damacana resmi koy içinde su miktarı anlık olarak gösüzksün grafiği bir sekmeye koy ayrıyetten açılsın. yapıldı.
