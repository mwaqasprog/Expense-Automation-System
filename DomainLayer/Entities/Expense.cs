using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Expense
    {
        public int ExpenseID { get; set; }

        public string Title { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
