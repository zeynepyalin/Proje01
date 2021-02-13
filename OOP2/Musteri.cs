using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        // düzenlenmemiş hali böyle idi ;
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public string SirketAdi { get; set; }
        //public string TcNo { get; set; }
        //public string VergiNo { get; set; }
        // yıldızlı not : eğer bir nesnede bir değer oraya ait değilmiş gibi duruyorsa soyutlama hatası yapılıyor demektir.
        // gerçek ve tüzel (müşteri) karıştırılmamalıdır.
        // şirket adı oraya ait değil.
    }
}
