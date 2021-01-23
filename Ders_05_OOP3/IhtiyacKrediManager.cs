using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_05_OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyaç Kredisi Ödeme Planı Hesaplandı");
        }
    }
}
