using System;
using System.Collections.Generic;

namespace Hafta_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziler, İki boyutlu, listeler, metotlar, params, lambda

            /*
            // Dizi
            byte[] dizi = { 10, 20, 30, 40};
            byte[] dizi2 = new byte[4];
            int[,] matris = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };
            int[,,] cokBoyutlu = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
            for (byte i = 0; i < dizi2.Length; i++)
            {
                dizi2 [i] = Convert.ToByte(Console.ReadLine());
            }
            foreach (byte item in dizi2)
            {
                Console.WriteLine(item);
            }
            
            for (int i = 0; i < cokBoyutlu.GetLength(0); i++)
            {
                for (int j = 0; j < cokBoyutlu.GetLength(1); j++)
                {
                    for (int k = 0; k < cokBoyutlu.GetLength(2); k++)
                    {
                    Console.Write(cokBoyutlu[i,j,k]+"\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */

            /*
            // List
            List<string> isimler = new List<string>();
            isimler.Add("Barış");
            isimler.Add("Yaser");
            isimler.Add("Diyar");
            isimler.Add("Coşkun");
            isimler.Remove("Coşkun");
            isimler.RemoveAt(0);
            isimler.Insert(0, "Hüseyin");
            Console.WriteLine(isimler.Contains("Coşkun"));
            Console.WriteLine(isimler.Contains("Hüseyin"));
            isimler.ForEach(x => Console.WriteLine(x));
            isimler.Sort();
            isimler.ForEach(x => Console.WriteLine(x));
            isimler.Remove("Hüseyin");
            Console.WriteLine(isimler[0]);

            //foreach (string s in isimler) {
            //    Console.WriteLine(s);
            //}
            */

            EkranaYaz();
            EkranaYaz("Barış");
            int toplam = Toplama(2, 3);
            Console.WriteLine(toplam);
            int toplam2 = Toplama(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(toplam2);
            int[] dizi = { 1, 2, 3, 4 };
            int[] dizi2 = KareAl(dizi);
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Topla(15,35));
            Console.WriteLine(KareHesabı(7));
            Uyari("Barış");
            Console.ReadKey();
        }
        //Lambda Fonksiyonlar
        static Func<int,int,int> Topla = (x,y) => (x+y);
        static Func<int, int> KareHesabı = x => (x * x);
        static Action<string> Uyari = isim => Console.WriteLine(isim + " Uyarı");



        // Parametre Almayan - Geri Değer Döndürmeyen
        static void EkranaYaz() {
            Console.WriteLine("Merhaba Dünya");
        }
        // Parametre Alan - Geri Değer Döndürmeyen
        static void EkranaYaz(string  isim) {
            Console.WriteLine("Merhaba " + isim);
        }
        // Parametre Alan - Geri Değer Döndüren
        static int Toplama(int a, int b) {
        return a + b;
        }
        // Parametreler Alan - Geri Değer Döndüren

        static int Toplama(params int[] degerler) {
            int toplam = 0;
            foreach (var item in degerler)
            {
                toplam += item;
            }
            return toplam;
        }
        // Parametre Olarak Dizi Alan - Geri Dizi Döndüren
        static int[] KareAl(int[] dizi)
        {
            int[] dizi2 =new int[dizi.Length];
            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi2[i] = dizi[i] * dizi[i];
            }
            return dizi2;
        }



    }
}
