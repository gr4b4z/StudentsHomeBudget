using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using StudentsHomeBudget.Models;

namespace StudentsHomeBudget.Controllers
{
    public class UserApiController : ApiController
    {
        //
        // GET: /User/
        private UsersRepository _usersRepository = new UsersRepository();

        public IEnumerable<User> GetAll()
        {
            return _usersRepository.GetAll();
        }
        public User GetById(int id)
        {
            return _usersRepository.GetAll().FirstOrDefault(z=>z.Id == id);
        }

    }
}
