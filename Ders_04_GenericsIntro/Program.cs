using System;

namespace Ders_04_GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("mahmut");
            Console.WriteLine("Hello World!");
        }
    }
}
