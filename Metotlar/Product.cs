using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {   // Class, nesneyi tanımlayan birden fazla özellikleri barındıran yapıdır.

        // Property -- Özellik
        // prop bir snippet, bizim için önceden tanımlı kısa yollar.
        public int Id { get; set; }  // Id bir datanın eşsiz değerini gösterir.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
