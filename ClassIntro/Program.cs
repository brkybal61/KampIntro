using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Değişken 1
            // Class değişkenini oluşturmak ve değerlerini atamak için yapılacak işlemler:
            Kurs kurs1 = new Kurs();  //Değişken olarak obje tanımlama!
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 61;  //Yüzde 61 izlemiş gibi

            //Değişken 2
            Kurs kurs2 = new Kurs(); //Değişken olarak obje tanımlama!
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 71;

            //Değişken 3
            Kurs kurs3 = new Kurs(); //Değişken olarak obje tanımlama!
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 81;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            //Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen);
            //Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen);

            //Dinamik Listeleme İçin

            //İçinde Kurs değişkelerini tutan Kurs Arrayı oluşturma:
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {   // kurslar isimli arrayin her bir elemanının yani objesinin yani değişkeninin istenilen özelliklerini döner
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {   //Class objesinde classa ait tüm verileri tutarız.
        public string KursAdi { get; set; }  //prop ile şablon alınır.
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
