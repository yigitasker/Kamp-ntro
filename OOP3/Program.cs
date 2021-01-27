using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
             İhtiyacKrediManager ihtiyacKrediManager1 = new İhtiyacKrediManager();             // yandaki örnek ile aşağıdaki örnekler aynıdır. aynı sonuçları alırız. inheritance da almış olduğumuz gibi
             ihtiyacKrediManager1.Hesapla();

            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();                    // interface lerde, o interface i implemente eden class(mirasçısı olan) ın referans numarasını tutabiliyor.
            // ihtiyacKrediManager.Hesapla();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
         
            IKrediManager konutKrediManager = new KonutKrediManager();

     






            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();








            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);    // ihtiyac kredisi onaylandı, dosyayaya loglandı sekilnde çıktı alırız.
                





            //basvuruManager.BasvuruYap(ihtiyacKrediManager);              IKrediManager bir interface olduğundan new lenemediğinden dolayı değer olarak onu veremiyoruz.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager };       // IKrediManager veri tipinde bir liste oluşturduk.


            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);               // iki verimi bu şekilde gönderebiliyorum



        }
    }

    
}
