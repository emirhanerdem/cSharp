
## Ödev 1 : 
Bir halı yıkama fabrikasında müşterilerden halılar günlük olarak alınmakta, fabrikada yıkanmakta ve birkaç gün sonra teslim edilmektedir. Sistem aşağıdaki ihtiyaçlara göre C# programlama dili kullanılarak nesne tabanlı (object-oriented) prensiplere uygun biçimde geliştirilecektir:
## Müşteri Bilgileri:
Her müşterinin adı, soyadı, telefon numarası ve adres bilgileri tutulmalıdır.
### Halı Bilgileri:
Her halının metrekare bilgisi, alındığı tarih, tahmini teslim tarihi ve yıkama durumu (Yıkamada / Teslim Edildi) saklanmalıdır. Halının ücreti metrekare başına 20 TL olarak otomatik hesaplanmalıdır.
### Durum Takibi:
Halıların yıkamada mı yoksa teslim edilmiş mi olduğu GUI üzerinden takip edilebilmelidir.
### İşlevler:
Uygulama aşağıdaki işlemleri desteklemelidir:
- Yeni müşteri kaydı ekleme
- Seçilen müşteriye halı kaydı ekleme
- Yıkamada olan halıları listeleme
- Teslim edilen halıları listeleme
- Halının durumunu “Teslim Edildi” olarak güncelleme
### Veri Yapısı:
Veriler uygun sınıf yapıları ile tutulmalı ve tüm işlemler nesne tabanlı prensiplere uygun olarak yapılmalıdır.
### Kullanıcı Arayüzü:
Windows Forms (GUI) ile kullanıcıların müşteri ekleyebileceği, halı takibi yapabileceği, ve halı durumlarını güncelleyebileceği bir arayüz tasarlanmalıdır.
--
## Ödev 2 :
Özelleştirilmiş Bir ArrayList Sınıfı (MyArrayList) Tasarlayınız.
Bu sınıf:
- İçerisinde object[] tipinde bir dizi kullanmalı ve kapasitesi gerektiğinde dinamik olarak artırılmalıdır.
- Başlangıç kapasitesi varsayılan olarak 4 olmalıdır.
  
Temel Fonksiyonlar Aşağıdaki Şekilde Gerçeklenmelidir:

- Add(object item): Yeni bir öğe sona eklenir.
- Insert(int index, object item): Belirtilen indekse bir öğe eklenir, diğer öğeler sağa kaydırılır.
- RemoveAt(int index): Belirtilen indeksdeki öğe kaldırılır.
- Get(int index): Belirtilen indeksteki öğeyi döndürür.
- Count: Listede bulunan öğe sayısını döndürür.
- ToString(): Listedeki öğeleri virgül ile ayrılmış bir biçimde döndürür.
  
Kapsülleme (Encapsulation) ilkesine dikkat edilmelidir.
