using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //For(x;y;z)
            //x: Başlangıç değeri
            //y: Bitiş değeri
            //z: Artış-Azalış değeri

            //int i;
            //for (i=1; i <= 10; i++)
            //{
            //    Console.WriteLine("Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i=3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Tekrar miktarını giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i = 0; i<=100; i++)
            //{
            //    if(i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i=0; i<=10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine("Toplam Değer: " + totalValue);

            //int totalValue = 0;
            //for (int i = 0;  i<= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue+=i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------------------");
            //Console.WriteLine("Toplam Değer: " + totalValue);


            //int sum = 0;
            //for (int i=1; i<=50; i++)
            //{
            //    if (i%7 == 0)
            //    {
            //        sum++;
            //    }
            //}
            //Console.WriteLine("Toplam 7'ye bölünen sayı adedi: " + sum);

            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ". saatteki bakteri sayısı: " + bakteri);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam Değer: " + sum);



            #endregion

            #region Örnek

            //Console.Write("Basamaklarını toplamak istediğiniz sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum = 0;
            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number % 100) / 10;
            //sum = ones + tens + hundreds;
            //Console.WriteLine("Girilen sayının basamakları toplamı: " + sum);

            #endregion

            Console.Read();
        }
    }
}
