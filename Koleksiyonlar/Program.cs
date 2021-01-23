using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // stack           //heap         //değerleri
            string[] isimler = new string[] { "Berkay", "Kerem", "Süleyman", "Oğluş" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; //5 elemanlı boş bir array oluşturduk 
            isimler[4] = "Ronaldinho"; //Yeni oluşan 5 elemanlı arrayde Ronaldinho'yu 4'e atadın,Öncekiler boş kaldı demektir.
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);//Boş geldi.

            // Uzun listelere yeni veriler eklemek için koleksiyonlar kullanılır!
            // Arrayler ilk tanımlandıkları şekli korurlar, ya tanımı değiştirmek yada ekleme metodları kullanılmasını gerektirir.
            // Çok fazla veri olduğu için bu yol tercih edilmez!
            // Elimizdeki array 4 elemanlı, 5 elemanlı yaparsak eski elemanları kaybederiz.
            // new demek yeni referans adresi demektir!

            // System.Collections.Generic sınıfının bir sınıfıdır. 
            List<string> isimler2 = new List<string> { "Berkay", "Kerem", "Süleyman", "Oğluş" }; //List burda bir sınıftır.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ronaldinho");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İniesta");
            Console.WriteLine(isimler2[5]);
        }
    }
}
