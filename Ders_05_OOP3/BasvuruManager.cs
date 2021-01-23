using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_05_OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran Bilgilerini Değerlendirme
            //
            krediManager.Hesapla();
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
