using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances   // kalıtım, miras 
{
    class Program
    {
        static void Main(string[] args)
        {

            // Customer customer = new Customer();            // Customer Class ından tanımladığım objemin içerisinde Person metotlarıda çalışacaktır => miras aldı.
            // customer.FirstName

            Person[] persons = new Person[3]
            {
                new Customer{FirstName ="Pınar",LastName = "YILDIZ" },              // new leyerek Class seviyesinde yeni bir adres tutan bir değer üzerinden metotlarımın içini doldurdum. 
                // new Customer{FirstName ="Pınar",LastName = "YILDIZ" },           // new = yeni adres bunu açarsam buda çalışır yukardaki ile ayni class ı çağırıyorum
                new Student{FirstName ="Yiğit",LastName = "ASKER"},
                new Person{FirstName ="Kamil",LastName = "KA"}
            };


            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();

        }
    }


    class Person                              // interface gibi değidir inheritance lar tek başlarına anlam ifade eder yani new leyebiliyorum.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    class Person2                   
    {

    }


    class Customer:Person          // Customer sen bir Person demiş olduk.
    {
        public string City { get; set; }

    }


    class Student:Person, Person2                   // inheritance da birden fazla ebeveyn olamaz.
    {
        public string Department { get; set; }
    }






}
