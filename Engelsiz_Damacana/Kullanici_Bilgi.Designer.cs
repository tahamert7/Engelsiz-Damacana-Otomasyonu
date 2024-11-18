namespace Engelsiz_Damacana
{
    partial class Kullanici_Bilgi
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
            this.lbl_adSoyad = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adSoyad_lbl = new System.Windows.Forms.Label();
            this.telefon_lbl = new System.Windows.Forms.Label();
            this.adres_lbl = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adSoyad.Location = new System.Drawing.Point(129, 157);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(130, 26);
            this.lbl_adSoyad.TabIndex = 0;
            this.lbl_adSoyad.Text = "Ad Soyad : ";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefon.Location = new System.Drawing.Point(129, 201);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(106, 26);
            this.lbl_telefon.TabIndex = 2;
            this.lbl_telefon.Text = "Telefon : ";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(129, 247);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(93, 26);
            this.lbl_adres.TabIndex = 5;
            this.lbl_adres.Text = "Adres : ";
            this.lbl_adres.Click += new System.EventHandler(this.lbl_adres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(126, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Bilgileri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adSoyad_lbl
            // 
            this.adSoyad_lbl.AutoSize = true;
            this.adSoyad_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad_lbl.Location = new System.Drawing.Point(259, 162);
            this.adSoyad_lbl.Name = "adSoyad_lbl";
            this.adSoyad_lbl.Size = new System.Drawing.Size(0, 21);
            this.adSoyad_lbl.TabIndex = 8;
            // 
            // telefon_lbl
            // 
            this.telefon_lbl.AutoSize = true;
            this.telefon_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon_lbl.Location = new System.Drawing.Point(241, 206);
            this.telefon_lbl.Name = "telefon_lbl";
            this.telefon_lbl.Size = new System.Drawing.Size(0, 21);
            this.telefon_lbl.TabIndex = 9;
            // 
            // adres_lbl
            // 
            this.adres_lbl.AutoSize = true;
            this.adres_lbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres_lbl.Location = new System.Drawing.Point(221, 252);
            this.adres_lbl.Name = "adres_lbl";
            this.adres_lbl.Size = new System.Drawing.Size(0, 21);
            this.adres_lbl.TabIndex = 10;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_guncelle.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(134, 287);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(193, 45);
            this.btn_guncelle.TabIndex = 11;
            this.btn_guncelle.Text = "Bilgileri Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kullanici_Bilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.adres_lbl);
            this.Controls.Add(this.telefon_lbl);
            this.Controls.Add(this.adSoyad_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_adSoyad);
            this.Name = "Kullanici_Bilgi";
            this.Text = "Kullanici_Bilgi";
            this.Load += new System.EventHandler(this.Kullanici_Bilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_adSoyad;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adSoyad_lbl;
        private System.Windows.Forms.Label telefon_lbl;
        private System.Windows.Forms.Label adres_lbl;
        private System.Windows.Forms.Button btn_guncelle;
    }
}