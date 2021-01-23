using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_03_Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("{0} Adlı Urun Başarıyla Eklendi!", urun.Adi);
        }
        public void Ekle2(String urunAdi,String aciklama,double fiyati)
        {
            Console.WriteLine("{0} Adlı Urun Başarıyla Eklendi!", urunAdi);
        }
    }
}
