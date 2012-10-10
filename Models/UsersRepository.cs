using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsHomeBudget.Models
{
    public class UsersRepository
    {
        List<User> users = new List<User>(); 
        public UsersRepository()
        {
            users.Add(new User() { Id = 0,Name = "Sylwester", SurName = "Grabowski", Email = "s@w.pl" });
            users.Add(new User() { Id = 1, Name = "Agata", SurName = "Szyńkarczuk", Email = "s@w.pl" });
            users.Add(new User() { Id = 2, Name = "Justyna", SurName = "Bobowiecz", Email = "s@w.pl" });
            users.Add(new User() { Id = 3, Name = "Kamila", SurName = "Rabkowska", Email = "s@w.pl" });
        }

        public IQueryable<User> GetAll()
        {
            return users.AsQueryable();
        } 
    }
}