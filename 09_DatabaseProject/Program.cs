using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tableNumber;
            Console.WriteLine("----- C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi -----");
            Console.WriteLine("\n\n");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen giriş yapmak istediğiniz tablo numarasını giriniz");

            tableNumber = Console.ReadLine();

            Console.WriteLine("------------------------------------");
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Categories", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
