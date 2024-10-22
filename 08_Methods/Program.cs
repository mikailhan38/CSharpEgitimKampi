using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Mikail LALE");
            //    Console.WriteLine("Muhammed Taki GÜL");
            //    Console.WriteLine("Tuncay MENEKŞE");
            //    Console.WriteLine("Şükrü ÇİÇEK");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion
            #region Geriye değer döndürmeyen string parametreli metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mikail LALE");
            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri :"+name+" Soyadı :"+surname);

            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Mikail", "LALE");

            #endregion
            #region Geriye değer döndürmeyen int parametreli metotlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(12, 52, 63);

            #endregion
            #region Geriye Değer Döndüren String Metotlar
            //string CustomerName()
            //{
            //    return "Buse YILDIZ";
            //}
            //CustomerName();
            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "YILDIZ";
            //    return name+" "+surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = " Ülke :"+countryName+" \n Başkent :"+capital+" \n Bayrak Rengi :"+flagColor;
            //    return  cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz :");
            //x = Console.ReadLine();
            //Console.Write("Başkentin adınız giriniz :");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz :");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion
            #region Örnek
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2  + exam3) / 3;
                if (result > 50)
                {
                    return student + " isimli öğrenci dersten geçti. Ortalama notu :" + result;
                }
                else
                {
                    return student + " isimli öğrenci dersten geçemedi. Ortalam notu :" + result;
                }
            }
            Console.WriteLine(ExamResult("Mikail LALE", 75, 80, 68));
            Console.WriteLine(ExamResult("Ali YILDIZ", 35, 55, 40));
            #endregion
        }
    }
}
