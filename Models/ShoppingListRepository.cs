using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsHomeBudget.Models
{
    public class ShoppingListRepository
    {
        private List<ShoppingList> _list = new List<ShoppingList>();

        public ShoppingListRepository()
        {
           Add(new ShoppingList() {Id=22, Items = new string[]{ "Mleko", "Chleb", "Spożywka" } });
           Add(new ShoppingList() { Id = 232, Items = new string[]{ "Worki", "Kubeł", "Papier" } });
           Add(new ShoppingList() { Id = 242, Items = new string[]{ "Proszek", "papier", "Płyn" } });
        }
        public IQueryable<ShoppingList> GetAll()
        {
            return _list.AsQueryable();
        } 
        public ShoppingList Add(ShoppingList item)
        {
            item.Id = _list.Count;
            item.isDone = false;
            _list.Add(item);
            return item;
        }
    }
}