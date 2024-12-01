using System;

namespace _9.hafta_3.ornek
{
    public class Calisanlar
    {
        // Ad için private alan.
        private string Ad;

        // Ad property'si.
        public string ad
        {
            get { return string.IsNullOrWhiteSpace(Ad) ? "Belirtilmedi" : Ad; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Ad = value;
                }
                else
                {
                    Console.WriteLine("Ad boş olamaz!");
                }
            }
        }

        // Soyad için private alan.
        private string SOYAD;

        // Soyad property'si.
        public string soyad
        {
            get { return string.IsNullOrWhiteSpace(SOYAD) ? "Belirtilmedi" : SOYAD; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    SOYAD = value;
                }
                else
                {
                    Console.WriteLine("Soyad boş olamaz!");
                }
            }
        }

        // Maaş için private alan.
        private decimal MAAS;

        // Maaş property'si.
        public decimal maas
        {
            get { return MAAS; }
            set
            {
                if (value > 0)
                {
                    MAAS = value;
                }
                else
                {
                    Console.WriteLine("Maaş sıfırdan büyük olmalıdır!");
                }
            }
        }

        // Çalışan bilgilerini ekrana yazdıran metod.
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad: {ad}, Soyad: {soyad}, Maaş: {maas:C}");
        }
    }

}