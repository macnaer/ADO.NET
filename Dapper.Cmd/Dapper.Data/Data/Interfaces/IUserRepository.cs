using Dapper.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Data.Data.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        List<User> GetAll();
        User Get(int id);

        void Delete(int id);

        void Update(User user);


    }
}
