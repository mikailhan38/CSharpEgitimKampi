using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            Console.WriteLine("--------Menü Sipariş İşlem Paneli--------");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            #region Kategori Ekleme


            //Console.Write("Eklemek istediğiniz Kategori adını giriniz :");
            //string categoryName=Console.ReadLine();

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Categories (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori baraşılı bir şekilde eklendi.");

            #endregion
            #region Ürün Ekleme
            //string productName;
            //decimal productPrice;
            //bool productStatus;
            //Console.Write("Ürün adı :");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı :");
            //productPrice=decimal.Parse(Console.ReadLine());
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Products (ProductName, ProductPrice, ProductStatus) values (@productName,@productPrice, @productStatus) ",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", 1);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün baraşılı bir şekilde eklendi");

            #endregion
            #region Ürün Listeleme İşlemi
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from Products",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" - ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion
            #region Ürün silme işlemi
            //Console.Write("Silinecek ürün id :");
            //int productId = int.Parse(Console.ReadLine());
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from Products Where ProductId = @productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı");
            #endregion
            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncelleme yapmak istediğiniz ürünün Id numarasını giriniz :");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Ürün Adı :");
            //string productName= Console.ReadLine();
            //Console.Write("Ürün Fiyatı :");
            //double productPrice = double.Parse(Console.ReadLine());
            //connection.Open();
            //SqlCommand command = new SqlCommand("update Products Set ProductName = @productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı");
            #endregion
            Console.ReadLine();
        }
    }
}
