using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager // okunurluğu artırmak için I harfi ile başlar.
    {
        // interfaceler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        // tüm krediler hesaplama işlemini kullanır ama herbir kredi için kullanılan değerler ve kurallar 
        // farklı olduğu için bir class ve içinde aynı fonksiyon ile kullanılamaz.
        // bu yüzden class'ı interface olarak kullanırız.
        // interfaceden miras aldıkları için içerideki tüm fonksiyonları içermelidirler.
        void Hesapla();
        void CiktiAl();
    }
}
