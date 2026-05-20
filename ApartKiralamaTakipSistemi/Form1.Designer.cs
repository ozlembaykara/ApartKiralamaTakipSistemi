namespace ApartKiralamaTakipSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.grpKiraci = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSureGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAylikKira = new System.Windows.Forms.TextBox();
            this.lblAylikKira = new System.Windows.Forms.Label();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBitis = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.txtDaireNo = new System.Windows.Forms.TextBox();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.txtKiraciAdi = new System.Windows.Forms.TextBox();
            this.lblKiraciAdi = new System.Windows.Forms.Label();
            this.grpOdeme = new System.Windows.Forms.GroupBox();
            this.btnOdemeEkle = new System.Windows.Forms.Button();
            this.txtOdeme = new System.Windows.Forms.TextBox();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.dgvKiralama = new System.Windows.Forms.DataGridView();
            this.dgvOdeme = new System.Windows.Forms.DataGridView();
            this.lblKiralamaListe = new System.Windows.Forms.Label();
            this.lblOdemeListe = new System.Windows.Forms.Label();
            this.lblOzet = new System.Windows.Forms.Label();
            this.lblBosDaireler = new System.Windows.Forms.Label();
            this.grpKiraci.SuspendLayout();
            this.grpOdeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1184, 60);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "APART KİRALAMA VE DOLULUK TAKİP SİSTEMİ";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpKiraci
            // 
            this.grpKiraci.Controls.Add(this.btnTemizle);
            this.grpKiraci.Controls.Add(this.btnSureGuncelle);
            this.grpKiraci.Controls.Add(this.btnSil);
            this.grpKiraci.Controls.Add(this.btnEkle);
            this.grpKiraci.Controls.Add(this.txtAylikKira);
            this.grpKiraci.Controls.Add(this.lblAylikKira);
            this.grpKiraci.Controls.Add(this.dtBitis);
            this.grpKiraci.Controls.Add(this.lblBitis);
            this.grpKiraci.Controls.Add(this.dtBaslangic);
            this.grpKiraci.Controls.Add(this.lblBaslangic);
            this.grpKiraci.Controls.Add(this.txtDaireNo);
            this.grpKiraci.Controls.Add(this.lblDaireNo);
            this.grpKiraci.Controls.Add(this.txtKiraciAdi);
            this.grpKiraci.Controls.Add(this.lblKiraciAdi);
            this.grpKiraci.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpKiraci.Location = new System.Drawing.Point(12, 75);
            this.grpKiraci.Name = "grpKiraci";
            this.grpKiraci.Size = new System.Drawing.Size(560, 220);
            this.grpKiraci.TabIndex = 1;
            this.grpKiraci.TabStop = false;
            this.grpKiraci.Text = "Kiracı ve Kiralama İşlemleri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(420, 165);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(110, 35);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSureGuncelle
            // 
            this.btnSureGuncelle.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnSureGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSureGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSureGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnSureGuncelle.Location = new System.Drawing.Point(270, 165);
            this.btnSureGuncelle.Name = "btnSureGuncelle";
            this.btnSureGuncelle.Size = new System.Drawing.Size(140, 35);
            this.btnSureGuncelle.TabIndex = 12;
            this.btnSureGuncelle.Text = "Süre Güncelle";
            this.btnSureGuncelle.UseVisualStyleBackColor = false;
            this.btnSureGuncelle.Click += new System.EventHandler(this.btnSureGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(145, 165);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 35);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Kiracı Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(20, 165);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 35);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Kiracı Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAylikKira
            // 
            this.txtAylikKira.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAylikKira.Location = new System.Drawing.Point(125, 116);
            this.txtAylikKira.Name = "txtAylikKira";
            this.txtAylikKira.Size = new System.Drawing.Size(150, 27);
            this.txtAylikKira.TabIndex = 9;
            // 
            // lblAylikKira
            // 
            this.lblAylikKira.AutoSize = true;
            this.lblAylikKira.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAylikKira.Location = new System.Drawing.Point(20, 120);
            this.lblAylikKira.Name = "lblAylikKira";
            this.lblAylikKira.Size = new System.Drawing.Size(72, 20);
            this.lblAylikKira.TabIndex = 8;
            this.lblAylikKira.Text = "Aylık Kira:";
            // 
            // dtBitis
            // 
            this.dtBitis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(390, 74);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(140, 27);
            this.dtBitis.TabIndex = 7;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBitis.Location = new System.Drawing.Point(300, 78);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(42, 20);
            this.lblBitis.TabIndex = 6;
            this.lblBitis.Text = "Bitiş:";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(125, 74);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(150, 27);
            this.dtBaslangic.TabIndex = 5;
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBaslangic.Location = new System.Drawing.Point(20, 78);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(76, 20);
            this.lblBaslangic.TabIndex = 4;
            this.lblBaslangic.Text = "Başlangıç:";
            // 
            // txtDaireNo
            // 
            this.txtDaireNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDaireNo.Location = new System.Drawing.Point(390, 32);
            this.txtDaireNo.Name = "txtDaireNo";
            this.txtDaireNo.Size = new System.Drawing.Size(140, 27);
            this.txtDaireNo.TabIndex = 3;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDaireNo.Location = new System.Drawing.Point(300, 35);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(70, 20);
            this.lblDaireNo.TabIndex = 2;
            this.lblDaireNo.Text = "Daire No:";
            // 
            // txtKiraciAdi
            // 
            this.txtKiraciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKiraciAdi.Location = new System.Drawing.Point(125, 32);
            this.txtKiraciAdi.Name = "txtKiraciAdi";
            this.txtKiraciAdi.Size = new System.Drawing.Size(150, 27);
            this.txtKiraciAdi.TabIndex = 1;
            // 
            // lblKiraciAdi
            // 
            this.lblKiraciAdi.AutoSize = true;
            this.lblKiraciAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKiraciAdi.Location = new System.Drawing.Point(20, 35);
            this.lblKiraciAdi.Name = "lblKiraciAdi";
            this.lblKiraciAdi.Size = new System.Drawing.Size(67, 20);
            this.lblKiraciAdi.TabIndex = 0;
            this.lblKiraciAdi.Text = "Kiracı Adı:";
            // 
            // grpOdeme
            // 
            this.grpOdeme.Controls.Add(this.btnOdemeEkle);
            this.grpOdeme.Controls.Add(this.txtOdeme);
            this.grpOdeme.Controls.Add(this.lblOdeme);
            this.grpOdeme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpOdeme.Location = new System.Drawing.Point(590, 75);
            this.grpOdeme.Name = "grpOdeme";
            this.grpOdeme.Size = new System.Drawing.Size(582, 100);
            this.grpOdeme.TabIndex = 2;
            this.grpOdeme.TabStop = false;
            this.grpOdeme.Text = "Ödeme İşlemleri";
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnOdemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOdemeEkle.ForeColor = System.Drawing.Color.White;
            this.btnOdemeEkle.Location = new System.Drawing.Point(320, 34);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(150, 35);
            this.btnOdemeEkle.TabIndex = 2;
            this.btnOdemeEkle.Text = "Ödeme Ekle";
            this.btnOdemeEkle.UseVisualStyleBackColor = false;
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // txtOdeme
            // 
            this.txtOdeme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOdeme.Location = new System.Drawing.Point(130, 39);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.Size = new System.Drawing.Size(170, 27);
            this.txtOdeme.TabIndex = 1;
            // 
            // lblOdeme
            // 
            this.lblOdeme.AutoSize = true;
            this.lblOdeme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOdeme.Location = new System.Drawing.Point(20, 42);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(95, 20);
            this.lblOdeme.TabIndex = 0;
            this.lblOdeme.Text = "Ödeme Tutarı:";
            // 
            // dgvKiralama
            // 
            this.dgvKiralama.AllowUserToAddRows = false;
            this.dgvKiralama.AllowUserToDeleteRows = false;
            this.dgvKiralama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKiralama.BackgroundColor = System.Drawing.Color.White;
            this.dgvKiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralama.Location = new System.Drawing.Point(12, 345);
            this.dgvKiralama.MultiSelect = false;
            this.dgvKiralama.Name = "dgvKiralama";
            this.dgvKiralama.ReadOnly = true;
            this.dgvKiralama.RowHeadersWidth = 51;
            this.dgvKiralama.RowTemplate.Height = 24;
            this.dgvKiralama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiralama.Size = new System.Drawing.Size(1160, 210);
            this.dgvKiralama.TabIndex = 6;
            // 
            // dgvOdeme
            // 
            this.dgvOdeme.AllowUserToAddRows = false;
            this.dgvOdeme.AllowUserToDeleteRows = false;
            this.dgvOdeme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdeme.BackgroundColor = System.Drawing.Color.White;
            this.dgvOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdeme.Location = new System.Drawing.Point(12, 600);
            this.dgvOdeme.MultiSelect = false;
            this.dgvOdeme.Name = "dgvOdeme";
            this.dgvOdeme.ReadOnly = true;
            this.dgvOdeme.RowHeadersWidth = 51;
            this.dgvOdeme.RowTemplate.Height = 24;
            this.dgvOdeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdeme.Size = new System.Drawing.Size(1160, 120);
            this.dgvOdeme.TabIndex = 8;
            // 
            // lblKiralamaListe
            // 
            this.lblKiralamaListe.AutoSize = true;
            this.lblKiralamaListe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblKiralamaListe.Location = new System.Drawing.Point(12, 315);
            this.lblKiralamaListe.Name = "lblKiralamaListe";
            this.lblKiralamaListe.Size = new System.Drawing.Size(218, 25);
            this.lblKiralamaListe.TabIndex = 5;
            this.lblKiralamaListe.Text = "Kiralama Bilgileri Listesi";
            // 
            // lblOdemeListe
            // 
            this.lblOdemeListe.AutoSize = true;
            this.lblOdemeListe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOdemeListe.Location = new System.Drawing.Point(12, 570);
            this.lblOdemeListe.Name = "lblOdemeListe";
            this.lblOdemeListe.Size = new System.Drawing.Size(201, 25);
            this.lblOdemeListe.TabIndex = 7;
            this.lblOdemeListe.Text = "Ödeme Bilgileri Listesi";
            // 
            // lblOzet
            // 
            this.lblOzet.BackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.lblOzet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOzet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOzet.Location = new System.Drawing.Point(590, 190);
            this.lblOzet.Name = "lblOzet";
            this.lblOzet.Size = new System.Drawing.Size(582, 45);
            this.lblOzet.TabIndex = 3;
            this.lblOzet.Text = "Özet";
            this.lblOzet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBosDaireler
            // 
            this.lblBosDaireler.BackColor = System.Drawing.Color.FromArgb(220, 252, 231);
            this.lblBosDaireler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBosDaireler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBosDaireler.Location = new System.Drawing.Point(590, 250);
            this.lblBosDaireler.Name = "lblBosDaireler";
            this.lblBosDaireler.Size = new System.Drawing.Size(582, 45);
            this.lblBosDaireler.TabIndex = 4;
            this.lblBosDaireler.Text = "Boş Daireler";
            this.lblBosDaireler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1184, 735);
            this.Controls.Add(this.dgvOdeme);
            this.Controls.Add(this.lblOdemeListe);
            this.Controls.Add(this.dgvKiralama);
            this.Controls.Add(this.lblKiralamaListe);
            this.Controls.Add(this.lblBosDaireler);
            this.Controls.Add(this.lblOzet);
            this.Controls.Add(this.grpOdeme);
            this.Controls.Add(this.grpKiraci);
            this.Controls.Add(this.lblBaslik);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apart Takip Sistemi";
            this.grpKiraci.ResumeLayout(false);
            this.grpKiraci.PerformLayout();
            this.grpOdeme.ResumeLayout(false);
            this.grpOdeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox grpKiraci;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSureGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAylikKira;
        private System.Windows.Forms.Label lblAylikKira;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.TextBox txtDaireNo;
        private System.Windows.Forms.Label lblDaireNo;
        private System.Windows.Forms.TextBox txtKiraciAdi;
        private System.Windows.Forms.Label lblKiraciAdi;
        private System.Windows.Forms.GroupBox grpOdeme;
        private System.Windows.Forms.Button btnOdemeEkle;
        private System.Windows.Forms.TextBox txtOdeme;
        private System.Windows.Forms.Label lblOdeme;
        private System.Windows.Forms.DataGridView dgvKiralama;
        private System.Windows.Forms.DataGridView dgvOdeme;
        private System.Windows.Forms.Label lblKiralamaListe;
        private System.Windows.Forms.Label lblOdemeListe;
        private System.Windows.Forms.Label lblOzet;
        private System.Windows.Forms.Label lblBosDaireler;
    }
}