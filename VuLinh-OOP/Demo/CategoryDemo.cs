//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using VuLinh_OOP.DAO;
//using VuLinh_OOP.Entity;

//namespace VuLinh_OOP.Demo
//{
//    public class CategoryDemo
//    {
//        private int id;
//        private string name;
//        private int cateID;
//        public Category category = new Category();
//        public CategoryDemo()
//        {
//            id = category.Id;
//            name = category.Name;
//            cateID = category.CateID;
//        }
//        public void createProductTest()
//        {
//            CategoryDemo categoryDemo = new CategoryDemo();
//            Console.Write("Nhap ID: ");
//            categoryDemo.id = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Name: ");
//            categoryDemo.name = Console.ReadLine();
//            Console.Write("Nhap CategoryID: ");
//            categoryDemo.cateID = int.Parse(Console.ReadLine());
//        }
//        public void printProduct()
//        {
//            Console.WriteLine($"ID: {id} \t Name: {name} \t CateID: {cateID}");
//        }
//    }
//}
