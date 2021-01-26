using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //BaşvuruManager
    class ApplicationManager
    {// Başvuru
        // Dependency Injection
        // Method injection yapılıyor.
        // Apply metodunun kullanacağı KrediManager'ını yani hangi kredi türü olacağını,
        // ve Hangi LoggerService olacağını enjekte ediyoruz.
        // Apply metodunda hangi kredi ve loglayıcı olduğuna dair bilgi yok,
        // Sadece soyut halleri var, somut hallerini enjekte ediyoruz.



        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        //public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService) //Burda ILoggerService'i tekil yolladık. (**)
        // Parametre tipi olarak ICreditManager kullanılırsa, her krediye erişebiliriz.
        {
            //Başvuran bilgilerini değerlendirme

            creditManager.Calculate();  // Hangi kredi gelirse ona göre hesaplanacak!
            //Bu metodu loglamak istiyorsak:
            //loggerService.Log(); // Hangi LoggerService gönderilmişse, onu logla. (**)
            // Genelde çoklu loglamalar yapılır!
            // List yollamamız gerekir çoklu loglamalar için.
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); //Herbir logger'ı dön, çalıştır!
            }

            //KonutKrediManager konutKrediManager = new KonutKrediManager();  //Tüm başvurular konut kredisi üzerinden hesaplanır.Doğru değildir.
            //konutKrediManager.Calculate();

            // Parametreyi ICreditManager tipiyle ayarladığımız için kredi bağımsız hale gelir.
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler) //Kredi Ön Bilgilendirmesi Yap
        {// Bilgilendirme için birden fazla kredi seçilebilir.
            // Listenin türü ICreditManager
            // Listedeki elemanları dolaşmak için
            foreach (var kredi in krediler)
            { 
                kredi.Calculate(); // Listenin her elemanı için Kredi Hesapla
            }

            //for (int i = 0; i < krediler.Count; i++) // For ile yazılması
            //{
            //    krediler[i].Calculate();
            //}
        }
    }
}
