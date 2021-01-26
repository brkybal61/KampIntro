using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : ICreditManager
    {// Implement interface
        // Interface şablonu zorunlu olarak uygulandıktan sonra,
        // Interface'i kullanan her sınıf kendi kurallarını yazabilir.
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
