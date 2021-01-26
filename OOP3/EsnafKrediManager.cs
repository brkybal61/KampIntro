using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKrediManager : ICreditManager
    {// Sadece yeni bir class ekleyerek yeni bir kredi oluşturuldu!
     // Kodlar içinde boğulmadık.
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı");
        }
    }
}
