namespace Winforms_KisiRehber
{
    partial class frmKisiEkleGuncelle
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
            this.grbEkle = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.listGoruntule = new System.Windows.Forms.ListView();
            this.columnAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbGuncelle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.rchAdresGuncelle = new System.Windows.Forms.RichTextBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtTelefonGuncelle = new System.Windows.Forms.TextBox();
            this.txtSoyadGuncelle = new System.Windows.Forms.TextBox();
            this.txtAdGuncelle = new System.Windows.Forms.TextBox();
            this.lblAdresGuncelle = new System.Windows.Forms.Label();
            this.lblTelefongucelle = new System.Windows.Forms.Label();
            this.lblSoyadGuncelle = new System.Windows.Forms.Label();
            this.lblAdguncelle = new System.Windows.Forms.Label();
            this.grbEkle.SuspendLayout();
            this.grbGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEkle
            // 
            this.grbEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbEkle.Controls.Add(this.btnEkle);
            this.grbEkle.Controls.Add(this.btnCancel);
            this.grbEkle.Controls.Add(this.rchAdres);
            this.grbEkle.Controls.Add(this.txtTelefon);
            this.grbEkle.Controls.Add(this.txtSoyad);
            this.grbEkle.Controls.Add(this.txtAd);
            this.grbEkle.Controls.Add(this.lblAdres);
            this.grbEkle.Controls.Add(this.lblTelefon);
            this.grbEkle.Controls.Add(this.lblSoyad);
            this.grbEkle.Controls.Add(this.lblAd);
            this.grbEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbEkle.Location = new System.Drawing.Point(12, 12);
            this.grbEkle.Name = "grbEkle";
            this.grbEkle.Size = new System.Drawing.Size(333, 292);
            this.grbEkle.TabIndex = 0;
            this.grbEkle.TabStop = false;
            this.grbEkle.Text = "KİŞİ EKLE";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(140, 248);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 38);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(140, 146);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(185, 96);
            this.rchAdres.TabIndex = 7;
            this.rchAdres.Text = "";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(140, 109);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(185, 21);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(140, 72);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(185, 21);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(140, 35);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(185, 21);
            this.txtAd.TabIndex = 4;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(12, 149);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(53, 15);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "ADRES";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 112);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(69, 15);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "TELEFON";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(12, 75);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(52, 15);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "SOYAD";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 38);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 15);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "AD";
            // 
            // listGoruntule
            // 
            this.listGoruntule.BackColor = System.Drawing.Color.LightYellow;
            this.listGoruntule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAdSoyad,
            this.columnTelefon});
            this.listGoruntule.FullRowSelect = true;
            this.listGoruntule.Location = new System.Drawing.Point(12, 310);
            this.listGoruntule.Name = "listGoruntule";
            this.listGoruntule.Size = new System.Drawing.Size(672, 128);
            this.listGoruntule.TabIndex = 2;
            this.listGoruntule.UseCompatibleStateImageBehavior = false;
            this.listGoruntule.View = System.Windows.Forms.View.Details;
            this.listGoruntule.SelectedIndexChanged += new System.EventHandler(this.listGoruntule_SelectedIndexChanged);
            // 
            // columnAdSoyad
            // 
            this.columnAdSoyad.Text = "AD SOYAD";
            this.columnAdSoyad.Width = 198;
            // 
            // columnTelefon
            // 
            this.columnTelefon.Text = "TELEFON";
            this.columnTelefon.Width = 211;
            // 
            // grbGuncelle
            // 
            this.grbGuncelle.BackColor = System.Drawing.Color.Silver;
            this.grbGuncelle.Controls.Add(this.btnGuncelle);
            this.grbGuncelle.Controls.Add(this.rchAdresGuncelle);
            this.grbGuncelle.Controls.Add(this.btnİptal);
            this.grbGuncelle.Controls.Add(this.txtTelefonGuncelle);
            this.grbGuncelle.Controls.Add(this.txtSoyadGuncelle);
            this.grbGuncelle.Controls.Add(this.txtAdGuncelle);
            this.grbGuncelle.Controls.Add(this.lblAdresGuncelle);
            this.grbGuncelle.Controls.Add(this.lblTelefongucelle);
            this.grbGuncelle.Controls.Add(this.lblSoyadGuncelle);
            this.grbGuncelle.Controls.Add(this.lblAdguncelle);
            this.grbGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbGuncelle.Location = new System.Drawing.Point(351, 12);
            this.grbGuncelle.Name = "grbGuncelle";
            this.grbGuncelle.Size = new System.Drawing.Size(333, 292);
            this.grbGuncelle.TabIndex = 8;
            this.grbGuncelle.TabStop = false;
            this.grbGuncelle.Text = "KİŞİ GÜNCELLE";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(142, 248);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 38);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // rchAdresGuncelle
            // 
            this.rchAdresGuncelle.Location = new System.Drawing.Point(140, 146);
            this.rchAdresGuncelle.Name = "rchAdresGuncelle";
            this.rchAdresGuncelle.Size = new System.Drawing.Size(185, 96);
            this.rchAdresGuncelle.TabIndex = 7;
            this.rchAdresGuncelle.Text = "";
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(245, 248);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(82, 38);
            this.btnİptal.TabIndex = 10;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtTelefonGuncelle
            // 
            this.txtTelefonGuncelle.Location = new System.Drawing.Point(140, 109);
            this.txtTelefonGuncelle.Name = "txtTelefonGuncelle";
            this.txtTelefonGuncelle.Size = new System.Drawing.Size(185, 21);
            this.txtTelefonGuncelle.TabIndex = 6;
            // 
            // txtSoyadGuncelle
            // 
            this.txtSoyadGuncelle.Location = new System.Drawing.Point(140, 72);
            this.txtSoyadGuncelle.Name = "txtSoyadGuncelle";
            this.txtSoyadGuncelle.Size = new System.Drawing.Size(185, 21);
            this.txtSoyadGuncelle.TabIndex = 5;
            // 
            // txtAdGuncelle
            // 
            this.txtAdGuncelle.Location = new System.Drawing.Point(140, 35);
            this.txtAdGuncelle.Name = "txtAdGuncelle";
            this.txtAdGuncelle.Size = new System.Drawing.Size(185, 21);
            this.txtAdGuncelle.TabIndex = 4;
            // 
            // lblAdresGuncelle
            // 
            this.lblAdresGuncelle.AutoSize = true;
            this.lblAdresGuncelle.Location = new System.Drawing.Point(12, 149);
            this.lblAdresGuncelle.Name = "lblAdresGuncelle";
            this.lblAdresGuncelle.Size = new System.Drawing.Size(48, 15);
            this.lblAdresGuncelle.TabIndex = 3;
            this.lblAdresGuncelle.Text = "ADRES";
            // 
            // lblTelefongucelle
            // 
            this.lblTelefongucelle.AutoSize = true;
            this.lblTelefongucelle.Location = new System.Drawing.Point(12, 112);
            this.lblTelefongucelle.Name = "lblTelefongucelle";
            this.lblTelefongucelle.Size = new System.Drawing.Size(62, 15);
            this.lblTelefongucelle.TabIndex = 2;
            this.lblTelefongucelle.Text = "TELEFON";
            // 
            // lblSoyadGuncelle
            // 
            this.lblSoyadGuncelle.AutoSize = true;
            this.lblSoyadGuncelle.Location = new System.Drawing.Point(12, 75);
            this.lblSoyadGuncelle.Name = "lblSoyadGuncelle";
            this.lblSoyadGuncelle.Size = new System.Drawing.Size(47, 15);
            this.lblSoyadGuncelle.TabIndex = 1;
            this.lblSoyadGuncelle.Text = "SOYAD";
            // 
            // lblAdguncelle
            // 
            this.lblAdguncelle.AutoSize = true;
            this.lblAdguncelle.Location = new System.Drawing.Point(12, 38);
            this.lblAdguncelle.Name = "lblAdguncelle";
            this.lblAdguncelle.Size = new System.Drawing.Size(23, 15);
            this.lblAdguncelle.TabIndex = 0;
            this.lblAdguncelle.Text = "AD";
            // 
            // frmKisiEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.grbGuncelle);
            this.Controls.Add(this.listGoruntule);
            this.Controls.Add(this.grbEkle);
            this.Name = "frmKisiEkleGuncelle";
            this.Text = "KİŞİ EKLEME VE GÜNCELLEME";
            this.Load += new System.EventHandler(this.frmKisiEkleGuncelle_Load);
            this.grbEkle.ResumeLayout(false);
            this.grbEkle.PerformLayout();
            this.grbGuncelle.ResumeLayout(false);
            this.grbGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEkle;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ListView listGoruntule;
        private System.Windows.Forms.GroupBox grbGuncelle;
        private System.Windows.Forms.RichTextBox rchAdresGuncelle;
        private System.Windows.Forms.TextBox txtTelefonGuncelle;
        private System.Windows.Forms.TextBox txtSoyadGuncelle;
        private System.Windows.Forms.TextBox txtAdGuncelle;
        private System.Windows.Forms.Label lblAdresGuncelle;
        private System.Windows.Forms.Label lblTelefongucelle;
        private System.Windows.Forms.Label lblSoyadGuncelle;
        private System.Windows.Forms.Label lblAdguncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.ColumnHeader columnAdSoyad;
        private System.Windows.Forms.ColumnHeader columnTelefon;
    }
}

