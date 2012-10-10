using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsHomeBudget.Models
{
    public class CleaningRepository
    {
        private List<CleaningList> _list = new List<CleaningList>();

            public CleaningRepository()
        {
            //_list.Add(new CleaningList() {User = });
            //_list.Add(new CleaningList() { Id = 232, Items = new string[] { "Worki", "Kubeł", "Papier" } });
            //_list.Add(new CleaningList() { Id = 242, Items = new string[] { "Proszek", "papier", "Płyn" } });
        }
            public IQueryable<CleaningList> GetAll()
        {
            return _list.AsQueryable();
        } 
    }
}