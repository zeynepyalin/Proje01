using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // method injection : parametreler ile neyi kullanacağını söylemek
        // loglamak için çok çeşit kullanılabileceğinden list şeklinde eklendi.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // herhangi bir kredi türüne göre instance oluşturup ilerlersek diğer kredi türleri de kullandıklarında ilk oluşturulan kredi türü
            // üzerinden yapılmış olacaktı. bunun yerine fonk içinde hepsinin referansının bulunduğu managerin tanımlanması ile parametre verilir.
            // bu sayede hangi kredi türü ile işlem yapılıyorsa onun işlemleri ile devam edilir.
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            // fiyat öğrenmek için bir tane de çok tane de kredi seçimi yapılabilir. onların hepsini bir arada tutabilmek için liste oluşturulur.
            // listenin türü olarak IKrediManager kullanılır.
            foreach (var kredi in krediler)
            {
                // istenilen her kredinin hesabını yap
                kredi.Hesapla();
            }
        }
    }
}
