using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--- Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine("--- Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("--- Çilek Birim Fiyatı: " + strawberryPrice);
            //Console.WriteLine("--- Patates Birim Fiyatı: " + potatoPrice);
            //Console.WriteLine("--- Domates Birim Fiyatı: " + tomatoPrice);

            //double appleGram = 1.245;
            //double orangeGram = 2.650;
            //double strawberryGram = 0.750;
            //double potatoGram = 4.859;
            //double tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Elma Toplam Fiyat: " + tomatoTotalPrice);
            //Console.WriteLine("Portakal Toplam Fiyat: " + orangeTotalPrice);
            //Console.WriteLine("Çilek Toplam Fiyat: " + strawberryTotalPrice);
            //Console.WriteLine("Patates Toplam Fiyat: " + potatoTotalPrice);
            //Console.WriteLine("Domates Toplam Fiyat: " + tomatoTotalPrice);
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavye Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string pasengerName, pasengerSurname;

            //Console.Write("Yolcu Adı: ");
            //pasengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //pasengerSurname = Console.ReadLine();

            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu: " + pasengerName + " " + pasengerSurname);

            #endregion

            #region Klavyeden Veri Girişleri Tam Sayı ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız ayakkabı sayısını giriniz");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız bilgisayar sayısını giriniz");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız TV sayısını giriniz");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine("Toplam tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Veri Girişi

            //double exam1, exam2, exam3, resault;
            //Console.Write("1. sınav notunu girin: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. sınav notunu girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. sınav notunu girin: ");
            //exam3 = double.Parse(Console.ReadLine());

            //resault = (exam1 +  exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + resault);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Belirtiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion

            Console.ReadLine();
        }
    }
}