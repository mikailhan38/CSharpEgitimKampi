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
            #region For Dongusu
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Yazınız.");
            //int finishValue=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet  "+i);
            //}

            #endregion
            #region For Döngüsü ile Karar Yapıları
            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalValue = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    totalValue += 1;
            //}
            //Console.WriteLine(totalValue);
            //int totalValue = 0;
            //for (int i = 1; i <=20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(totalValue);
            //int count =0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i+". Saatteki bakteri sayısı :"+bakteri);
            //}

            #endregion
            #region While
            //int i= 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}
            //int i = 1;
            //while (i<=10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //int i = 1;
            //int sum = 0;
            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion
            #region Örnek Sınav Sorusu
            //Console.WriteLine("Üç Basamaklı bir sayı giriniz.");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum ;
            //hundreds = number / 100;
            //tens = (number - (hundreds * 100)) / 10;
            //ones = (number - (hundreds * 100) - (tens * 10));
            //sum=hundreds+tens+ones;
            //Console.WriteLine(sum);
            #endregion
            Console.Read();
        }
    }
}
