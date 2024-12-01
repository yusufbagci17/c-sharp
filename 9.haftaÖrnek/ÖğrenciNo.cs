using System; // Temel sistem sınıflarını kullanmamızı sağlar.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.haftaÖrnek // Projenin içinde bulunduğu namespace tanımı.
{
    // ÖğrenciNo adında bir sınıf tanımlanıyor.
    public class ÖğrenciNo
    {
        // Öğrenci adı için private bir alan tanımlanıyor.
        private string ad;

        // Ad özelliği için getter ve setter:
        public string AD
        {
            // Getter: "ad" alanını döndürür.
            get { return ad; }

            // Setter: Ad alanına değer atar, aynı zamanda kontrol sağlar.
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // Ad boş veya sadece boşluklardan oluşmuyorsa.
                {
                    ad = value; // Ad alanına değer atanır.
                }
                else
                {
                    // Eğer ad boş veya null ise uyarı mesajı yazdırılır.
                    Console.WriteLine("Ad boş olamaz!");
                }
            }
        }

        // Öğrenci numarası için private bir alan tanımlanıyor.
        private string öğrencino;

        // Öğrenci numarası için getter ve setter:
        public string ÖĞRENCİNO
        {
            // Getter: "öğrencino" alanını döndürür.
            get { return öğrencino; }

            // Setter: Öğrenci numarasına değer atar ve kontrol sağlar.
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // Öğrenci numarası boş veya sadece boşluklardan oluşmuyorsa.
                {
                    öğrencino = value; // Öğrenci numarasına değer atanır.
                }
                else
                {
                    // Eğer öğrenci numarası boş veya null ise uyarı mesajı yazdırılır.
                    Console.WriteLine("Numarası boş olamaz!");
                }
            }
        }
    }
}
