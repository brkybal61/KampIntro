using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berkay Bal-Gerçek Müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Berkay";
            customer1.LastName = "Bal";
            customer1.TcNo = "12345678910";


            //Kodlama.io-Tüzel Müşteri
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "56789";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "12345678910";

            // Gerçek Müşteri - Tüzel Müşteri : Bunlar farklı müşterilerdir.
            // SOLID'in L'si

            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new IndividualCustomer();
            // Müşteri Gerçek ve Tüzel Müşteri'yi tutabilir.
            // Müşteri Class'ı hem Gerçek Müşterinin hemde Tüzel Müşterinin referansını tutabilir.
            // Müşteri Manager'a temel sınıfın tüm miras alanlarını gönderebiliriz.
            // Base Class tüm miras alanlarının referanslarını tutabilir.


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            // Buradaki olay:
            /* Base sınıfın, yani temel sınıfın onu inherit eden 
             * sınıflarının referansını tutabilmesidir.
             */

     
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID 
        }
    }
}
