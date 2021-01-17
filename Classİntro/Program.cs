using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();      // kurs1 adında objemiz oluşturuldu veri tipi Kurs oldu.

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Yiğit";
            kurs1.İzlenmeOrani = "45";

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Berkay";
            kurs2.İzlenmeOrani = "70";

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Pınar";
            kurs3.İzlenmeOrani = "80";

            // Console.WriteLine(kurs1.KursAdi + " adlı kursun eğitmeni " + kurs1.Egitmen + " dir.");


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs i in kurslar)
            {
                Console.WriteLine(i.Egitmen);
            }


        
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string İzlenmeOrani { get; set; }
    }
}

