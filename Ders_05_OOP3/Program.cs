using System.Collections.Generic;

namespace Ders_05_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, fileLoggerService };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
