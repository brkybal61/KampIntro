using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {   // Sepete ekle
        // Manager, Service, Controller, DataAcces, Dal gibi sözcükler var ise operasyon tutulduğunu anlamamız gerekir.

        //naming convention add() değilde Add()
        //syntax - Yazım Kuralları
        //Encapsulation yapılmış! Class kullanılmış!
        public void Ekle(Product urun) //Metod parametre alıyor o da ürün
        {
            //Neyi eklemek istediğini metoda vermek gerekir.
            //Parametre vermek gerekir.
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }

        //Kötü kullanım!
        //Bir değişim her sayfayı bozar! Tek tek düzeltme gerekir!
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
