namespace MyFirstDotNetApp
{
    partial class Form1
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.textBoxOlusturmaZamani = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSilinmeZamani = new System.Windows.Forms.TextBox();
            this.OlusturulmaZamani = new System.Windows.Forms.Label();
            this.SilinmeZamani = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Listele = new System.Windows.Forms.Button();
            this.SilindiMi = new System.Windows.Forms.Label();
            this.textBoxSilindiMi = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(290, 64);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(91, 67);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // textBoxOlusturmaZamani
            // 
            this.textBoxOlusturmaZamani.Location = new System.Drawing.Point(290, 141);
            this.textBoxOlusturmaZamani.Name = "textBoxOlusturmaZamani";
            this.textBoxOlusturmaZamani.Size = new System.Drawing.Size(100, 20);
            this.textBoxOlusturmaZamani.TabIndex = 2;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(290, 106);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAd.TabIndex = 3;
            // 
            // textBoxSilinmeZamani
            // 
            this.textBoxSilinmeZamani.Location = new System.Drawing.Point(290, 177);
            this.textBoxSilinmeZamani.Name = "textBoxSilinmeZamani";
            this.textBoxSilinmeZamani.Size = new System.Drawing.Size(100, 20);
            this.textBoxSilinmeZamani.TabIndex = 4;
            // 
            // OlusturulmaZamani
            // 
            this.OlusturulmaZamani.AutoSize = true;
            this.OlusturulmaZamani.Location = new System.Drawing.Point(91, 141);
            this.OlusturulmaZamani.Name = "OlusturulmaZamani";
            this.OlusturulmaZamani.Size = new System.Drawing.Size(97, 13);
            this.OlusturulmaZamani.TabIndex = 6;
            this.OlusturulmaZamani.Text = "OlusturulmaZamani";
            // 
            // SilinmeZamani
            // 
            this.SilinmeZamani.AutoSize = true;
            this.SilinmeZamani.Location = new System.Drawing.Point(91, 177);
            this.SilinmeZamani.Name = "SilinmeZamani";
            this.SilinmeZamani.Size = new System.Drawing.Size(75, 13);
            this.SilinmeZamani.TabIndex = 7;
            this.SilinmeZamani.Text = "SilinmeZamani";
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(106, 312);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(75, 23);
            this.Ekle.TabIndex = 8;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(260, 312);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Guncelle.TabIndex = 9;
            this.Guncelle.Text = "Guncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(433, 312);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 10;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Listele
            // 
            this.Listele.Location = new System.Drawing.Point(602, 312);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(75, 23);
            this.Listele.TabIndex = 11;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            // 
            // SilindiMi
            // 
            this.SilindiMi.AutoSize = true;
            this.SilindiMi.Location = new System.Drawing.Point(91, 210);
            this.SilindiMi.Name = "SilindiMi";
            this.SilindiMi.Size = new System.Drawing.Size(45, 13);
            this.SilindiMi.TabIndex = 12;
            this.SilindiMi.Text = "SilindiMi";
            // 
            // textBoxSilindiMi
            // 
            this.textBoxSilindiMi.Location = new System.Drawing.Point(290, 210);
            this.textBoxSilindiMi.Name = "textBoxSilindiMi";
            this.textBoxSilindiMi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSilindiMi.TabIndex = 13;
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(91, 106);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(20, 13);
            this.Ad.TabIndex = 5;
            this.Ad.Text = "Ad";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(566, 64);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 14;
            this.status.Text = "Status";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // textStatus
            // 
            this.textStatus.AutoSize = true;
            this.textStatus.Location = new System.Drawing.Point(626, 67);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(0, 13);
            this.textStatus.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.textBoxSilindiMi);
            this.Controls.Add(this.SilindiMi);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.SilinmeZamani);
            this.Controls.Add(this.OlusturulmaZamani);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.textBoxSilinmeZamani);
            this.Controls.Add(this.textBoxOlusturmaZamani);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBoxOlusturmaZamani;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSilinmeZamani;
        private System.Windows.Forms.Label OlusturulmaZamani;
        private System.Windows.Forms.Label SilinmeZamani;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Label SilindiMi;
        private System.Windows.Forms.TextBox textBoxSilindiMi;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textStatus;
    }
}

