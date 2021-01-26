using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList isimler = new MyList(); hata verir çünkü çalışacağı tipi ister.
            MyList<string> isimler=new MyList<string>();  //Generic bir class olduğu için çalışacağı tipi söylemeliyiz.string dersek string türünde liste
            isimler.Add("Berkay");                                                                                   // int dersek int türünde bir liste olurdu.
                                                                                                                     // Arka planda MyList teki T'miz String oluyor.

            Console.WriteLine(isimler.Length);

            isimler.Add("İrem");
            isimler.Add("Yasemin");
            isimler.Add("İzzet");
            Console.WriteLine(isimler.Length); // MyList'teki kendi Length'imiz.

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("\nFor Döngüsü ile Listeyi Yazdırma:");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.Items[i]);
            }
        }
    }
}
