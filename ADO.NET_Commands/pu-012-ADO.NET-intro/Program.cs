using Microsoft.Data.SqlClient;
using System;
using System.Configuration;

namespace pu_012_ADO.NET_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //============================Example1========================//
            //string connectionString = @"Data Source=A33PC16\SQLEXPRESS;Initial Catalog=pu012-ado; Integrated Security=True;TrustServerCertificate=True";

            //string connectionString = @"Data Source=10.7.101.197;Initial Catalog=pu012_Ado;User ID=test;Password=1;TrustServerCertificate=True;";

            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine(connection.State);
                }
            }*/
            //============================Example1========================//
            //============================Example2========================//
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
                    Console.WriteLine(connection.State);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine(connection.State);
                }
            }*/
            //============================Example2========================//
            //============================Example3========================//
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectToStepDB"].ConnectionString;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                    Console.WriteLine(connection.Database);
                    Console.WriteLine(connection.ConnectionString);
                    Console.WriteLine("===============Queries==================");
                    /*var result = Queries.GetUserByEmail(connection);
                    Console.WriteLine($"Result => {result}");*/
                    //Queries.InsertUser(connection);
                    //Queries.DeleteUser(connection);
                    //Queries.GetAllUsers(connection);
                    //Queries.UpdateUser(connection);
                    Queries.GetUserById(connection);
                    Console.WriteLine("========================================");
                    
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
            //============================Example3========================//

        }
    }
}
