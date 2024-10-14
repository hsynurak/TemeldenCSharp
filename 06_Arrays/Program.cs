using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            //Aynı türde verilerin bir araya getirilmesi sonucu diziler oluşur.
            //sarıi yeşil, mavi
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[DiziUzunluğu];

            //string[] colors = new string[4];
            //colors[0] = "Sarı";
            //colors[1] = "Yeşil";
            //colors[2] = "Mavi";
            //colors[3] = "Kırmızı";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Ankara";
            //cities[1] = "İstanbul";
            //cities[2] = "İzmir";
            //cities[3] = "Adana";
            //cities[4] = "Antalya";
            //Console.WriteLine(cities[4]);

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya" };
            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizi Elemanlarını Ekrana Yazdırma

            //string[] colors = { "Sarı", "Yeşil", "Mavi", "Kırmızı" };
            //for (int i=0; i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = {1, 2, 3,  4, 5, 6, 7, 8, 9, 10 };
            //for (int i=0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '&' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //EN BUYUK DEGERI BULMA
            //int[] myArrays = { 47, 85, 95, 41, 25, 635, 789, 86, 199 };
            //int max = myArrays[0];
            //for (int i=1; i<=myArrays.Length-1; i++)
            //{
            //    if (myArrays[i] > max)
            //    {
            //        max = myArrays[i];
            //    }
            //}
            //Console.WriteLine("En büyük değer: " + max);


            //int[] myArrays = { 47, 85, 95, 41, 25, 635, 789, 86, 199 };
            //Array.Sort(myArrays);
            //for (int i = 0; i < myArrays.Length; i++)
            //{
            //    Console.WriteLine(myArrays[i]);
            //}

            //int[] myArrays = { 47, 85, 95, 41, 25, 635, 789, 86, 199 };
            //Array.Sort(myArrays);
            //Array.Reverse(myArrays);
            //for (int i = 0; i < myArrays.Length; i++)
            //{
            //    Console.WriteLine(myArrays[i]);
            //}



            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Veli", "Deli", "Mehmet", "Ahmet" };
            //int index = Array.IndexOf(customers, "Deli");
            //Console.WriteLine("Index: " + index);

            //int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int maxValue = numbers.Max();
            //int minValue = numbers.Min();
            //Console.WriteLine("Max Value: " + maxValue);
            //Console.WriteLine("Min Value: " + minValue);

            //string[] cities = new string[5];
            //for (int i=0; i< cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Şehirleriniz: ");
            //for (int j = 0; j < cities.Length; j++)
            //{
            //    Console.WriteLine(cities[j]);
            //}


            #endregion
            Console.Read();

        }
    }
}
