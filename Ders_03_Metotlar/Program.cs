using System;

namespace Ders_03_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2};
            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }
            Console.WriteLine("----------Metotlar---------");
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);



            Console.WriteLine("Hello World!");
        }
    }
}
