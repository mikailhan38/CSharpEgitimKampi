using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz.");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Hatalı");
            //}
            //Console.ReadLine();
            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz");
            //capital = Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Doğru girildi");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş");
            //}
            //int number;
            //Console.Write("Sayı giriniz :");
            //number=int.Parse(Console.ReadLine());
            //if (number == 2)
            //{
            //    Console.WriteLine("Sayı Doğru Girildi");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}
            //int exam1, exam2, exam3, avarage;
            //string result="";
            //Console.Write("1. Sınav Notu :");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notu :");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notu :");
            //exam3 = int.Parse(Console.ReadLine());
            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalaması :" + avarage);
            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "Vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Orta";
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "İyi";
            //}
            //if (avarage > 84)
            //{
            //    result = "Çok İyi";
            //}
            //else
            //{
            //    result = "Hata";
            //}
            //Console.WriteLine(result);
            //string city;
            //Console.Write("Lütfen şehir igirşi yapınız");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "kayseri")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir bulunmuyor");
            //}
            //Console.WriteLine("Lütfen Kullanıcı adını giriniz");
            //string username;
            //username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            #endregion
            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Write("1. Sayıyı giriniz.");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz.");
            //int number2=int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("Birinci sayının 2. sayıya bölümünden kalan :"+result);


            //Console.Write("1. Sayıyı giriniz.");
            //int number1 =int.Parse( Console.ReadLine());
            //if (number1 % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion
            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.WriteLine("Lütfen Takım sembolü giriniz.");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else
            //{
            //    Console.WriteLine("Bilinmeyen hata");
            //}
            #endregion
            #region Örnek Program
            //Console.WriteLine("*****Resturant Menu*****");
            //Console.WriteLine("---------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------");
            //string menuItem;
            //Console.WriteLine("Menu Detayını görmek için numara giriniz :");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("*****Ana Yemekler*****");
            //    Console.WriteLine("1-Soslu Tavuk");
            //    Console.WriteLine("2-Kızatma Tava");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("*****Çorbalar*****");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-İşkembe Çorbası");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("*****Pizzalar*****");
            //    Console.WriteLine("1-Mantarlı");
            //    Console.WriteLine("2-Akdeniz");
            //    Console.WriteLine("3-Margarita");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("*****İçecekler*****");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Su");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("*****Tatlılar*****");
            //    Console.WriteLine("1-Treleçe");
            //    Console.WriteLine("2-Kazandini");
            //    Console.WriteLine("3-Sütlaç");
            //}

            #endregion
            #region Switch Case
            //Console.WriteLine("1-12 sayı giriniz.");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak");
            //        break;
            //    case 2: Console.WriteLine("Şubat");
            //        break;
            //    case 3: Console.WriteLine("Mart");
            //        break;
            //    case 4: Console.WriteLine("Nisan");
            //        break;
            //    case 5: Console.WriteLine("Mayıs");
            //        break;
            //    case 6: Console.WriteLine("Haziran");
            //        break;
            //    case 7: Console.WriteLine("Temmuz");
            //        break;
            //    case 8: Console.WriteLine("Ağustos");
            //        break;
            //    case 9: Console.WriteLine("Eylül");
            //        break;
            //    case 10: Console.WriteLine("Ekim");
            //        break;
            //    case 11: Console.WriteLine("Kasım");
            //        break;
            //    case 12: Console.WriteLine("Aralık");
            //        break;

            //    default: Console.WriteLine("Hatalı Giriş");
            //        break;
            //}
            #endregion
            #region Hesap Makinesi
            //int number1, number2, result;
            //char symbol;
            //Console.WriteLine("1. Sayıyı Giriniz");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. Sayıy Giriniz.");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(" Toplama Yapmak için +\n Çıkartma işlemi için -\n Çarpma işlemi için *\n Bölme işlemi için /\n Basınız.");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':result=number1 + number2; Console.Write("Sonuç :" + result); break;
            //    case '-':result=number1-number2; Console.Write("Sonuç :" + result); break;
            //    case '*':result=number1*number2; Console.Write("Sonuç :" + result); break;
            //    case '/':result=number2/number1; Console.Write("Sonuç :"+result); break;
            //    default: Console.WriteLine("Hatalı seçim yaptınız");
            //        break;
            //}

            #endregion
        }
    }
}
