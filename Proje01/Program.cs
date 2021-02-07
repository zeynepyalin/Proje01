using System;

namespace Proje01
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            // ürün classından array oluşturuldu
            Urun[] urunler = new Urun[] { urun1,urun2 };

            // Urun veri tipi(var da yazılabilir, kabul eder)
            // urun urunler arrayindeki elemanları temsil eder, ne isim versek olur.
            foreach (Urun urun in urunler) 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("----------Metotlar----------");

            // instance / örnek oluşturma
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80,8);

        }
    }
}
