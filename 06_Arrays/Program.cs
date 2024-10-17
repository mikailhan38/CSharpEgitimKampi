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
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Tahran";
            //cities[2] = "Ankara";
            //cities[3] = "Kahire";
            //cities[4] = "Bağdat";


            #endregion
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Beyaz", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(i+1);
            //    }
            //}
            #endregion
            #region Dizi Metotları
            //string[] customers = { "ali", "mikail", "muhammed", "fatıma" };
            //int index = Array.IndexOf(customers, "mikail");
            //Console.WriteLine(index);
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine("Dizinin En Büyük Elemanı :"+numbers.Max()+" Dizinin En KÜçük Elemanı :"+numbers.Min());
            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri giriniz.");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            #endregion
            Console.Read();
        }
    }
}
