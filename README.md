# Finance App - Finansal Takip ve Yatırım Platformu

Finance App, kripto para ve hisse senedi yatırımlarını takip etmek için geliştirilmiş kapsamlı bir masaüstü finansal yönetim platformudur. C# .NET 8.0 Windows Forms teknolojisi ile geliştirilmiş bu uygulama, modern bir kullanıcı arayüzü ve gerçek zamanlı piyasa verileri sunar.

## 📖 Proje Hakkında

Bu proje, **Marmara Üniversitesi - Nesne Yönelimli Programlama Projesi** kapsamında geliştirilmiştir. Finansal okuryazarlık ve yatırım kültürünün geliştirilmesi amacıyla tasarlanan bu platform, kullanıcıların kripto para ve hisse senedi piyasalarını takip etmelerine, yatırım yapmalarına ve portföylerini yönetmelerine olanak tanır.

Platform aşağıdaki temel özellikleri sunar:
- **Gerçek Zamanlı Piyasa Verileri**: CoinGecko ve Yahoo Finance API entegrasyonu
- **Portföy Yönetimi**: Kripto para ve hisse senedi yatırımlarının takibi
- **Güvenli İşlemler**: Kullanıcı kimlik doğrulama ve cüzdan sistemi
- **İşlem Geçmişi**: Tüm alım-satım işlemlerinin detaylı kaydı

## 🛠️ Teknoloji Stack

- **Framework**: .NET 8.0
- **UI Framework**: Windows Forms
- **Veritabanı**: SQL Server
- **Dil**: C#
- **API Entegrasyonları**: 
  - CoinGecko API (Kripto para verileri)
  - Yahoo Finance API (Hisse senedi verileri)
- **Hedef Platform**: Windows
- **Paket Yöneticisi**: NuGet

## 📦 Bağımlılıklar

- **Newtonsoft.Json** (13.0.3) - JSON verilerinin işlenmesi
- **RestSharp** (106.15.0) - HTTP API istekleri
- **System.Data.SqlClient** (4.8.6) - SQL Server bağlantısı
- **YahooFinanceApi** (2.3.3) - Hisse senedi verilerinin alınması

## 📋 Özellikler

### 🔐 Kullanıcı Yönetimi
- Güvenli kullanıcı kayıt ve giriş sistemi
- Otomatik cüzdan adresi oluşturma
- Şifre yönetimi ve güncelleme
- Kullanıcı profil bilgilerinin düzenlenmesi
- İletişim bilgileri yönetimi

### 💰 Finansal İşlemler
- **Bakiye Yönetimi**: Kullanıcı hesap bakiyesi takibi
- **Para Transferi**: Hesaba para yükleme işlemleri
- **İşlem Geçmişi**: Tüm finansal işlemlerin detaylı kaydı
- **Güvenli Ödeme**: Veritabanı tabanlı güvenli işlem sistemi

### 🪙 Kripto Para Özellikleri
- **Piyasa Takibi**: 250+ kripto paranın anlık fiyat bilgileri
- **Kripto Alımı**: Bakiye ile kripto para satın alma
- **Arama Fonksiyonu**: Kripto paralar arasında hızlı arama
- **Fiyat Güncelleme**: Gerçek zamanlı piyasa verileri
- **Portföy İzleme**: Sahip olunan kripto paraların takibi

### 📈 Hisse Senedi Özellikleri
- **NASDAQ Hisseleri**: 100+ büyük şirketin hisse senedi verileri
- **Hisse Alımı**: Bakiye ile hisse senedi satın alma
- **Şirket Bilgileri**: Şirket adları ve ticker sembolleri
- **Kapanış Fiyatları**: Güncel hisse senedi fiyatları
- **Portföy Yönetimi**: Sahip olunan hisselerin takibi

### 📊 Portföy Yönetimi
- **Genel Portföy Görünümü**: Tüm yatırımların tek ekranda takibi
- **İşlem Detayları**: Her işlemin tarih, tutar ve tür bilgileri
- **Varlık Analizi**: Kripto para ve hisse senedi dağılımı
- **Performans Takibi**: Yatırım geçmişi ve karlılık analizi

## 🏗️ Proje Yapısı

### Ana Dosyalar
```
Finance_App/
├── Program.cs                 # Ana giriş noktası
├── Finance_App.csproj        # Proje konfigürasyonu
├── DatabaseManager.cs        # Veritabanı işlemleri yöneticisi
├── CryptoManager.cs          # Kripto para işlemleri yöneticisi
├── StocksManager.cs          # Hisse senedi işlemleri yöneticisi
├── ThemeColor.cs             # Tema renk yönetimi
├── Properties/               # Proje kaynakları
│   ├── Resources.Designer.cs
│   └── Resources.resx
```

### Ana Formlar
```
├── FrmLogin.cs               # Kullanıcı giriş ekranı
├── FrmRegister.cs            # Yeni kullanıcı kayıt ekranı
├── FrmHub.cs                 # Ana dashboard/hub ekranı
├── FrmCrypto.cs              # Kripto para ana paneli
├── FrmStocks.cs              # Hisse senedi ana paneli
└── FrmSettings.cs            # Kullanıcı ayarları
```

### Alt Formlar (Forms/)
```
├── FormCryptoMarket.cs       # Kripto para piyasası
├── FormStocksMarket.cs       # Hisse senedi piyasası
├── FormPortfolio.cs          # Portföy yönetimi
├── FormTransfer.cs           # Para transfer işlemleri
└── FormProfile.cs            # Kullanıcı profil yönetimi
```

