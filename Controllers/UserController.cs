using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsHomeBudget.Models;

namespace StudentsHomeBudget.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        private UsersRepository _usersRepository = new UsersRepository();

        public ActionResult Index()
        {
            
            return View(_usersRepository.GetAll().ToList());
        }

    }
}
