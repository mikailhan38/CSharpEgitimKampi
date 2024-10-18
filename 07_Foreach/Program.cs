using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] cities = { "kayseri", "istanbul", "tahran", "bağdat" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //int[] numbers = { 1, 22, 33, 45, 120,313,1414};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] numbers = { 1, 22, 33, 45, 120, 313, 1414 };
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion
            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("*****C# Eğitim Kampı Uygulaması*****");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sınıfınızda kaç öğrenci bulunmaktadır");
            int studentCount =int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            string[] studentsName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin adını giriniz :");
                studentsName[i] = Console.ReadLine();

                double totalExamResult = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsName[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz :");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamAvg[i] = totalExamResult/3;

            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentsName[i]} adlı öprenicinin ortalaması :{studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentsName[i]} adlı öğrenci dersten geçti");
                }
                else
                {
                    Console.WriteLine($"{studentsName[i]} adlı ögrenci dersten kaldı");
                }
                Console.WriteLine("-----------------------------------------");
            }
            #endregion
            Console.Read();
        }
    }
}
