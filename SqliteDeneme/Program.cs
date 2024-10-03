// See https://aka.ms/new-console-template for more information
using Microsoft.Data.Sqlite;

Console.WriteLine("Hello, World!");
using (SqliteConnection connection = new SqliteConnection("Data Source=ogrenci.db"))
{
    connection.Open();

    string selectSql = "SELECT * FROM kullanicilar";

    using (SqliteCommand command = new SqliteCommand(selectSql, connection))
    {
        using (SqliteDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string ad = reader.GetString(1);
                string soyad = reader.GetString(2);
                string email = reader.GetString(3);
                string kayitTarihi = reader.GetString(4);

                Console.WriteLine($"ID: {id}, Ad: {ad}, Soyad: {soyad}, Email: {email}, Kayıt Tarihi: {kayitTarihi}");
            }
        }
    }
}
Console.WriteLine("Bağlantı Başarılı");
