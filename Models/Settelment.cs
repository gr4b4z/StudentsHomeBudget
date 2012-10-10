using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsHomeBudget.Models
{
    public class Settelment : MasterItem
    {
        public List<SettelmentItem> Items { get; set; } 
    }
    public class SettelmentItem : MasterItem
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public User User { get; set; }
    }
}