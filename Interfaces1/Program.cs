using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();


            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Pınar",
                LastName = "Yıldız",
                Address = "Ankara"
                
            };



            Student student = new Student();
            student.Id = 2;
            student.FirstName = "Yiğit";
            student.LastName = "Asker";
            student.Departman = "İktisat";


             
            personManager.Add(customer);        // parametre bizden IPerson istiyor ama onu implement e eden değerlerde bir IPerson olduğu için Customer ve Student onjelerimi gönderebiliyorum.
            personManager.Add(student);




        }
    }

    interface IPerson                    // interface ler tek başlarına hibir anlam ifade etmez. İmplemente edillen değerler için aşağıdaki üç özellik çalışır.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }


    class Customer : IPerson              // Sen bir IPerson sın demiş oluyoruz. veri tipi seviyesinde Customer = IPerson olmuş oluyor.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }                                    // ayrı bir özellik
    }


    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departman { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
