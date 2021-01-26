using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Interface***
            // Kredilerin instancelarını oluşturma
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Calculate();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Calculate();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Calculate();

            //---------------------------------------
            // Interface'lerde interface'i implement eden sınıfların referans numarasını tutabilir.
            // Inheritance'taki gibi.


            // Ekran seçimleri olarak düşün.
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();

            ICreditManager tasitKrediManager = new TasitKrediManager();

            ICreditManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            // Bu yazılımda sürdürülebilirliği sağlar!


            //Başvuru Yapma:
            ApplicationManager applicationManager = new ApplicationManager();
          //applicationManager.BasvuruYap(tasitKrediManager, new SmsLoggerService());
          //applicationManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            applicationManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService() });

            List<ICreditManager> krediler = new List<ICreditManager> { ihtiyacKrediManager, tasitKrediManager };


            //applicationManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
