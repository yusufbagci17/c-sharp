using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme
            Deneme d1 = new Deneme();
            d1.SetIsim("Coşkun");
            Console.WriteLine(d1.GetIsim());
            d1.Soyad = "Barış";
            Console.WriteLine(d1.Soyad);
            Console.WriteLine(d1.GetIsim());
            d1.TCKN = Console.ReadLine();
            Console.WriteLine(d1.TCKN);
            Console.ReadKey();
        }
    }
}
