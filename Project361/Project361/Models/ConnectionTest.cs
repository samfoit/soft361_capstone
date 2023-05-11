using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Duende.IdentityServer.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


//namespace project361
//{
//    public enum Database
//    {
//        Cards
//    }

//    public class DBConnection
//    {
//        public static MySqlConnection GetConnectionString(Database db)
//        {
//            string connectionString = "server=localhost;port=3306;user=root;password=pranav2903;database=cards";
//            MySqlConnection connection = new MySqlConnection(connectionString);
//            if (db == Database.Cards)
//            {

//                connection.Open();

//                connectionString += "cards";
//                Console.Write("connetion is open");
//            }
//            else
//            {
//                throw new ArgumentException("Invalid database enum value.");
//            }


//            return connection;
//        }
//    }
//}
//public class ConnectionTest
//{
//    public static void TestConnection()
//    {

//        string connectionString = "server=localhost;port=3306;user=root;password=pranav2903;database=cards";
//        var connection = new MySqlConnection(connectionString);


//        try
//        {
//            connection.Open();
//            Console.WriteLine("Successfully connected to database.");
//        }
//        catch (MySqlException ex)
//        {
//            Console.WriteLine("Error: {0}", ex.ToString());
//        }

//    }


//namespace Project361db {
//    public class ConnectionTest
//    {
//        public enum Database
//        {
//            Trytest,
//            Cards
//        }

//        public static MySqlConnection GetConnectionString(Database cards)
//        {
//            string connectionString = "server=localhost;port=3306;user=root;password=pranav2903;database=cards";
//            MySqlConnection connection = new MySqlConnection(connectionString);

//            connection.Open();
//            Console.WriteLine("Successfully connected to database.");
//            connection.Close();


//            return connection;
//        }
//    }
//}
//using MySql.Data.MySqlClient;
//using System;

namespace Project361db
{
    public class ConnectionTest

    {
        public static MySqlConnection GetConnectionString()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=pranav2903;database=cards";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            Console.WriteLine("Successfully connected to database.");
            connection.Close();

            return connection;
        }
    }

    class Program
    {
        static void Main()
        {
            ConnectionTest.GetConnectionString();
            Console.WriteLine("Connection test completed.");
        }
    }
}


