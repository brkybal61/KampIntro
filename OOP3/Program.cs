using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Calculate();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Calculate();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Calculate();



            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();

            ICreditManager tasitKrediManager = new TasitKrediManager();

            ICreditManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            List<ICreditManager> krediler = new List<ICreditManager> { ihtiyacKrediManager, tasitKrediManager };

            //applicationManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
