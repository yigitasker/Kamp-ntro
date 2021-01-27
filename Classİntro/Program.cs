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

            // Console.WriteLine(new Kurs().Egitmen);          // bu şekilde boş döner çünkü direkt class a gider ve ordan get i çalıştırır ama bize dönen bişey yoktur bu durumdan dolayı diğerleri gibi property lere özellik tanımlamalayız.

            // Console.WriteLine(kurs1.KursAdi + " adlı kursun eğitmeni " + kurs1.Egitmen + " dir.");


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            //foreach (Kurs i in kurslar)
            //{
            //    Console.WriteLine(i.Egitmen);
            //}

            

            // ClassDetaylar ile alakalı işlemler;




            ClassDetaylar customer = new ClassDetaylar();

            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";                 //  customer.FirstName = "Engin"; eşitleme yapıldığında set çalışır, Console.WriteLine(customer2.FirstName); değer alma işlemelri yapıldığında get çalışır.
            customer.LastName = "DEMİR";


            ClassDetaylar customer2 = new ClassDetaylar 
            { 
                Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "DEMİR"          
            };


            // Console.WriteLine(customer2.FirstName);




            new Kurs { KursAdi = "Yiğit", Egitmen = "MAT", İzlenmeOrani = "23" };                                  // yeni adres örneğin = 100
            Console.WriteLine(new Kurs { KursAdi = "Yiğit", Egitmen = "MAT", İzlenmeOrani = "23" }.Egitmen);



            new Kurs { KursAdi = "Pınar", Egitmen = "go", İzlenmeOrani = "56" };                                  // yeni adres örneğin = 101
            Console.WriteLine(new Kurs { KursAdi = "Pınar", Egitmen = "go", İzlenmeOrani = "56" }.Egitmen);



            Kurs kurs4 = new Kurs { KursAdi = "Panter", Egitmen = "pantercilik", İzlenmeOrani = "40" };           // objeye tanımlanan yeni adres = 103






        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string İzlenmeOrani { get; set; }
    }
}

