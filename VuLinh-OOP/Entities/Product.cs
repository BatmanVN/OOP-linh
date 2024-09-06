using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuLinh_OOP.Entities
{
    public class Product : Entity
    {
        public int categoryID;
        public Product(int id, string name) : base(id, name)
        {
            Random random = new Random();
            categoryID = random.Next(10, 20);
        }
    }
}
