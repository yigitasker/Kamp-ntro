using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeces2
{
    class Program
    {
        static void Main(string[] args)
        {
            // IPerson person = new IPerson();            // interfacelerin instance ları oluşturulamaz. new lenemez.

            SqlServerCustomerDal sql = new SqlServerCustomerDal();



            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(sql);

            // bir başka yöntem;

            customerManager.Add(new OracleCustomerDal());             // ayrı yerde obje oluşturmadan new leyerek işlemimi bitirdim.





        }
    }
}
