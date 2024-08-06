using patikakutuphane;

kitap kitap1 = new kitap();

kitap1.adi = "Adı Aylin";
kitap1.yazaradi = "Ayşe";
kitap1.soyadi = "Kulin";
kitap1.sayfasayisi = 698;
kitap1.yayinevi = "Remzi Yayınevi";

kitap kitap2 = new kitap("Dönüşüm", "Franz ", "Kafka", 598, "Can Yayınevi");

Console.WriteLine(kitap1);
Console.WriteLine(kitap2);
