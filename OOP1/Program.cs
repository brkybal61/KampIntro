using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classları; özellik barındıranlar ve operasyon barındıranlar olarak ikiye ayrılır.
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //Mobilya olarak algıla 
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Bu şekilde de tanımlama yapılabilir.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 }; //Kırtasiye olarak algıla
            // () işareti yokkk!!!
            // Angular kullanarak kullanıcıdan alıyor olacağız bu bilgileri!


            //case sensitive -- Büyük küçük harf duyarlı
            //PascalCase   //camelCase
            //ProductManager türündeki productManager değişkeni referans numarası almış yeni bir ProductManager'dir.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            // diziler, classlar, abstract class, interface ... gibi Referans tipler verileri heapte tutar.
            // Atamalar referans numaralarıyla yapılır, o numaraya yeni bir değer atandığı için değişir.



            int num = 100;
            productManager.BirSeyYap(num);
            Console.WriteLine(num);
            // primitive tipler yani değer tipler verileri stack'te tutar.
            // değerle ilgilenir adresle değil!
            // main(üsteki num=100) classtaki atamayla productManagerdeki classtaki atamanın bir bağlantısı yoktur!

            productManager.Sum2(3, 6); // Bu işlem sonucundaki sum'ı kullanmak istiyorsak return gerekir.
            int sumResult = productManager.Sum(3, 6);
            Console.WriteLine(sumResult * 2);






            //int,double,bool ... değer tip
            //diziler,class,abstract class, interface ... referans tip
        }
    }
}
