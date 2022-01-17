using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ADO.NET_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectToStepDB"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UsersID = '56'", connection);

            //    DataTable users = new DataTable("Users");
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    adapter.Fill(users);

            //    foreach(DataRow row in users.Rows)
            //    {
            //        foreach(DataColumn column in users.Columns)
            //        {
            //            Console.WriteLine("{0} : {1} ", column.ColumnName, row[column]);
            //        }
            //    }
            //}

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    DataSet dataSet = new DataSet();
            //    string cmd = "SELECT * FROM Users WHERE UsersID = '134'";
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
            //    adapter.MissingMappingAction = MissingMappingAction.Passthrough;
            //    DataTableMapping userMapping = adapter.TableMappings.Add("Table", "Users");

            //    var userColumnMapping = new DataColumnMapping[]
            //    {
            //        new DataColumnMapping("UsersID", "Id"),
            //        new DataColumnMapping("name", "Name"),
            //        new DataColumnMapping("surname", "Surname"),
            //        new DataColumnMapping("phone", "Tel. number"),
            //        new DataColumnMapping("email", "User email"),
            //        new DataColumnMapping("age", "Age")
            //    };
            //    userMapping.ColumnMappings.AddRange(userColumnMapping);

            //    adapter.Fill(dataSet);

            //    foreach(DataRow row in dataSet.Tables[0].Rows)
            //    {
            //        foreach(DataColumn column in dataSet.Tables[0].Columns)
            //        {
            //            Console.WriteLine("{0} : {1} ", column.ColumnName, row[column]);
            //        }
            //    }
            //}

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    DataSet dataSet = new DataSet();

            //    string cmd = "SELECT * FROM Users WHERE UsersID = '155'; SELECT * FROM counties WHERE Country = 'Spain'";

            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
            //    adapter.Fill(dataSet);

            //    Console.WriteLine($"Tables count = {dataSet.Tables.Count}");
            //    Console.WriteLine($"Tables name: {dataSet.Tables[0].TableName}");
            //    Console.WriteLine($"Tables name: {dataSet.Tables[1].TableName}");

            //    foreach (DataRow row in dataSet.Tables[0].Rows)
            //    {
            //        foreach (DataColumn column in dataSet.Tables[0].Columns)
            //        {
            //            Console.WriteLine("{0} : {1} ", column.ColumnName, row[column]);
            //        }
            //    }

            //    Console.WriteLine("++++++++++++++++++++++++++++++++++++++");

            //    foreach (DataRow row in dataSet.Tables[1].Rows)
            //    {
            //        foreach (DataColumn column in dataSet.Tables[1].Columns)
            //        {
            //            Console.WriteLine("{0} : {1} ", column.ColumnName, row[column]);
            //        }
            //        Console.WriteLine("========================>>>");
            //    }

            //}

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllUsers", connection) { CommandType = System.Data.CommandType.StoredProcedure  };

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine("{0} : {1}", reader.GetName(i), reader[i]);
                    }
                    Console.WriteLine("===============================");
                }

                reader.Close();
            }
                
        }
    }
}
