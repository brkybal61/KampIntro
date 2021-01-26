using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer  // Base Class, Temel Sınıf, Miras Alınan Sınıf
    {   // Classlar : Özellik veya operasyonlar tutar.
        // Ürün, kişi ismi var ise o sınıf Entity(Varlık)'dir. (Customer,Person,Employee gibi)
        // Ya Özellik ya da Operasyon tut!
        public int Id { get; set; }
        public string CustomerNumber { get; set; } //Müşteri No

        /* Müşteri sınıfı Gerçek Müşteri ve Tüzel Müşteri için 
         * ortak özellikleri barındırır. Gerçek ve Tüzel Müşteri
         * classları ise sadece kendine ait özellikleri tutarlar.
         */

        // Sayısal işlemler yapılmayacak her özellik için string tut!
        /* TC, Müşteri No, Vergi No gibi sayılarla sayısal işlem yapmayız,
         * o yüzden string kullanmak daha mantıklıdır.
         *  implementation - uygulama demektir!
         */

        // Base Sınıf, referans tutucudur.
    }
}
