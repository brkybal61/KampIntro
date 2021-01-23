using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //BaşvuruManager
    class ApplicationManager
    {
        //Method injection 
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme

            creditManager.Calculate();
            loggerService.Log();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();  //Tüm başvuruları konut kredisine bağladık.Doğru değildir.
            //konutKrediManager.Calculate();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler )
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
