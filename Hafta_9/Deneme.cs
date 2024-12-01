using System; // Temel sistem sınıflarını kullanmamızı sağlar.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_9
{
    public class Deneme
    {
        // "isim" alanı private olarak tanımlanmıştır, böylece doğrudan dışarıdan erişim engellenmiştir.
        private string isim;

        // isim alanına erişim için bir getter metodu (değeri döndüren) tanımlanmış.
        public string GetIsim()
        {
            return isim; // isim değerini geri döndürür.
        }

        // isim alanını dışarıdan değiştirmek için bir setter metodu tanımlanmış.
        public void SetIsim(string İsim)
        {
            isim = İsim; 
        }

        // soyad alanı da kapsüllenmiş. Bu kez property (özellik) ile tanımlanmış.
        private string soyad;

        // Property: Getter ve Setter ile soyad alanına kontrollü erişim sağlanıyor.
        public string Soyad
        {
            get { return soyad; } // Getter, soyad değerini döndürür.
            set { soyad = value; } // Setter, soyad değerini atar.
        }

        // Aşağıda TC Kimlik Numarası (TCKN) için özel bir property kullanılmış.
        private string tckn; // TCKN değeri private olarak saklanır.

        // TCKN'ye erişim ve validasyon işlemleri için bir property tanımlanmış.
        public string TCKN
        {
            get
            {
                // Getter, TCKN'nin ilk 3 hanesini ve son 2 hanesini gösterir.
                // Ortadaki 6 haneyi gizleyerek güvenliği artırır.
                return $"{tckn.Substring(0, 3)}******{tckn.Substring(9, 2)}";
            }
            set
            {
                // Setter: TCKN değerini kontrol eder ve doğrular.

                if (value.Length == 11) // TCKN'nin uzunluğu 11 olmalı.
                {
                    if (long.TryParse(value, out _)) // TCKN'nin sadece rakamlardan oluştuğunu kontrol eder.
                    {
                        int toplam = 0;

                        // TCKN'nin ilk 10 hanesinin toplamını alır.
                        for (int i = 0; i < value.Length - 1; i++)
                        {
                            toplam += int.Parse(value[i].ToString()); // Karakterleri sayıya çevirip toplar.
                        }

                        // Son hane (11. karakter), toplamın 10'a bölümünden kalan ile eşit olmalı.
                        if (toplam % 10 == int.Parse(value[10].ToString()))
                        {
                            tckn = value; // Eğer geçerli bir TCKN ise, tckn alanına atanır.
                        }
                    }
                    else
                    {
                        // Eğer sadece rakamlardan oluşmuyorsa, hata mesajı yazdırılır.
                        Console.WriteLine("Rakamlardan oluşmalı");
                    }
                }
                else
                {
                    // Eğer uzunluk 11 değilse, hata mesajı yazdırılır.
                    Console.WriteLine("11 Haneden oluşmalı");
                }
            }
        }
    }
}
