using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using StudentsHomeBudget.Models;

namespace StudentsHomeBudget.Controllers
{
    public class ShoppingApiController : ApiController
    {
        private ShoppingListRepository _shoppingRepository = new ShoppingListRepository();
        public IEnumerable<ShoppingList> GetAll()
        {
            return (_shoppingRepository.GetAll().ToList());
        }
        public ShoppingList GetById(int id)
        {
            return (_shoppingRepository.GetAll().FirstOrDefault(z=>z.Id == id));
        }
    }
}
