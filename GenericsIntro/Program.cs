using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList names = new MyList(); hata verir çünkü çalışacağı tipi ister.
            MyList<string> isimler=new MyList<string>();  //Generic bir class olduğu için çalışacağı tipi söylemeliyiz.string dersek string türünde liste
            isimler.Add("Berkay");                                                                                   // int dersek int türünde bir liste olurdu.
                                                                                                                     // Arka planda MyList teki T'miz String oluyor.
            
        }
    }
}
