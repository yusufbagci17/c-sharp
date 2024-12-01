using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon("Pikachu", "Elektrik", "Yıldırım Oku", 50, 30, 100, 40);
            Pokemon squirtle = new Pokemon("Squirtle", "Su", "Su Pompası", 40, 35, 100, 40);
            pikachu.Saldir(squirtle);
            squirtle.Saldir(pikachu);
            pikachu.Yenilen();

            Console.ReadKey();
        }
    }
}