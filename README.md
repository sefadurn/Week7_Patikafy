Sanatçı Bilgi Listesi - C# Konsol Uygulaması
Bu C# konsol uygulaması, belirli sanatçıların bilgilerini içeren bir liste üzerinde LINQ sorguları kullanarak çeşitli filtreleme ve sıralama işlemleri yapmaktadır.

Özellikler
Adı 'S' harfi ile başlayan sanatçıların listelenmesi

Albüm satışı 10 milyonun üzerinde olan sanatçıların gösterimi

2000 yılı öncesi çıkış yapmış ve pop müzik yapan sanatçıların, çıkış yılına ve isim alfabetiğine göre sıralanması

En çok albüm satan sanatçının bulunması

En yeni ve en eski çıkış yapan sanatçının belirlenmesi

Programın İçeriği
Sanatçı Sınıfı (Sanatci)
AdSoyad (string): Sanatçının adı ve soyadı

MuzikTuru (string): Sanatçının müzik türü

CikisYili (int): Sanatçının müzik kariyerine başladığı yıl

AlbumSatis (int): Sanatçının albüm satış adedi (milyon cinsinden)

İşlem Adımları
sanatcilar listesi oluşturulur ve sanatçı bilgileri tanımlanır.

LINQ sorguları kullanılarak:

Adı 'S' ile başlayan sanatçılar filtrelenir ve listelenir.

Albüm satışı 10 milyondan fazla olan sanatçılar listelenir.

2000 öncesi çıkış yapan ve müzik türü içinde "Pop" geçen sanatçılar, çıkış yılı ve isim sırasına göre sıralanır.

En çok albüm satan sanatçı bulunur.

En yeni ve en eski çıkış yapan sanatçılar bulunur.

Çalıştırma
Projeyi Visual Studio veya tercih ettiğiniz C# geliştirme ortamında açın.

Program.cs dosyasını çalıştırın.

Konsol ekranında sorgu sonuçları listelenecektir.

