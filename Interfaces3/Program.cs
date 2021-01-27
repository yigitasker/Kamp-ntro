using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]              // array oluşturmak için en başta new lemek gerekiyor. yani iki elemanlı bir array tanımladım ve elemanları SqlServerCustomerDal ve  OracleCustomerDal dır.
            {
                new SqlServerCustomerDal(),                                // bir class ı kullanabilmemiz için new lemek gerekmwktedir. new SqlServerCustomerDal() dediğimizde bir nesneyi tanımlamakla aynı şey aşağıda açıklandı.
                new OracleCustomerDal()
            };

            CustomerManager customerManager = new CustomerManager();

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();                                          // project i çalıştırdığımızda hızlı kapanmasın diye 


            // 1. yol;

            SqlServerCustomerDal sqlServerCustomer = new SqlServerCustomerDal();
            sqlServerCustomer.Add();

            // 2. yol;

            new SqlServerCustomerDal().Add();

            



        }




    }
}
