//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using VuLinh_OOP.DAO;
//using VuLinh_OOP.Entities;

//namespace VuLinh_OOP.Demo
//{
//    public class ProductDemo
//    {
//        public int id;
//        public string name;
//        public int cateID;
//        public Product product = new Product();
//        public ProductDemo()
//        {
//            id = product.ID;
//            name = product.Name;
//            cateID = product.CategoryID;
//        }
//        public void CreateProductTest()
//        {
//            ProductDemo productDemo = new ProductDemo();
//            Console.Write("Nhap ID: ");
//            productDemo.id = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Name: ");
//            productDemo.name = Console.ReadLine();
//            Console.Write("Nhap CategoryID: ");
//            productDemo.cateID = int.Parse(Console.ReadLine());
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    //Database database = new Database();
//            //    //database.InsertTable(productDemo.name, productDemo);
//            //    //productDemo.id = i;
//            //    ////product.name = $"product{i}";
//            //    //productDemo.cateID = i;
//            //    //database.SelectTable(productDemo.name);
//            //}
//        }

//        public void PrintProduct()
//        {
//            Console.WriteLine($"ID: {id} \t Name: {name} \t CateID: {cateID}");
//        }
//    }
//}
