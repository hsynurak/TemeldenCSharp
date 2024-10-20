using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //Method olması için sonunda () şeklinde parantez açıp kapatılması gerekli.
            //Geriye değer döndürmezler 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali");
            //    Console.WriteLine("Veli");
            //    Console.WriteLine("Deli");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine("Toplam: " + z);
            //}
            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ali");

            //void CustomerCard(string name, string surname, int age)
            //{
            //    Console.WriteLine("Müşteri Adı: " + name);
            //    Console.WriteLine("Müşteri Soyadı: " + surname);
            //    Console.WriteLine("Müşteri Yaşı: " + age);
            //}
            //CustomerCard("Ali", "Veli", 25);

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //Sum(5, 10, 15);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Ali";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Veli";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion


            #region Geriye Değer Döndüren Parametreli Metotlar
            
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = countryName + " " + capital + " " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adı: ");
            //x = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Başkent: ");
            //y = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Bayrak Rengi: ");
            //z = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine(CountryCard(x,y,z));

            //int Sum (int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(5, 10));
            //Console.WriteLine(Sum(20, 29));



            #endregion
            
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci Geçti. Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci Kaldı. Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 50, 60, 70));

            Console.Read();


        }
    }
}
