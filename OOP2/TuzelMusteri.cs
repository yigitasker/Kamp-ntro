using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri: Musteri                          // miras => inheritance, TuzelMusteri bir Musteri dir. Müsteride olan herşey teuzelmusteride de olur. Musteri = ebeveyn
    {        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
