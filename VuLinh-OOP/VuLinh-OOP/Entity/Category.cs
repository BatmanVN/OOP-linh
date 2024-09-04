using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.DAO;

namespace VuLinh_OOP.Entity
{
    public class Category
    {
        public int id;
        public string name;
        public int cateID;

        public Category() 
        {

        }
        public void createProductTest()
        {
            Category category = new Category();
            Console.Write("Nhap ID: ");
            category.id = int.Parse(Console.ReadLine());
            Console.Write("Nhap Name: ");
            category.name = Console.ReadLine();
            Console.Write("Nhap CategoryID: ");
            category.cateID = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Database database = new Database();
                database.InsertTable(name, category);
                category.cateID = i;
                //category.name = $"category{i}";
                category.cateID = i;
                printProduct(category.id, category.name,category.cateID);
            }
        }
        public void printProduct(int id, string name, int cateID)
        {
            Console.WriteLine($"ID: {id} \t Name: {name} \t CateID: {cateID}");
        }
    }
}
