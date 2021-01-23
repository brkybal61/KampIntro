using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berkay Bal
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Berkay";
            customer1.LastName = "Bal";
            customer1.TcNo = "12345678910";


            //Kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "56789";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "12345678910";

            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new IndividualCustomer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID 
        }
    }
}
