using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Command_pb016
{
    public class Queries
    {
        public static object GetUserByEmail(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT name FROM Users WHERE email = 'lobortis.class.aptent@aol.ca'", connection);
            var result = cmd.ExecuteScalar();
            return result;
        }

        public static void InsertUser(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT Users VALUES('Jack', 'Hanson', '097-785-45-21', 'jackh@email.com', 34)";
            int row = cmd.ExecuteNonQuery();
            Console.WriteLine($"INSERT row affected: {row}");
        }

        public static void DeleteUser(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE Users WHERE UsersID = '3'";
            int row = cmd.ExecuteNonQuery();
            Console.WriteLine($"DELETE row affected: {row}");
        }

        public static void GetAllUsers(SqlConnection connection)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM USers;";
            SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    for(int i = 0; i < reader.FieldCount; i++)
            //    {
            //        Console.WriteLine(reader.GetName(i) + " : " + reader[i]);
            //    }
            //    Console.WriteLine(new string('_', 15));
            //}

          

                while (reader.Read())
                {
                    if (!reader.IsDBNull(5)) // 5 Це індекс уолонки плчинається з 0
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
            cmd.CommandText = "UPDATE Users SET age = '12' WHERE UsersID = '7'";
            try
            {
                cmd.Transaction = connection.BeginTransaction();
                int row = cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine($"UPDATE row affected: {row}");
            }
            catch (Exception ex)
            {
                cmd.Transaction.Rollback();
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetUserByID(SqlConnection connection)
        {
            var commandStr = "SELECT * FROM Users WHERE UsersID = @UsersID";
            Console.WriteLine("Enter user id");
            var userID = Console.ReadLine();
            SqlCommand cmd = new SqlCommand(commandStr, connection);
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
