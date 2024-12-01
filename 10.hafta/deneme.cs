using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.hafta
{
    public class deneme
    {
        //static field veya poroprety tanımlama
        public static int Boyut { get; set; }
        private string Soyad { get; set; }
        private string Ad { get; set; }
        public static int Maas { get; set; }
        static deneme()
        {
            // static herşeyi koyabliriz ama static olmayan hiçbirşey kulanılamaz.
            //her durumda ilk static metod çalışır.
            //static kurucu metodu yanlızca birkez çağrılır.
            //aşırı yükleme yapılamaz.
            Maas = 0;   
        }
        public deneme(string soyad, string ad)
        {
            Soyad = soyad;
            Ad = ad;
        }


        // static bir metod tanımlama
        public void yazdır()
        {
            Console.WriteLine($"boyut:{Boyut}");
        }
        // static yapıcı metod
        public void yazdır2() {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
        }

    }
}
