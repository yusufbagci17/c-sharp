using System; // Temel sistem kütüphanelerini kullanmamızı sağlar.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.haftaÖrnek // Projenin namespace tanımı.
{
    // Program sınıfı, uygulamanın başlangıç noktasıdır.
    internal class Program
    {
        // Main metodu, programın çalışmaya başladığı yerdir.
        static void Main(string[] args)
        {
            // ÖğrenciNo sınıfından ö1 adında bir nesne oluşturuluyor.
            ÖğrenciNo ö1 = new ÖğrenciNo();

            // ö1 nesnesine ait AD özelliğine "yusuf" değeri atanıyor.
            ö1.AD = "yusuf";

            // ö1 nesnesine ait ÖĞRENCİNO özelliğine "1234567" değeri atanıyor.
            ö1.ÖĞRENCİNO = "1234567";

            // Yeni bir ÖğrenciNo nesnesi (ö2) oluşturuluyor.
            ÖğrenciNo ö2 = new ÖğrenciNo();

            // ö2 nesnesine ait AD özelliğine boş bir değer atanıyor.
            // Bu işlem setter'da kontrol edilerek uyarı verecektir (Ad boş olamaz).
            ö2.AD = "";

            // ö2 nesnesine ait ÖĞRENCİNO özelliğine boş bir değer atanıyor.
            // Bu işlem setter'da kontrol edilerek uyarı verecektir (Numarası boş olamaz).
            ö2.ÖĞRENCİNO = "";

            // ö1 nesnesinin AD ve ÖĞRENCİNO özellikleri ekrana yazdırılıyor.
            Console.WriteLine($"1.AD:{ö1.AD}"); // Çıktı: 1.AD:yusuf
            Console.WriteLine($"1.NO:{ö1.ÖĞRENCİNO}"); // Çıktı: 1.NO:1234567

            // ö2 nesnesinin AD ve ÖĞRENCİNO özellikleri ekrana yazdırılıyor.
            // Boş atama olduğu için uyarılar verilmiş olacak ve default (boş) değerler gösterilecek.
            Console.WriteLine($"2.AD:{ö2.AD}"); // Çıktı: 2.AD: (Boş string)
            Console.WriteLine($"2.NO:{ö2.ÖĞRENCİNO}"); // Çıktı: 2.NO: (Boş string)
        }
    }
}
