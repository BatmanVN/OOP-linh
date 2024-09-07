using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.DAO;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.Demo
{
    public class AccessotionDaoDemo
    {
        private static AccessotionDAO accessoryDAO = new AccessotionDAO();
        private static int quantity = accessoryDAO.InputInt("Input Quantity Product: ");
        private static string nameA;
        static void Main(string[] args)
        {
            //InsertRow();
            InitTableTest();
            SelecteTable();
            DeleteTable();
            UpdateTable();
            FindTableByID();
            FindByName();
            SearchTable();
            Console.ReadKey();
        }

        public static void InsertRow()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-InsertTable: {name} ");
            accessoryDAO.InsertTable(name, new Accessotion(1, name));
            //accessoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void InitTableTest()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-InsertTable: {name} ");
            for (int i = 0; i < quantity; i++)
            {
                nameA = name + i;
                accessoryDAO.InsertTable(name, new Accessotion(i, nameA));
            }
            accessoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void SelecteTable()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Select Table: {name}");
            accessoryDAO.SelectTable(name);
            accessoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void DeleteTable()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Delete Table: {name}");
            int id = accessoryDAO.InputInt("Input ID Delete: ");
            accessoryDAO.DeleteTable(name, new Accessotion(id, name));
            accessoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void UpdateTable()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Update Table: {name}");
            int id = accessoryDAO.InputInt("Input ID Update: ");
            nameA = "New " + name; 
            accessoryDAO.UpdateTable(name, new Accessotion(id, $"New {nameA}"));
            accessoryDAO.PrintTable(Database.Instance.Table[name]);
        }
        public static void FindTableByID()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Find Table ID: {name}");
            int id = accessoryDAO.InputInt("Input ID Find: ");
            Console.WriteLine($"-ID: {id} Name: {nameA}  CategoryID: {id}");
            accessoryDAO.FindByID(name, new Accessotion(id, nameA));
        }

        public static void FindByName()
        {
            string name = NameProduct.nameAccessory;
            List<Entity> list = Database.Instance.Table[name];
            Console.WriteLine($"-Find Name: ");
            string findName = accessoryDAO.InpuntStr("Input Name Find:");
            accessoryDAO.FindByName(findName);
            var row = list.Find(x => x.Name.Equals(findName));
            Console.WriteLine($"Name Find: {findName}   ID: {row.Id}  Category:{row.Id}");
        }

        public static void SearchTable()
        {
            string name = NameProduct.nameAccessory;
            List<Entity> list = Database.Instance.Table[name];
            string findName = accessoryDAO.InpuntStr("Input Word Find:");
            accessoryDAO.Search(findName);
            accessoryDAO.PrintTable(Database.Instance.Table[name]);
        }
    }
}
