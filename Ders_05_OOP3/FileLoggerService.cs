using System;

namespace Ders_05_OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya loglandı");
        }
    }
}
