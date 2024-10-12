using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If

            //Console.Write("Lütfen şifreinizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkent ismi giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülke ismi giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Başkent ve ülke doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Başkent ve ülke yanlış");
            //}

            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "HATA!";

            //Console.Write("1. sınav notunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sınav notunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. sınav notunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması: " + average + " ");

            //if (average > 0 & average <= 50)
            //{
            //    result = "Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "İyi";
            //}
            //if (average > 84 )
            //{
            //    result = "Pekiyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Bir şehir ismi giriniz: ");
            //city = Console.ReadLine();
            //if (city == "ankara" | city == "adana" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Başkent");
            //}
            //else
            //{
            //    Console.WriteLine("Bilinmeyen şehir");
            //}

            //Console.Write("Kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.Write("Kullanıcı adı doğru");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir.");
            //}

            #endregion

            #region Örnek Proje Uygyulaması

            //Console.WriteLine("***** Eğitim Kapmı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------");
            //Console.WriteLine();

            //Console.Write("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //string menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- ANA YEMEKLER --------");
            //    Console.WriteLine("YEMEK 1");
            //    Console.WriteLine("YEMEK 2");
            //    Console.WriteLine("YEMEK 3");
            //    Console.WriteLine("YEMEK 4");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- ÇORBALAR --------");
            //    Console.WriteLine("ÇORBA 1");
            //    Console.WriteLine("ÇORBA 2");
            //    Console.WriteLine("ÇORBA 3");
            //    Console.WriteLine("ÇORBA 4");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- PİZZALAR --------");
            //    Console.WriteLine("PİZZA 1");
            //    Console.WriteLine("PİZZA 2");
            //    Console.WriteLine("PİZZA 3");
            //    Console.WriteLine("PİZZA 4");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- İÇECEKLER --------");
            //    Console.WriteLine("İÇECEK 1");
            //    Console.WriteLine("İÇECEK 2");
            //    Console.WriteLine("İÇECEK 3");
            //    Console.WriteLine("İÇECEK 4");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- TATLILAR --------");
            //    Console.WriteLine("TATLI 1");
            //    Console.WriteLine("TATLI 2");
            //    Console.WriteLine("TATLI 3");
            //    Console.WriteLine("TATLI 4");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı giriş yaptınız."); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("İşlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+' : result = number1 + number2; Console.WriteLine(result); break;
            //    case '-': result = number1 - number2; Console.WriteLine(result); break;
            //    case '*': result = number1 * number2; Console.WriteLine(result);  break;
            //    case '/': result = number1 / number2; Console.WriteLine(result); break;
            //}

            #endregion


            Console.ReadLine();
        }
    }
}
