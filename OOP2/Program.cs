using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yoo Taeyang
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "970228";
            musteri1.Adi = "Taeyang";
            musteri1.Soyadi = "Yoo";
            musteri1.TcNo = "28021997";

            // SF9
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "161005";
            musteri2.SirketAdi = "FNC Entertainment";
            musteri2.VergiNo = "05102016";

            // bir yerde new ile bir tanımlama yapılmışsa yeni bir referans no alınmış demektir.
            // müşteri classı hem gerçek hem tüzel kişi referansını tutabiliyor.

        }
    }
}
