using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);                  // Out of range hatası alınır. Diziler oluşturulan sınırlar içerisnde takılır sınırları genişletilemez. genişletmeye çalışsak bile değerleri kaybederiz.


            // örneğin;


            // isimler = new string[5];                       // beş eleman sayısına sahip adresi değiştirilmiş yeni bir dizi tanımlamış olduk ve eski elemanlar kayboldu. yani isimler adında başka bir adrese sahip yeni  bir array oluşturuldu.

            // Console.Writeline(isimler[0])                  // Engin YAZDIRILMAZ !!! boşluk yazdırılır.

            
            
            
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };                                            // ampule tıkla generic değerini ekle

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");                                // İlker elemanı List türündeki koleksiyonlara ekleniyor bunun adına (List)koleksiyonlar denir. Add bir koleksiyon aracıdır (metot).

          
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



            










        }
    }
}