### Veritabanı Yapısı
```
├── Users Tablosu
│   ├── username (PK)         # Kullanıcı adı
│   ├── password              # Şifre
│   ├── wallet_address        # Cüzdan adresi
│   ├── contact_address       # İletişim adresi
│   └── balance               # Hesap bakiyesi
│
└── Transactions Tablosu
    ├── wallet_address        # Cüzdan adresi (FK)
    ├── transaction_type      # İşlem türü (crypto/stocks)
    ├── price                 # İşlem fiyatı
    ├── amount                # İşlem miktarı
    └── name                  # Varlık adı
```

## 🔧 Kurulum

### Gereksinimler
- Windows 10/11
- .NET 8.0 Runtime
- SQL Server (Express sürümü yeterli)
- Visual Studio 2022 (geliştirme için)
- İnternet bağlantısı (API verileri için)

### Kurulum Adımları

1. **Projeyi klonlayın:**
   ```bash
   git clone [repository-url]
   cd Finance_App
   ```

2. **Veritabanını hazırlayın:**
   - SQL Server'da `FinanceApp` adında bir veritabanı oluşturun
   - Gerekli tabloları oluşturun:
   ```sql
   -- Users tablosu
   CREATE TABLE Users (
       username NVARCHAR(50) PRIMARY KEY,
       password NVARCHAR(255) NOT NULL,
       wallet_address NVARCHAR(100) UNIQUE NOT NULL,
       contact_address NVARCHAR(255),
       balance DECIMAL(18,2) DEFAULT 0
   );

   -- Transactions tablosu
   CREATE TABLE Transactions (
       id INT IDENTITY(1,1) PRIMARY KEY,
       wallet_address NVARCHAR(100) NOT NULL,
       transaction_type NVARCHAR(20) NOT NULL,
       price DECIMAL(18,2) NOT NULL,
       amount DECIMAL(18,6) NOT NULL,
       name NVARCHAR(100) NOT NULL,
       transaction_date DATETIME DEFAULT GETDATE(),
       FOREIGN KEY (wallet_address) REFERENCES Users(wallet_address)
   );
   ```

3. **Bağlantı dizisini güncelleyin:**
   - `DatabaseManager.cs` dosyasındaki `connectionString` değişkenini kendi SQL Server ayarlarınıza göre düzenleyin:
   ```csharp
   private string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=FinanceApp;Integrated Security=True;";
   ```

4. **Gerekli paketleri yükleyin:**
   ```bash
   dotnet restore
   ```

5. **Projeyi derleyin ve çalıştırın:**
   ```bash
   dotnet build
   dotnet run
   ```

## 📱 Uygulama Görselleri

### Giriş Ekranı

### Kayıt Ekranı

### Stocks Ekranı

### Kripto Ekranı


## 🎯 Kullanım

### İlk Kullanım
1. Uygulamayı başlatın
2. "Register" butonuna tıklayarak yeni hesap oluşturun
3. Kullanıcı adı ve güvenli bir şifre belirleyin
4. Sistem otomatik olarak size bir cüzdan adresi oluşturacak
5. Giriş yaparak platform özelliklerini kullanmaya başlayın

### Kripto Para İşlemleri
1. Ana hub'dan "Crypto" bölümünü seçin
2. "Market" sekmesinden kripto para fiyatlarını görüntüleyin
3. Satın almak istediğiniz kripto parayı seçin
4. Miktarı belirleyerek satın alma işlemini tamamlayın
5. "Portfolio" sekmesinden sahip olduğunuz kripto paraları görüntüleyin

### Hisse Senedi İşlemleri
1. Ana hub'dan "Stocks" bölümünü seçin
2. "Market" sekmesinden NASDAQ hisselerini inceleyin
3. Yatırım yapmak istediğiniz şirketi seçin
4. Hisse adedi belirleyerek satın alma işlemini gerçekleştirin
5. "Portfolio" sekmesinden hisse portföyünüzü takip edin

### Portföy Yönetimi
1. "Portfolio" bölümünden tüm yatırımlarınızı görüntüleyin
2. Kripto para ve hisse senedi dağılımınızı analiz edin
3. İşlem geçmişinizi detaylı olarak inceleyin
4. Performans metriklerinizi takip edin

## 🔒 Güvenlik

- **Güvenli Kimlik Doğrulama**: Kullanıcı bilgileri güvenli şekilde saklanır
- **SQL Injection Koruması**: Parameterized query kullanımı
- **Cüzdan Güvenliği**: Benzersiz cüzdan adresleri oluşturma
- **İşlem Güvenliği**: Tüm finansal işlemlerin veritabanında güvenli kaydı
- **Oturum Yönetimi**: Güvenli giriş/çıkış işlemleri

## 🌐 API Entegrasyonları

### CoinGecko API
- 250+ kripto paranın gerçek zamanlı fiyat bilgileri
- Market kapitalizasyonu sıralaması
- Fiyat güncellemeleri ve piyasa verileri

### Yahoo Finance API
- NASDAQ'ta işlem gören büyük şirketlerin hisse senedi verileri
- Güncel kapanış fiyatları
- Şirket bilgileri ve ticker sembolleri

## 📊 Veritabanı Yönetimi

### DatabaseManager Sınıfı
- Kullanıcı kayıt ve giriş işlemleri
- Bakiye güncelleme ve yönetimi
- İşlem geçmişi kaydı
- Güvenli veritabanı bağlantıları

### Veri Modelleri
- **UserData**: Kullanıcı bilgileri ve cüzdan verileri
- **Transactions**: İşlem detayları ve geçmiş kayıtları

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir ve Marmara Üniversitesi Nesne Yönelimli Programlama dersi kapsamında hazırlanmıştır.

## 📞 İletişim

Proje ile ilgili sorularınız için issue açabilir veya doğrudan iletişime geçebilirsiniz.