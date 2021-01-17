using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun                              // Nesneyi tanımlayan birden fazla bilgiyi depolamamızı sağlayan yapılardır. Bir nesne üzerinden class a ait olan bilgileri çağrırabileceğim.
    {
        public int Id { get; set; }            // prop = property = Özellik
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
