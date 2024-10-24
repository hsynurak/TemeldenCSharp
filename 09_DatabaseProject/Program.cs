﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net ==> c# özelliklerinin kullanılmasına olanak sağlar

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen Girmek İstediğiniz Tablo Numarasını Giriniz: ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------");

            SqlConnection connection = new SqlConnection
                (
                    "Data Source=DESKTOP-SHJ259C\\SQLEXPRESS;" +
                    "initial Catalog=EgitimKampiDb;" +
                    "integrated security=true"
                );
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
