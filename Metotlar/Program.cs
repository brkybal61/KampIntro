using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "İzmit Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("----------Metotlar-----------");

            //İnstance - örnek
            //encapsulation

            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);

            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12, 100);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 12, 75);
            sepetManeger.Ekle2("Karpuz", "İzmit Karpuz", 12, 50);

        }
    }
}

//Dont Repeat Yourself -- DRY -- Clean Code -- Best Practice