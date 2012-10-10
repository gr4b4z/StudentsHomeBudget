using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsHomeBudget.Models
{
    public class SettelmentRepository
    {
        private List<Settelment> _settelments = new List<Settelment>();

        public SettelmentRepository()
        {
            
        }
        public Settelment Add(Settelment item)
        {
            item.Id = _settelments.Count;
            _settelments.Add(item);
            return item;
        }
    }
}