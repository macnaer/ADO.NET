using EF_Intro.Data;
using EF_Intro.Data.Models;
using System;
using System.Linq;

namespace EF_Intro
{
    class Program
    {
        static void Main(string[] args)
        {

            // add-migration init 
            // init це назва міграції (можна свою назву)
            // update-database

            //UsersRepository.Print();
            //UsersRepository.AddUser("Tiffany", "Sallivan", "tiff@email.com", 44);
            //UsersRepository.Print();
            //UsersRepository.UpdateUser(2, "tiffsallivan@gmail.com", 45);
            //UsersRepository.Print();
            UsersRepository.DeleteUser(1);
            UsersRepository.Print();
        }
    }
}
