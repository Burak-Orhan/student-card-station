# Student Card Station
Bu proje, öğrenci kimlik kartı yönetimi amacıyla geliştirilmiş bir Windows uygulamasıdır.  
Solution adı: `student‐card‐station.sln` (C# ile geliştirilmiştir)

## İçindekiler  
1. Hakkında  
2. Özellikler  
3. Gereksinimler  
4. Kurulum ve Başlatma  
5. Kullanım  
6. Mimari ve Teknolojiler  
7. Katkıda Bulunma  

## 1. Hakkında  
Student Card Station, öğrencilerin kimlik kartı işlemlerini yönetebilmek için geliştirilmiş bir masaüstü uygulamasıdır.<br>
Kullanıcıların öğrenci kartı bilgilerini görüntülemesi, kart durumu takibi ve yönetici yetkilerinin olduğu bir yapı sunmayı hedefler.

## 2. Özellikler  
- Öğrenci kartlarının listelenmesi, detaylarının görüntülenmesi.  
- Yeni öğrenci kartı ekleme, düzenleme ve silme işlemleri.  
- Yönetici kullanıcılar için onay mekanizmaları.  
- Basit ve anlaşılır arayüz ile masaüstü ortamında kullanım.

## 3. Gereksinimler  
- Windows işletim sistemi (örneğin Windows 10 veya üzeri)  
- .NET Framework veya .NET Core sürümü (.NET 8 veya üzeri)  
- Visual Studio (veya benzeri IDE)  
- Veritabanı: Yerel veya uzak bir SQL Server (MySql)  
- Gerekli NuGet paketleri

## 4. Kurulum ve Başlatma  
1. GitHub üzerinden repoyu klonlayın:  
   ```bash
   git clone https://github.com/Burak-Orhan/student-card-station.git
2. Visual Studio’da `student‐card‐station.sln` dosyasını açın.
3. Gerekli NuGet paketlerini restore edin.
4. Veritabanı bağlantı ayarlarını `Helper/DBConnection.cs` dosyasından düzenleyin.
5. Projeyi çalıştırın – uygulama giriş ekranı açılacaktır.

## 5. Kullanım 
- Uygulama açıldığında giriş ekranı görüntülenir (Önce kayıt olmanız gerekmektedir).
- Ana formdan mevcut öğrenciler listelenir ve yazdırılabilir.
- “Yeni Öğrenci Ekle” seçeneği ile yeni öğrenci kartı tanımlanabilir.
- Düzenlenecek karta tıklanarak “Öğrenci Güncelle” ya da “Öğrenci Sil” işlemi yapılabilir.

## 6. Mimari ve Teknolojiler
- Geliştirme dili: C#
- Uygulama türü: Masaüstü (Windows Forms)
- Veritabanı: MySql
- Çözüm dosyası: student-card-station.sln
- Lisans: MIT 

## 7. Katkıda Bulunma
- Depoyu Fork’layabilirsiniz
- Yeni bir branch oluşturabilirsiniz `(git checkout -b yeni-özellik)`
- Değişikliklerinizi commit edebilirsiniz `(git commit -m 'Yeni özellik eklendi')`
- Branch’ınızı push’layabilirsiniz `(git push origin yeni-özellik)`
- Pull request gönderebilirsiniz
