using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class ExpenseItem
    {
        public ExpenseItem() { }

        public int Id { get; set; }
        
        public int ExpenseItemID { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
