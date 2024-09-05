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
//    public class AccessiotionDemo
//    {
//        private int id;
//        private string name;
//        private int cateID;
//        public Accessotion accessotion = new Accessotion();
//        public AccessiotionDemo() 
//        {
//            id = accessotion.Id;
//            name = accessotion.Name;
//            cateID = accessotion.CateID;
//        }
//        public void createProductTest()
//        {
//            AccessiotionDemo accessory = new AccessiotionDemo();
//            Console.Write("Nhap ID: ");
//            accessory.id = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Name: ");
//            accessory.name = Console.ReadLine();
//            Console.Write("Nhap CategoryID: ");
//            accessory.cateID = int.Parse(Console.ReadLine());
//        }
//        public void printProduct()
//        {
//            Console.WriteLine($"ID: {id} \t Name: {name} \t CateID: {cateID}");
//        }
//    }
//}
