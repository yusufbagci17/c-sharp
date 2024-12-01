using System;

namespace Hafta_6
{
    public class Pokemon
    {
        public string Isim {  get; set; }
        public string Tur {  get; set; }
        public string SaldiriTuru { get; set; }
        public int SaldiriGucu { get; set; }
        public int SavunmaGucu { get; set; }
        public int Saglik { get; set; }
        public int EnerjiPuani { get; set; }

        // Parametresiz Kurucu Metot
        public Pokemon()
        {
            
        }
        
        // Parametreli Kurucu Metot
        public Pokemon(string Isim, string tur, string saldiriTuru, int saldiriGucu, int savunmaGucu, int saglik, int enerjiPuani) 
        { 
            this.Isim = Isim;
            Tur = tur;
            SaldiriTuru = saldiriTuru;
            SaldiriGucu = saldiriGucu;
            SavunmaGucu = savunmaGucu;
            Saglik = saglik;
            EnerjiPuani = enerjiPuani;
        }
        public void Saldir(Pokemon rakip)
        {
            if (EnerjiPuani >= 10)
            {
                int hasar = SaldiriGucu - rakip.SavunmaGucu;
                if(SaldiriTuru=="Yıldırım Oku"&& rakip.Tur == "Su")
                {
                    hasar *= 2;
                }
                hasar = (hasar < 0) ? 0 : hasar;
                EnerjiPuani -= 10;
                rakip.Saglik -= hasar;
                Console.WriteLine($"{Isim}, {rakip.Isim} Pokemon'una {hasar} hasar verdi...");
                rakip.HasarAl(hasar);


            }
            else
            {
                Console.WriteLine($"{Isim}, yeterli enerjiye sahip değil. Enerji puanı: {EnerjiPuani}");
            }
        }
        public void HasarAl(int hasar)
        {
            if (Saglik <= 0)
            {
                Saglik = 0;
                Console.WriteLine($"{Isim}, mağlup oldu!!");
            }
            else
            {
                Console.WriteLine($"{Isim}'ın kalan sağlığı: {Saglik}");
            }
        }
        public void Yenilen()
        {
            EnerjiPuani += 10;
            Console.WriteLine($"{Isim} yenilendi, enerji durumu {EnerjiPuani}'a yükseldi.");
        }
    }
}
