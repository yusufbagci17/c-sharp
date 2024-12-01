using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5
{
    public class Araba
    {
        public string marka;
        public string model;
        public short uretimYili;

        public void BilgileriGoster()
        {
            Console.WriteLine($"Marka: {marka}\nModel: {model}\nÜretim Yılı: {uretimYili}");
        }
    }
}
