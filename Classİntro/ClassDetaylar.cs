using System;
using System.Collections.Generic;
using System.Text;

namespace Classİntro
{
    class ClassDetaylar
    { 
        

        public  int Id { get; set; }





        // field
        private string _firstName;                  // burda bir firastName tutuyorum ve get yapıldığı zaman  burda tanımladığım değer geri dödürülür. set yaptığımda da yine private te buluna değeri set ediyorum
        
        // Property
        public string FirstName 
        {
            get { return "Mrs." +  _firstName; }         // diğer tarafta yazdırdığımzıda Mrs. Derin yazdırılacak.
            
            set{_firstName = value;}                    // value değeri FirstName den gelen değerimiz.
        }






        public string LastName { get; set; }
        public string City { get; set; }

    }
}
