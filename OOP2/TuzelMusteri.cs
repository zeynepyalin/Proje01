using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // eng: Coorporat
    // Tüzel kişilikler, çeşitli ticari ve sosyal amaçları yerine getirmek için bir araya gelmiş gerçek kişilerin oluşturduğu kişiliklerdir.
    // miras (=inheritance)
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
