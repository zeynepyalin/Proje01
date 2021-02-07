using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // t için tanımlama sırasında yazılan tip önemlidir
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Zeynep");
        }
    }
}
