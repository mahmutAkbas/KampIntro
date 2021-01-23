
using System;
using System.Collections.Generic;

namespace Ders_04_Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "mahmut", "mustafa", "ercan", "ali" };
            //Console.WriteLine(isimler[0]);
            //isimler = new string[5];
            //isimler[4] = "hasan";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Mustafa", "Ercan", "Ali", "Hasan" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Mahmut");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
