using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //Class'ın belirli bir tiple(T) çalıştığını söyleriz.
    {
        T[] items;  //Heryerden erişilir! T tipinde bir dizi
                    // Bir array'in new'lenme zorunluluğu vardır!
                    // Bir class new'lenince çalışan bloğa Constructor denir.
                    // List<T> sınıfı arkaplanda bir array yönetir.
                    // Bizim sınıfımızda burada bir array yönetecek!
        public MyList()
        {
            // constructor(yapıcı) metot
            // Classların instance yani bir yerde new ile oluşturulmasıyla bu metot otomatik çalışır.
            items = new T[0];
            // Bu class bir yerde newlenirse, constructor otomatik olarak 0 elemanlı bir array oluşturup ona bir referans numarası atar.
            // default olarak çalışır!
        }
        public void Add(T item) //item=eleman //T olarak ne verirsem, istediğim elemanın türüde odur!
        {                     //Benim çalışacağım tipi o an programcı new lerken ne derse hangi tip derse o olsun,işte o da o T , T verdiğiniz tipe karşılık geliyor.Program.cs de MyList<string> belirttiğimiz için burdaki T'miz String oluyor.

            T[] tempArray = items;  //Geçici dizi items'ın referansını tutuyor! //tempArray=geciciDizi 

            items = new T[items.Length+1];  //items.Length dizinin eleman sayısını verir.Burada dizinin eleman sayısını 1 artırıyoruz. 
                                            //O dı 1 oldu ama new ile yeni referans numarası tutulduğu için elemanlar kaybolacak!
                                            //Referansı tutacak bir eleman lazım! Önceki değerleri tutmak için(tempArray) (Yukarıda tempArray oluşturduk.)

            for (int i = 0; i < tempArray.Length; i++)
            { //Verileri geri almak için
                items[i] = tempArray[i];
            } //elemanları geri alır ve bir index boşluk oluşturur.

            items[items.Length - 1] = item;  //Eklemek istenen elemanı yani item'ı açılan yere eklememizi sağlar!
        }

    }
}
