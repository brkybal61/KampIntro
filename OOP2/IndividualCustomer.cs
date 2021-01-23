using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek Müşteri
    class IndividualCustomer: Customer //Miras-->inheritance
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
