using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) // Bu metodu kullanman için iki sayı vermen gerekli! - void
        {
            int sum = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + sum);
        }
        public void Subtraction(double num1, double num2)
        {
            double sub = num1 - num2;
            Console.WriteLine("Fark(Kalan): {0}", sub);

        }
        public void Multiplication(double num1, double num2)
        {
            double mul = num1 * num2;
            Console.WriteLine("Çarpım: {0}", mul);
        }
        public void Division(double num1, double num2)
        {
            double div = num1 / num2;
            Console.WriteLine("Bölüm: {0}", div);
        }
    }
}
