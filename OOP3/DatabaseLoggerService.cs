using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService                // ampule bas düzeltilmezse kırmızı devam eder. burdaki ifade ile, aslında sen bir IloggerService alternatifisin demiş oluyoruz.
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
