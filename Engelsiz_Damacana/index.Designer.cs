﻿namespace Engelsiz_Damacana
{
    partial class index
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.su_tuketimi = new Engelsiz_Damacana.Su_tuketimi();
            this.sutuketimiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suTuketimiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_haftalik = new System.Windows.Forms.Button();
            this.btn_aylik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.su_tuketimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutuketimiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suTuketimiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Onyx", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(200, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sipariş Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Engelsiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // su_tuketimi
            // 
            this.su_tuketimi.DataSetName = "Su_tuketimi";
            this.su_tuketimi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sutuketimiBindingSource
            // 
            this.sutuketimiBindingSource.DataSource = this.su_tuketimi;
            this.sutuketimiBindingSource.Position = 0;
            // 
            // suTuketimiBindingSource1
            // 
            this.suTuketimiBindingSource1.DataMember = "SuTuketimi";
            this.suTuketimiBindingSource1.DataSource = this.sutuketimiBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(196, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Damacanada ki Su Miktarı(L)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(442, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_haftalik
            // 
            this.btn_haftalik.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_haftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_haftalik.Location = new System.Drawing.Point(200, 410);
            this.btn_haftalik.Name = "btn_haftalik";
            this.btn_haftalik.Size = new System.Drawing.Size(313, 79);
            this.btn_haftalik.TabIndex = 6;
            this.btn_haftalik.Text = "Haftalık Tüketim Miktarı";
            this.btn_haftalik.UseVisualStyleBackColor = false;
            this.btn_haftalik.Click += new System.EventHandler(this.btn_haftalik_Click);
            this.btn_haftalik.MouseEnter += new System.EventHandler(this.btn_haftalik_MouseEnter);
            this.btn_haftalik.MouseLeave += new System.EventHandler(this.btn_haftalik_MouseLeave);
            // 
            // btn_aylik
            // 
            this.btn_aylik.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_aylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aylik.Location = new System.Drawing.Point(200, 495);
            this.btn_aylik.Name = "btn_aylik";
            this.btn_aylik.Size = new System.Drawing.Size(313, 79);
            this.btn_aylik.TabIndex = 7;
            this.btn_aylik.Text = "Aylık Tüketim Miktarı";
            this.btn_aylik.UseVisualStyleBackColor = false;
            this.btn_aylik.Click += new System.EventHandler(this.btn_aylik_Click);
            this.btn_aylik.MouseEnter += new System.EventHandler(this.btn_aylik_MouseEnter);
            this.btn_aylik.MouseLeave += new System.EventHandler(this.btn_aylik_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Engelsiz_Damacana.Properties.Resources.miktar1;
            this.pictureBox1.Location = new System.Drawing.Point(243, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(336, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Damacana";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(744, 717);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_aylik);
            this.Controls.Add(this.btn_haftalik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "index";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.su_tuketimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sutuketimiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suTuketimiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource suTuketimiBindingSource1;
        private System.Windows.Forms.BindingSource sutuketimiBindingSource;
        private Su_tuketimi su_tuketimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_haftalik;
        private System.Windows.Forms.Button btn_aylik;
        private System.Windows.Forms.Label label3;
    }
}

