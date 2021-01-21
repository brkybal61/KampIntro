using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Yazılımcı için en önemli kısımlardan biri
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi1'in değeri sayi2'nin değerine eşittir.
            sayi2 = 65;
            //sayi1=?

            //sayi1 = 10 , sayi2 = 30
            //sayi1 = sayi2
            //sayi1 = x10x 30 (10 siliniyor 30 oluyor) sayi2 = 30
            //sayi1 = 30 , sayi2 = x30x 65 (30 siliniyor 65 oluyor)
            //sayi1 = 30 olur
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);



            int[] nums1 = new int[] { 10, 20, 30 }; // referans tip
            int[] nums2 = new int[] { 100, 200, 300 };
            nums1 = nums2; // num1'in referans numarası num2'nin referans numarasına eşittir.
            nums2[0] = 999;
            // nums1[0]  kaç olur ? 

            // nums1 ------------------- 10 20 30 0.adress(Öylesine bir adress)
            // nums2 ------------------- 100 200 300 1.adress(Öylesine bir adress)
            // nums1 = nums2
            // nums1 adresi 0 silinir 1.adres olur. --- 0.adress öylece kalır!! Garbage Collector tarafından silinir.
            // nums2 ------------------- 100 200 300 1.adress
            // Her ikiside 1.addrese sahip olur.
            // nums2[0] = 999 olursa değer değiştirilir, Sonuç 999, 200, 300 olur.
            // nums1 diziside aynı adrese sahip listeyi aldığı için 0. elemanı 999 olur.
            Console.WriteLine(nums1[0]);

            // int, decimal, float, double, boolean :: değer tip -- stack
            // array, class, interface, class :: referans tip -- stack + heap

        }
    }
}
