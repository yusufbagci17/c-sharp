using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.hafta2.örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArabaÖrneği a1= new ArabaÖrneği();
            a1.model = "golf";
            a1.marka = "wolswogen";
            a1.hız = 250;
            a1.BilgileriGöster();
        }
    }
}
