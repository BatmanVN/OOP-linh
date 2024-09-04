using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.Demo;
using VuLinh_OOP.Entity;

namespace VuLinh_OOP.DAO
{
    public class Database
    {
        public List<ProductDemo> products = new List<ProductDemo>();
        public List<Accessotion> accessotions = new List<Accessotion>();
        public List<Category> categories = new List<Category>();

        public Dictionary<string, List<object>> table = new Dictionary<string, List<object>>();
        
       public void InsertTable(string name, object row)
        {
            switch (name)
            {
                case "product":
                    products.Add(row as ProductDemo);
                    table.Add("product",products.Cast<object>().ToList());
                    break;
                case "category":
                    categories.Add((Category)row);
                    break;
                case "accessory":
                    accessotions.Add((Accessotion)row);
                    break;
            }
        }
        public void SelectTable(string name)
        {
            switch (name)
            {
                case "product":
                    foreach (ProductDemo product in products)
                    {
                        product.printProduct(product.id, product.name, product.cateID);
                    }
                    break;
                case "accessory":
                    foreach (Accessotion accessory in accessotions)
                    {
                        accessory.printProduct(accessory.id, accessory.name, accessory.cateID);
                    }
                    break;
                case "category":                    
                    foreach (Category category in categories)
                    {
                        category.printProduct(category.id, category.name, category.cateID);
                    }
                    break;
            }
        }
        public void UpdateTable(string name,object row)
        {
            
        }
        public void DeleteTable(string name, object row)
        {

        }
        public void TruncateTable(string name)
        {

        }
    }
}
