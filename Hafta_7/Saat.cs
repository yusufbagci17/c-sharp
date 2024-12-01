using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_7
{
    internal class Saat
    {
        public string Saatt { get; set; }
        public string Dakika { get; set; }
        public string Saniye { get; set; }

        public Saat(string Saat, string Dakika, string Saniye)
        {
            this.Saatt = Saat;
            this.Dakika = Dakika;
            this.Saniye = Saniye;
        }
        public Saat() 
        {
            this.Saatt = "00";
            this.Dakika = "00";
            this.Saniye = "00";
        }
        public void Saat_Goster()
        {
            Console.WriteLine($"Saat: {Saatt}:{Dakika}:{Saniye}");
        }
    }
}
