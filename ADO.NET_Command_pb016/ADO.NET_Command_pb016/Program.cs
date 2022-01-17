using Microsoft.Data.SqlClient;
using System;
using System.Configuration;

namespace ADO.NET_Command_pb016
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string connectionString = @"Data Source=A33PC16\SQLEXPRESS; Initial Catalog=pu012-ado;Integrated Security=True;TrustServerCertificate=True;";*/

            //string connectionString = @"Data Source=10.7.101.197;Initial Catalog=pu012_Ado;User ID=test;Password='1';TrustServerCertificate=True;";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        Console.WriteLine($"Connection status: {connection.State}");
            //        Console.WriteLine($"Database: {connection.Database}");

            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        connection.Close();
            //        Console.WriteLine($"Connection status: {connection.State}");
            //    }
            //}

            /*SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = @"10.7.101.197";
            connectionStringBuilder.InitialCatalog = "pu012_Ado";
            connectionStringBuilder.UserID = "test";
            connectionStringBuilder.Password = "1";
            connectionStringBuilder.TrustServerCertificate = true;

            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine($"Connection status: {connection.State}");
                    Console.WriteLine($"Database: {connection.Database}");

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine($"Connection status: {connection.State}");
                }
            }*/

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectToStepDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                    Console.WriteLine(connection.Database);
                    Console.WriteLine(connection.ConnectionString);
                    Console.WriteLine("==============Qieries============");
                    //var result = Queries.GetUserByEmail(connection);
                    //Console.WriteLine($"Get user by emil: {result}");
                    //Queries.InsertUser(connection);
                    //Queries.DeleteUser(connection);
                    //Queries.GetAllUsers(connection);
                    //Queries.UpdateUser(connection);
                    Queries.GetUserByID(connection);
                    Console.WriteLine("==============Qieries============");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
