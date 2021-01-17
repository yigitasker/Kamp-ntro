using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}


            // Dizi tanımlama;


            //string[] names = new string[] { "Pınar", "Yiğit", "Simge" };
            //Console.WriteLine(names);                        Pythonda olduğu gibi dizi ifademizi direkt yazdıramıyoruz. bunun yerine [0] şekilde ulaşıyoruz.


            //string[] kurslar = new string[] { "Java", "Python", "C#" };

            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}


            //string[] cars = new string[] { "Renault", "Toyota", "BMW" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);

            //}



            string[] students = new string[] { "Ali", "Ayşe", "Kamuran" };
            foreach(string i in students)
            {
                Console.WriteLine(i);
            }

            






        }
    }
}
