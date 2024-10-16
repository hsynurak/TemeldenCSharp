using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            // 1: Değişken Türü
            // 2: Değişken Adı
            // 3: In
            // 4: Liste, Dizi

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 65, 98, 12, 34, 56, 23, 45, 67, 89 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 65, 98, 12, 34, 56, 23, 45, 67, 89 };
            //foreach (int number in numbers)
            //{
            //    if (number%2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 65, 98, 12, 34, 56, 23, 45, 67, 89 };
            //int total = 0;
            //foreach(int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int> 
            //{ 
            //    45, 78, 65, 98, 12, 34, 56, 23, 45, 67, 89 
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}




            //Console.Read();

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** SINAV UYGULAMASI *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");

            ////Öğrenci Sayısını Kullanıcıdan Al
            //Console.Write("Öğrenci Sayısını Giriniz: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------------");
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAverage = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrenci Adını Giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;

            //    //her öğrenci için 3 sınav notu alalım
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        totalExamResult += double.Parse(Console.ReadLine());
            //    }
            //    studentExamAverage[i] = totalExamResult / 3;
            //}

            ////öğrenci ortalamaları ve kalm-geçme durumları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalama notu: {studentExamAverage[i]})");
            //    if (studentExamAverage[i] >= 50)
            //    {
            //        Console.WriteLine("Geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kaldı");
            //    }
            //}


            //Console.Read();
            #endregion
        }
    }
}
