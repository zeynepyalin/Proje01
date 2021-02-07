using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        // doğrudan class'ın içinde oluşturuldu, bu şekilde tüm fonksiyonlarda kullabilir.
        // program.cs'de listeye eklenen değerleri bir yere kaydetmek için bu işlem yapılıyor;
        T[] items;

        // constructor (class ismi ile aynı)
        public MyList()
        {
            // 0 elemanlı olarak oluşturduk.
            items = new T[0];
        }
        public void Add(T item)
        {
            // fonk her kullanıldığında items uzunluğu bir artacağından fonk çalıştığında mevcuttaki elemanı 1 artırır.
            // her yenilemede yeni dizi oluşturup diğer elemanlar kaybolmasın diye geçici dizi oluşturduk.
            T[] tempArray = items;
            items = new T[items.Length+1];
            // tempArray'e emanet edilen elemanları geri alacağız;
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            // son elemanı asıl eklenmek istenen eleman yap
            // fonksiyon kullanıldığında o an eklenmek istenen eleman
            items[items.Length - 1] = item;
        }
    }
}
