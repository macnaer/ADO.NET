using Dapper.Data.Data.Interfaces;
using Dapper.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Data.Data.Classes
{
    public class UserRepository : IUserRepository
    {
        private string  connectionString = @"Server=194.44.93.225;Database=EFDapper;User Id = test; Password=Qwerty-1;MultipleActiveResultSets=True;";
        public void Create(User user)
        {
            using (IDbConnection context = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO Users (Name, Age) VALUES(@Name, @Age)";
                context.Execute(sqlQuery, user);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection context = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM Users WHERE Id = @id";
                context.Execute(sqlQuery, new { id });
            }
        }

        public User Get(int id)
        {
            using (IDbConnection context = new SqlConnection(connectionString))
            {
                return context.Query<User>("SELECT * FROM Users WHERE Id = @id", new { id }).FirstOrDefault();
            }
              
        }

        public List<User> GetAll()
        {
            using (IDbConnection context = new SqlConnection(connectionString))
            {
                return context.Query<User>("SELECT * FROM Users").ToList();
                
            }
        }

        public void Update(User user)
        {
            using (IDbConnection context = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE Users SET Name = @Name, Age = @Age WHERE Id = @Id";
                context.Execute(sqlQuery, user);
            }
        }
    }
}
