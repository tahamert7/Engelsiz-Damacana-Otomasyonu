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
    public partial class aylik_tuketim : Form
    {
        public aylik_tuketim()
        {
            InitializeComponent();
        }

        private void aylik_tuketim_Load(object sender, EventArgs e)
        {
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Ocak", 50);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Şubat", 61);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Mart", 36);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Nisan", 59);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Mayıs", 47.75);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Haziran", 71);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Temmuz", 58.25);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Ağustos", 51);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Eylül", 49);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Ekim", 61);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Kasım", 36);
            grafikAylik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Aralık", 54);
        }
    }
}
