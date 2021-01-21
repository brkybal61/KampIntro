using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Metodlar, tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            // DRY principle: Do not repeat yourself! - Clean Code - Best Practice (Doğru Uygulama Teknikleri)

            // Örneğin, e-ticaret sitesinde ürünlerin sepete ekleme kısmı.
            // Sepete ekleme her yere eklenen hatta mail ile gönderilen aynı fonksiyonu, metodu içerir.

            //Class'tan bir değişken tanımlama:
            Product product1 = new Product();  //Class'ın örneği yani instance  oluşturma
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "İzmit Karpuzu";

            // Class'tan oluşturulan değişkenleri diziye toplamak:
            // Belirtilen tipte birden fazla data içerir.
            Product[] urunler = new Product[] { product1, product2 };

            //type-safe -- tip güvenli
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("----------Metotlar-----------");

            //İnstance - örnek
            //encapsulation -- Burada sayfaların patlamadı!
            //Encapsuation :. kapsülleme, bir yapıyı bir kapsüle düzene koymaktır.

            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(product1); //Çağrılan metod parametre ister.
            sepetManeger.Ekle(product2);


            //Class olmasaydı, böyle ürün gönderilirdi!
            //Ürünün Stok Fiyatınında girilmesi istensin.
            //Hepsi sayfa olsaydı, her yer bozuldu, her ürünün stok fiyatını girmen gerekecek, tek tek değiştirmek gerekecek!
            //Kötü Kullanım!
            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12, 100);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 12, 75);
            sepetManeger.Ekle2("Karpuz", "İzmit Karpuz", 12, 50);


            // Metodlar,  reusability sağlar. (Tekrar tekrar kullanılabilme özelliği verir!)
        }
    }
}

//Dont Repeat Yourself -- DRY -- Clean Code -- Best Practice