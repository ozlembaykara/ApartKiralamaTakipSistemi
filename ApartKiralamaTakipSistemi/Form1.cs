using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ApartKiralamaTakipSistemi
{
    public partial class Form1 : Form
    {
        DataTable kiralamaTablosu = new DataTable();
        DataTable odemeTablosu = new DataTable();

        List<string> tumDaireler = new List<string>()
        {
            "Daire 1", "Daire 2", "Daire 3", "Daire 4", "Daire 5",
            "Daire 6", "Daire 7", "Daire 8", "Daire 9", "Daire 10"
        };

        public Form1()
        {
            InitializeComponent();
            TabloHazirla();
            IlkAyarlar();
        }

        private void IlkAyarlar()
        {
            dtBaslangic.Value = DateTime.Today;
            dtBitis.Value = DateTime.Today.AddMonths(1);
            OzetGuncelle();
        }

        private void TabloHazirla()
        {
            kiralamaTablosu.Columns.Add("Kiracı Adı", typeof(string));
            kiralamaTablosu.Columns.Add("Daire No", typeof(string));
            kiralamaTablosu.Columns.Add("Başlangıç", typeof(DateTime));
            kiralamaTablosu.Columns.Add("Bitiş", typeof(DateTime));
            kiralamaTablosu.Columns.Add("Süre (Gün)", typeof(int));
            kiralamaTablosu.Columns.Add("Aylık Kira", typeof(decimal));
            kiralamaTablosu.Columns.Add("Toplam Borç", typeof(decimal));
            kiralamaTablosu.Columns.Add("Ödenen", typeof(decimal));
            kiralamaTablosu.Columns.Add("Kalan Borç", typeof(decimal));
            kiralamaTablosu.Columns.Add("Kalan Gün", typeof(int));
            kiralamaTablosu.Columns.Add("Durum", typeof(string));

            dgvKiralama.DataSource = kiralamaTablosu;

            odemeTablosu.Columns.Add("Tarih", typeof(DateTime));
            odemeTablosu.Columns.Add("Kiracı Adı", typeof(string));
            odemeTablosu.Columns.Add("Daire No", typeof(string));
            odemeTablosu.Columns.Add("Ödeme Tutarı", typeof(decimal));
            odemeTablosu.Columns.Add("Para Üstü", typeof(decimal));

            dgvOdeme.DataSource = odemeTablosu;

            KolonGorunumleriniAyarla();
        }

        private void KolonGorunumleriniAyarla()
        {
            dgvKiralama.Columns["Başlangıç"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvKiralama.Columns["Bitiş"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvKiralama.Columns["Aylık Kira"].DefaultCellStyle.Format = "N2";
            dgvKiralama.Columns["Toplam Borç"].DefaultCellStyle.Format = "N2";
            dgvKiralama.Columns["Ödenen"].DefaultCellStyle.Format = "N2";
            dgvKiralama.Columns["Kalan Borç"].DefaultCellStyle.Format = "N2";

            dgvOdeme.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvOdeme.Columns["Ödeme Tutarı"].DefaultCellStyle.Format = "N2";
            dgvOdeme.Columns["Para Üstü"].DefaultCellStyle.Format = "N2";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KiralamaSureleriniGuncelle(false);

            string kiraciAdi = txtKiraciAdi.Text.Trim();
            string daireNo = DaireAdiniDuzenle(txtDaireNo.Text.Trim());

            if (kiraciAdi == "" || daireNo == "" || txtAylikKira.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen kiracı adı, daire no ve aylık kira alanlarını doldurunuz.");
                return;
            }

            decimal aylikKira;

            if (!decimal.TryParse(txtAylikKira.Text.Trim(), out aylikKira))
            {
                MessageBox.Show("Aylık kira alanına sadece sayı giriniz.");
                return;
            }

            if (aylikKira <= 0)
            {
                MessageBox.Show("Aylık kira 0'dan büyük olmalıdır.");
                return;
            }

            DateTime baslangic = dtBaslangic.Value.Date;
            DateTime bitis = dtBitis.Value.Date;

            if (bitis <= baslangic)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalıdır.");
                return;
            }

            if (DaireDoluMu(daireNo))
            {
                MessageBox.Show("Bu daire şu anda dolu görünüyor. Aynı daireye aktif kiracı eklenemez.");
                return;
            }

            int toplamGun = (bitis - baslangic).Days;
            decimal gunlukKira = aylikKira / 30;
            decimal toplamBorc = Math.Round(gunlukKira * toplamGun, 2);

            int kalanGun = (bitis - DateTime.Today).Days;
            if (kalanGun < 0) kalanGun = 0;

            string durum = kalanGun > 0 ? "Aktif" : "Süresi Bitti";

            kiralamaTablosu.Rows.Add(
                kiraciAdi,
                daireNo,
                baslangic,
                bitis,
                toplamGun,
                aylikKira,
                toplamBorc,
                0,
                toplamBorc,
                kalanGun,
                durum
            );

            MessageBox.Show("Kiracı kaydı başarıyla eklendi.");
            Temizle();
            OzetGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKiralama.CurrentRow == null || dgvKiralama.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Lütfen silmek için bir kiracı seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Seçili kiracı kaydını silmek istiyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cevap == DialogResult.Yes)
            {
                DataRowView seciliSatir = dgvKiralama.CurrentRow.DataBoundItem as DataRowView;

                if (seciliSatir != null)
                {
                    seciliSatir.Row.Delete();
                    MessageBox.Show("Kiracı kaydı silindi.");
                    OzetGuncelle();
                }
            }
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            if (dgvKiralama.CurrentRow == null || dgvKiralama.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Lütfen ödeme yapılacak kiracıyı seçiniz.");
                return;
            }

            decimal odemeTutari;

            if (!decimal.TryParse(txtOdeme.Text.Trim(), out odemeTutari))
            {
                MessageBox.Show("Ödeme tutarı alanına sadece sayı giriniz.");
                return;
            }

            if (odemeTutari <= 0)
            {
                MessageBox.Show("Ödeme tutarı 0'dan büyük olmalıdır.");
                return;
            }

            DataRowView seciliSatir = dgvKiralama.CurrentRow.DataBoundItem as DataRowView;
            if (seciliSatir == null)
            {
                MessageBox.Show("Seçili kayıt okunamadı.");
                return;
            }

            DataRow row = seciliSatir.Row;

            string kiraciAdi = row["Kiracı Adı"].ToString();
            string daireNo = row["Daire No"].ToString();

            decimal mevcutOdenen = Convert.ToDecimal(row["Ödenen"]);
            decimal kalanBorc = Convert.ToDecimal(row["Kalan Borç"]);

            if (kalanBorc <= 0)
            {
                MessageBox.Show("Bu kiracının kalan borcu yoktur.");
                return;
            }

            decimal paraUstu = 0;
            decimal borcaYansiyanOdeme = odemeTutari;

            if (odemeTutari > kalanBorc)
            {
                paraUstu = odemeTutari - kalanBorc;
                borcaYansiyanOdeme = kalanBorc;
                kalanBorc = 0;
            }
            else
            {
                kalanBorc -= odemeTutari;
            }

            mevcutOdenen += borcaYansiyanOdeme;

            row["Ödenen"] = mevcutOdenen;
            row["Kalan Borç"] = kalanBorc;

            odemeTablosu.Rows.Add(
                DateTime.Today,
                kiraciAdi,
                daireNo,
                odemeTutari,
                paraUstu
            );

            if (paraUstu > 0)
                MessageBox.Show("Ödeme alındı. Verilmesi gereken para üstü: " + paraUstu.ToString("N2") + " TL");
            else
                MessageBox.Show("Ödeme başarıyla eklendi.");

            txtOdeme.Clear();
            OzetGuncelle();
        }

        private void btnSureGuncelle_Click(object sender, EventArgs e)
        {
            KiralamaSureleriniGuncelle(true);
            OzetGuncelle();
        }

        private void KiralamaSureleriniGuncelle(bool mesajGoster)
        {
            foreach (DataRow row in kiralamaTablosu.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                DateTime bitis = Convert.ToDateTime(row["Bitiş"]);
                int kalanGun = (bitis.Date - DateTime.Today).Days;

                if (kalanGun < 0) kalanGun = 0;

                row["Kalan Gün"] = kalanGun;
                row["Durum"] = kalanGun == 0 ? "Süresi Bitti" : "Aktif";
            }

            if (mesajGoster)
                MessageBox.Show("Kalan süreler güncellendi.");
        }

        private bool DaireDoluMu(string daireNo)
        {
            foreach (DataRow row in kiralamaTablosu.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                string mevcutDaire = row["Daire No"].ToString();
                string durum = row["Durum"].ToString();

                if (mevcutDaire.Equals(daireNo, StringComparison.OrdinalIgnoreCase) && durum == "Aktif")
                    return true;
            }

            return false;
        }

        private string DaireAdiniDuzenle(string daire)
        {
            int daireNumarasi;
            if (int.TryParse(daire, out daireNumarasi))
                return "Daire " + daireNumarasi;

            return daire;
        }

        private void OzetGuncelle()
        {
            int toplamKayit = 0;
            int aktifKayit = 0;
            int suresiBiten = 0;
            decimal toplamKalanBorc = 0;

            List<string> doluDaireler = new List<string>();

            foreach (DataRow row in kiralamaTablosu.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                toplamKayit++;

                string durum = row["Durum"].ToString();

                if (durum == "Aktif")
                {
                    aktifKayit++;
                    doluDaireler.Add(row["Daire No"].ToString());
                }

                if (durum == "Süresi Bitti")
                    suresiBiten++;

                toplamKalanBorc += Convert.ToDecimal(row["Kalan Borç"]);
            }

            lblOzet.Text = "Toplam Kiralama: " + toplamKayit +
                           " | Aktif: " + aktifKayit +
                           " | Süresi Biten: " + suresiBiten +
                           " | Toplam Kalan Borç: " + toplamKalanBorc.ToString("N2") + " TL";

            List<string> bosDaireler = new List<string>();

            foreach (string daire in tumDaireler)
            {
                bool doluMu = false;

                foreach (string doluDaire in doluDaireler)
                {
                    if (doluDaire.Equals(daire, StringComparison.OrdinalIgnoreCase))
                    {
                        doluMu = true;
                        break;
                    }
                }

                if (!doluMu)
                    bosDaireler.Add(daire);
            }

            lblBosDaireler.Text = "Boş Daireler: " + string.Join(", ", bosDaireler);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtKiraciAdi.Clear();
            txtDaireNo.Clear();
            txtAylikKira.Clear();
            txtOdeme.Clear();

            dtBaslangic.Value = DateTime.Today;
            dtBitis.Value = DateTime.Today.AddMonths(1);

            txtKiraciAdi.Focus();
        }
    }
}