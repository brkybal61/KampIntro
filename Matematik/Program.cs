using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Subtraction(5, 6);
            dortIslem.Multiplication(5, 6);
            dortIslem.Division(5, 6);
        }
    }
    
}
