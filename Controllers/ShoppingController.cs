using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsHomeBudget.Models;

namespace StudentsHomeBudget.Controllers
{
    public class ShoppingController : Controller
    {
        //
        // GET: /Shopping/
        private ShoppingListRepository _shoppingRepository = new ShoppingListRepository(); 
        public ActionResult Index()
        {
            return View(_shoppingRepository.GetAll().ToList());
        }

    }
}
