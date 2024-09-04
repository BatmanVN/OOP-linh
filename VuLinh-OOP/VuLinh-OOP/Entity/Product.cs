using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuLinh_OOP.Entity
{
    public class Product
    {
       
        private int iD;
        private string name;
        private int categoryID;


        public Product(int ID, string Name, int CategoryID)
        {
            this.iD = ID;
            this.name = Name;
            this.categoryID = CategoryID;
        }

        public int getId()
        {
            return iD;
        }
        public void setId(int ID)
        {
            this.iD = ID;
        }
    }
}
