using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  //Entity(Varlık) isimleri
    {
        //snippet
        public int Id { get; set; }  //Eşsiz değer, ayırt edici özellik
        public int CategoryId { get; set; } //Referencing key, Foreign Key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //Ürünün Birim Fiyatı
        public int UnitsInStock { get; set; } //Stok Adeti

        //CRUD Operasyonları: Create Read Update Delete

    }
}
