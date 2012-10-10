using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsHomeBudget.Models
{
    public class ShoppingList
    {
        public bool isDone { get; set; }
        public int Id { get; set; }
        public string[] Items { get; set; }
    }
}