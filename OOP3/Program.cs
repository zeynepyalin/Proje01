using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphizm örneği - bunun için bir kredimanager oluşturuldu.
            // her kredi için ayrı class oluşturuldu ve bu kredilerin ortak özelliklerinin bulunduğu kredi managerdan miras alındı.
            // IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            // interface üzerinden de instance oluşturup referans numarası tutulabilir.
            
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>()
            {
                databaseLoggerService,
                fileLoggerService
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, loggers);

           

            List<IKrediManager> krediler = new List<IKrediManager>() 
            {
                ihtiyacKrediManager,
                tasitKrediManager
            };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
