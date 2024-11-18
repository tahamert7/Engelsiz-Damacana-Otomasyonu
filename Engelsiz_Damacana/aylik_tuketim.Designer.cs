namespace Engelsiz_Damacana
{
    partial class aylik_tuketim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafikAylik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafikAylik)).BeginInit();
            this.SuspendLayout();
            // 
            // grafikAylik
            // 
            this.grafikAylik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grafikAylik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grafikAylik.BackSecondaryColor = System.Drawing.Color.White;
            this.grafikAylik.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.grafikAylik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafikAylik.Legends.Add(legend1);
            this.grafikAylik.Location = new System.Drawing.Point(50, 60);
            this.grafikAylik.Name = "grafikAylik";
            this.grafikAylik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Su-Tüketim-Miktarı";
            this.grafikAylik.Series.Add(series1);
            this.grafikAylik.Size = new System.Drawing.Size(670, 368);
            this.grafikAylik.TabIndex = 0;
            this.grafikAylik.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aylık Su Tüketimi";
            // 
            // aylik_tuketim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafikAylik);
            this.Name = "aylik_tuketim";
            this.Text = "aylik_tuketim";
            this.Load += new System.EventHandler(this.aylik_tuketim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafikAylik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafikAylik;
        private System.Windows.Forms.Label label1;
    }
}