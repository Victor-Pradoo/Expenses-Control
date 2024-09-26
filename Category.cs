using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses_Control
{
    public class Category
    {
        private int Id { get; set; }
        private string Name { get; set; }

        public Category(int Id, string Name) 
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
