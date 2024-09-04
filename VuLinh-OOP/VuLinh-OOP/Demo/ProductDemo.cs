using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.DAO;
using VuLinh_OOP.Entity;

namespace VuLinh_OOP.Demo
{
    public class ProductDemo
    {
        public int id;
        public string name;
        public int cateID;

        public ProductDemo()
        {

        }
        public void createProductTest()
        {
            ProductDemo product = new ProductDemo();
            Console.Write("Nhap ID: ");
            product.id = int.Parse(Console.ReadLine());
            Console.Write("Nhap Name: ");
            product.name = Console.ReadLine();
            Console.Write("Nhap CategoryID: ");
            product.cateID = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Database database = new Database();
                database.InsertTable(name, product);
                product.id = i;
                //product.name = $"product{i}";
                product.cateID = i;
                printProduct(product.id, product.name, product.cateID);
            }
        }

        public void printProduct(int id, string name, int cateID)
        {
            Console.WriteLine($"ID: {id} \t Name: {name} \t CateID: {cateID}");
        }
    }
}
