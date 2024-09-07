using System;
using System.Collections.Generic;
using VuLinh_OOP.DAO;
using VuLinh_OOP.Entities;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using VuLinh_OOP.DAO;
//using VuLinh_OOP.Entities;

namespace VuLinh_OOP.Demo
{
    public class CategoryDaoDemo
    {
        private static CategoryDAO categoryDAO = new CategoryDAO();
        private static int quantity = categoryDAO.InputInt("Input Quantity Product: ");
        private static string nameC;

        static void Main(string[] args)
        {
            //InsertRow();
            InitTableTest();
            SelecteTable();
            DeleteTable();
            UpdateTable();
            FindTableByID();
            Console.ReadKey();
        }

        public static void InsertRow()
        {
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Insert Table: {name} ");
            categoryDAO.InsertTable(name,new Category(1, name));
        }
        public static void InitTableTest()
        {
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-InsertTable: {name} ");
            for(int i = 0; i < quantity; i++)
            {
                nameC = name + i;
                categoryDAO.InsertTable(name, new Accessotion(i, nameC));
            }
            categoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void SelecteTable()
        {
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Select Table: {name}");
            categoryDAO.SelectTable(name);
            categoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void DeleteTable()
        {
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Delete Table: {name}");
            int id = categoryDAO.InputInt("Input ID Delete: ");
            categoryDAO.DeleteTable(name, new Category(id,name));
            categoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void UpdateTable()
        {

            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Update Table: {name}");
            int id = categoryDAO.InputInt("Input ID Update: ");
            nameC = "New " + name;
            accessoryDAO.UpdateTable(name, new Accessotion(id, $"New {nameC}"));
            categoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void FindTableByID()
        {
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Find Table ID: {name}");
            int id = categoryDAO.InputInt("Input ID Find: ");
            Console.WriteLine($"-ID: {id} Name: {name}  CategoryID: {id}");
            categoryDAO.FindByID(name, new Category(id, name));
        }

    }
}
