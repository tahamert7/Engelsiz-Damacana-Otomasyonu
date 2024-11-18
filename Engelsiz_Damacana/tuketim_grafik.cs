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
    public partial class tuketim_grafik : Form
    {
        public tuketim_grafik()
        {
            InitializeComponent();
        }

        private void tuketim_grafik_Load(object sender, EventArgs e)
        {
            grafik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Pzt", 0.5);
            grafik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Sal", 0.75);
            grafik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Çar", 1);
            grafik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Per", 1.25);
            grafik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Cum", 1.5);
            grafik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Cmt", 0.75);
            grafik.Series["Su-Tüketim-Miktarı"].Points.AddXY("Paz", 1);
        }
    }
}
