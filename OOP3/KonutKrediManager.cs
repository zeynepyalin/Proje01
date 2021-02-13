using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        // miras aldıktan sonra ampule tıklayınca otomatik olarak fonksiyon eklemeyi sağlıyor.
        public void CiktiAl()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı.");
        }
    }
}
