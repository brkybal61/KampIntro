using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İş Sınıfları--> Business Classes
    class CustomerManager
    {  // Manager, Service, Controller, ... gibi ekler var ise o sınıf operasyon sınıfıdır.
        public void Add(Customer customer)
        {
            // Hem gerçek hemde tüzel müşteriyi gönderebilmek için
            // Parametre olarak müşteriyi göndermek polymorphisim(çok biçimlilik) örneğidir.
            // Base Class'ta Her Müşteri Tipi tutulabilir.
        }
    }
}
