using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // class oluşturma alternatifleri; (3 farklı yol mevcut)

            Customer customer1 = new Customer {Id=1, FirstName="Yiğit", LastName="Asker",City="Ankara" };



            Customer customer3 = new Customer();
            customer3.Id = 3;



            Customer customer2 = new Customer(2, "Derin","Demiroğ","Ankara");         //   => parametrelere karşılık gelebilirler.
            Console.WriteLine(customer2.FirstName);


        }

      
            
    }


    class Customer
    {
        public Customer()                   // ctor => constructor, default constructor =  parametresi olmayan constructor a denir ,customer3 burda çalışır.
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }

        public Customer(int id, string firstName, string lastName, string city)             // parametrelerin verildiği customer2 yapımız burda çalıştı
        {
            Id = id;                                                                       // parametreden gelen değerlerimizi(firstName, lastName,...) aşağıda oluşturduğumuz değerler(FirstName, LastName,...) için tanımlamamız gerekiyor ki obje üzerinden kullanabilelelim.
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
