using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri bir Müşteridir.
    //Tüzel Müşteri
    //CoorporateCustomer aslında bir Customerdır. Customer'da olan herşey CoorporateCustomerda da Vardır.
    class CoorporateCustomer:Customer   //Miras-->inheritance
    {
        public string CompanyName { get; set; }  //Şirket Adı
        public string TaxNumber { get; set; }  //tax number = vergi numarası
    }
}
