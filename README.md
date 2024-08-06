# Kitap Kayıt Uygulaması

Bu uygulama, kitap bilgilerini kaydeden basit bir konsol uygulamasıdır. İki tür constructor kullanılarak kitap nesneleri oluşturulmaktadır: parametresiz ve parametreli constructor.

## Kullanılan Teknolojiler

- C#
- .NET Core

## Kurulum

1. Bu projeyi kendi bilgisayarınıza klonlayın:
    ```sh
    git clone https://github.com/kullaniciadi/kitap-kayit-uygulamasi.git
    cd kitap-kayit-uygulamasi
    ```

2. Projeyi derleyip çalıştırmak için .NET Core SDK yüklü olduğundan emin olun.

## Çalıştırma

1. Projeyi derleyin ve çalıştırın:
    ```sh
    dotnet run
    ```

2. Konsolda iki kitap nesnesinin bilgilerini göreceksiniz.

## Kitap Sınıfı

### Özellikler

- `Ad`: Kitabın adı
- `YazarAdi`: Yazarın adı
- `YazarSoyadi`: Yazarın soyadı
- `SayfaSayisi`: Kitabın sayfa sayısı
- `Yayinevi`: Kitabın yayınevi
- `KayitTarihi`: Kitabın kayıt tarihi

### Constructorlar

- **Parametresiz Constructor**: Kitap nesnesini oluşturur ve `KayitTarihi` özelliğini şu anki tarih ve saat olarak ayarlar.
- **Parametreli Constructor**: Kitap nesnesini verilen özelliklerle oluşturur ve `KayitTarihi` özelliğini şu anki tarih ve saat olarak ayarlar.

## Örnek Kullanım

```csharp
// Parametresiz constructor ile kitap nesnesi oluşturma
Kitap kitap1 = new Kitap();
kitap1.Ad = "Adı Aylin";
kitap1.YazarAdi = "Ayşe";
kitap1.YazarSoyadi = "Kulin";
kitap1.SayfaSayisi = 398;
kitap1.Yayinevi = "Remzi Kitabevi";

// Parametreli constructor ile kitap nesnesi oluşturma
Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

// Kitap nesnelerini yazdırma
Console.WriteLine(kitap1);
Console.WriteLine(kitap2);
