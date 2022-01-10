using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pu_012_ADO.NET_intro
{
    public class Queries
    {
        public static object GetUserByEmail(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT name FROM Users WHERE email = 'a.neque@icloud.net'", connection);
            var result = cmd.ExecuteScalar();
            return result;
        }

        public static void InsertUser(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT Users VALUES('Alan', 'Clofford', '098-785-45-32', 'alanc@email.com', 25)";
            int row = cmd.ExecuteNonQuery();
            Console.WriteLine($"INSERT row affected: {row}");
        }

        public static void DeleteUser(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE Users WHERE UsersID = '2'";
            int row = cmd.ExecuteNonQuery();
            Console.WriteLine($"DELETE row affected: {row}");
        }

        public static void GetAllUsers(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users;";
            SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    for(int i = 0; i < reader.FieldCount; i++)
            //    {
            //        Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
            //    }
            //    Console.WriteLine(new string('_', 30));
            //}
            while (reader.Read())
            {
                if (!reader.IsDBNull(1))
                {
                    Console.WriteLine(
                       reader["UsersID"] + " " +
                       reader["name"] + " " +
                       reader["surname"]
                   );
                }

            }
            reader.Close();
        }

        public static void UpdateUser(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET age = '11' WHERE UsersID = '7'";
            try
            {
                cmd.Transaction = connection.BeginTransaction();
                int row = cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine($"UPDATE {row}");
            }
            catch (Exception ex)
            {
                cmd.Transaction.Rollback();
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetUserById(SqlConnection connection)
        {
            var cmdStr = "SELECT * FROM Users WHERE UsersID = @UsersID";
            Console.WriteLine("Enter iser id");
            var userID = Console.ReadLine();
            SqlCommand cmd = new SqlCommand(cmdStr, connection);
            cmd.Parameters.AddWithValue("UsersID", userID);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine("{0} : {1}", reader.GetName(i), reader[i]);
                }
            }
            reader.Close();
        }
    }
}
