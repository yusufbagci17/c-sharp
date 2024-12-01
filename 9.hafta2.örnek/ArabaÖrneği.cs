using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.hafta2.örnek
{
    public class ArabaÖrneği
    {
        private int HIZ;
        public int hız
        {

            get { return HIZ; }
            set
            {
                if (HIZ > 0 && HIZ < 240) HIZ = value;
                else Console.WriteLine("Geçersiz HIZ DEĞERLERİ");
            }
        }
            private string MODEL;
        public string model
        {
            get { return string.IsNullOrWhiteSpace(MODEL) ? "Belirtilmedi" : MODEL; }
            set { if (!string.IsNullOrWhiteSpace(value)) MODEL = value;
         
            }

        }
        private string MARKA;
        public string marka
        {
            get { return string.IsNullOrWhiteSpace(MARKA) ? "Belirtilmedi" : MARKA; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) MARKA = value;
               
            }
        }
        public void BilgileriGöster()
        {
            Console.WriteLine($"Marka:{marka}  Model:{model}  Hız:{hız}");
        }


        }

    }

