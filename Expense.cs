using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses_Control
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime date { get; set; }
        public Category Category { get; set; }

        public Expense(int Id, string Description, decimal Value, DateTime date, Category category) 
        {
            this.Id = Id;
            this.Description = Description;
            this.Value = Value;
            this.Category = category;
        }
    }
}
