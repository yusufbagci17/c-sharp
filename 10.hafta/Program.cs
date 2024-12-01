using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.hafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            deneme d1 = new deneme("yusuf","bağcı");
            deneme.Boyut = 5;
            d1.yazdır2();
            d1.yazdır();
            Console.ReadKey();
        }
    }
}
