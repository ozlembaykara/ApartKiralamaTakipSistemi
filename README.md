# ApartKiralamaTakipSistemi

## 📖 Projenin Tanımı
Apart Takip Sistemi, apart, pansiyon, öğrenci apart veya kiralık daire gibi yerlerin kiralama süreçlerini dijital ortamda yönetmek için hazırlanan bir otomasyon sistemidir. Bu sistem sayesinde odaların veya dairelerin doluluk ve boşluk durumu, kiracı bilgileri, kira başlangıç ve bitiş tarihleri, kaç aylık kiralama yapıldığı ve ödeme bilgileri düzenli şekilde takip edilebilmektedir.

## 🎯 Projenin Amacı
Bu projenin temel amacı, apart yönetiminde yaşanan kayıt karışıklığını önlemek ve tüm kiralama süreçlerini tek bir sistem üzerinden kontrol edilebilir hale getirmektir. Sistem sayesinde yönetici; 
* Hangi odanın dolu veya boş olduğunu,
* Hangi kiracının hangi odada kaldığını,
* Kira süresinin ne zaman başladığını ve biteceğini,
* Kiracının kaç aylık sözleşme yaptığını,
* Ödeme durumunu kolayca görüntüleyebilecektir.

## 🛠 Çözdüğü Problemler
Apart ve benzeri konaklama yerlerinde takip işlemleri çoğu zaman defter, not kağıdı veya dağınık tablolar ile yapılmaktadır. Bu proje; boş ve dolu odaların karışması, kira süresinin unutulması, çıkış tarihi yaklaşan kiracıların takip edilememesi, aynı odanın yanlışlıkla tekrar kiraya verilmesi ve ödeme bilgilerinin eksik tutulması gibi sorunları çözerek daha düzenli, hızlı ve güvenilir bir yönetim sağlamayı hedefler.

## ✨ Temel Gereksinimler ve Özellikler
* Kiracı ekleme ve silme.
* Kiralama süresini ve borç bilgisini listeleme.
* Ödeme bilgilerini gösterme.
* Kiralanan dairelerin kalan sürelerini görsel bar grafikler ile gösterme.

## 🗄️ Veri Tabanı Şeması
Sistem için temel olarak 4 ana tablo ve 1 kullanıcı giriş tablosu kullanılmıştır:
1. **Yonetici:** Kullanıcı girişi için yetkili bilgileri.
2. **Kiraci:** Kiracıyı sisteme eklemek, silmek ve kayıtlarını tutmak.
3. **Daire:** Hangi dairenin dolu ya da boş olduğunu göstermek.
4. **Kiralama:** Kiralama süresini, borç bilgisini ve kalan süreyi takip etmek.
5. **Odeme:** Ödeme bilgilerini göstermek ve toplam/kalan borcu hesaplamak.

## 💻 Kurulum ve Kullanım İşlemleri
1. Projeyi bilgisayarınıza klonlayın veya indirin.
2. Visual Studio üzerinden `ApartTakipSistemi.sln` dosyasını açın.
3. Projede kullanılan SQL veritabanı scriptlerini veritabanı sunucunuzda (SQL Server vb.) çalıştırın.
4. `Form1.cs` içerisindeki `connectionString` (bağlantı dizesi) değişkenini kendi yerel veritabanı sunucu ayarlarınıza göre güncelleyin.
5. Projeyi (Start/F5) çalıştırarak apart yönetim işlemlerini test etmeye başlayın.


<img width="1166" height="893" alt="Ekran görüntüsü 2026-05-21 002834" src="https://github.com/user-attachments/assets/6826a389-ca8f-4a34-99d2-5bd3c6e05f2a" />

<img width="1173" height="893" alt="Ekran görüntüsü 2026-05-21 010712" src="https://github.com/user-attachments/assets/12fc2485-b265-4e96-95a9-1247cc9ebf59" />

Hazırlayan:
Münevver Özlem BAYKARA 
2024212014
Yönetim Bilişim Sistemleri 2.Sınıf 
