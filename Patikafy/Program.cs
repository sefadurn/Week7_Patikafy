using Patikafy;

List<Sarkici> sarkicilar = new List<Sarkici>
{
new Sarkici { AdSoyad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatis = 20 },
new Sarkici { AdSoyad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatis = 10 },
new Sarkici { AdSoyad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatis = 3 },
new Sarkici { AdSoyad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatis = 5 },
new Sarkici { AdSoyad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatis = 3 },
new Sarkici { AdSoyad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatis = 10 },
new Sarkici { AdSoyad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatis = 40 },
new Sarkici { AdSoyad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatis = 7 },
new Sarkici { AdSoyad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatis = 5 },
new Sarkici { AdSoyad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatis = 10 },
new Sarkici { AdSoyad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatis = 2 }
};

var sHarfiİleBaşlayanlar = sarkicilar.Where(x => x.AdSoyad.StartsWith("S"));
foreach(var item in sHarfiİleBaşlayanlar)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------------------------------------------------");

var AlbumSatisi = sarkicilar.Where(x => x.AlbumSatis > 10);
foreach(var item in AlbumSatisi)
{
    Console.WriteLine(item);
}

Console.WriteLine("----------------------------------------------------");

var EnCokAlbumSatanSanatci = sarkicilar.OrderByDescending(x => x.AlbumSatis).First();
{
    Console.WriteLine($"En çok albüm satan sanatçı : {EnCokAlbumSatanSanatci.AdSoyad} - {EnCokAlbumSatanSanatci.AlbumSatis}");
}


Console.WriteLine("------------------------------------------------------");

var EnYeniCikisYapan = sarkicilar.OrderByDescending(x => x.CikisYili).First();
var EnEskiCikisYapan = sarkicilar.OrderBy(x =>x.CikisYili).First();

Console.WriteLine($" En yeni çıkış yapan : {EnYeniCikisYapan.AdSoyad} --> {EnYeniCikisYapan.CikisYili}");
Console.WriteLine($" En eski çıkış yapan : {EnEskiCikisYapan.AdSoyad} --> {EnEskiCikisYapan.CikisYili}");