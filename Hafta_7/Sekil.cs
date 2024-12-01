using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_7
{
    internal class Sekil
    {
        public byte Boyut { get; set; }
        public void Yazdir() 
        {
            for (byte i = 1; i <= Boyut; i++) 
            {                
                for (byte j = 1; j < i; j++)
                {

                    if (j == 1||i==Boyut)
                    {
                        Console.Write("*");

                    }
                    else 
                    { 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("*");
            }
            /*for (byte i = 1; i <= Boyut; i++)
            {
                if (i != 1)
                {
                    Console.Write("*");
                }

                for (byte j = 1; j <= i; j++)
                {

                    if (j == i)
                    {
                        Console.WriteLine("*");

                    }
                    else if (i == Boyut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                
            }*/
        }
    }
}
