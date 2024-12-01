using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 5; // object -> tüm değişkenleri saklar.
            byte b1 = 5;
            byte b2 = 10;
            string s1 = b1.ToString();
            string s2 = b2.ToString();
            Console.WriteLine(b1 + " + " + b2 + " = " + (b1 + b2));
            Console.WriteLine(s1 + " + " + s2 + " = " + (s1 + s2));
            Console.ReadKey();
        }
    }
}
