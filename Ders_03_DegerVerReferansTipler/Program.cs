using System;

namespace Ders_03_DegerVerReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi1;
            sayi1 = 65;
            //sayi1 ?? 30
            string dene = "Evim";
            int[] sayilar1 = new int[] { 1, 2, 3, 4, 5 };
            int[] sayilar2 = new int[] { 10, 20, 30, 40, 50 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 99
            //Değer Tipler: int,double,string,bool,float,decimal
            //Referans Tipler: Array,Class,interface,
        }
    }
 }
