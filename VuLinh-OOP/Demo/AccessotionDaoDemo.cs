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
        static AccessotionDAO accessoryDAO = new AccessotionDAO();
        

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
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-InsertTable: {name} ");
            for (int i = 0; i < 10; i++)
            {
                accessoryDAO.InsertTable(name, new Accessotion(i, name));
            }
            var ls = accessoryDAO.SelectTable(name);
            accessoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void InitTableTest()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-InsertTable: {name} ");
            for (int i = 0; i < 10; i++)
            {
                accessoryDAO.InsertTable(name, new Accessotion(i, name));
            }
            accessoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void SelecteTable()
        {
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Select Table: {name}");
            accessoryDAO.SelectTable(name);
            accessoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void DeleteTable()
        {
            Random rand = new Random();
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Delete Table: {name}");
            int id = rand.Next(0, 9);
            Console.WriteLine($"-ID: {id}");
            accessoryDAO.DeleteTable(name, new Accessotion(id, name));
            accessoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void UpdateTable()
        {
            Random rand = new Random();
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Update Table: {name}");
            int id = rand.Next(0, 9);
            accessoryDAO.UpdateTable(name, new Accessotion(id, $"New {name}"));
            accessoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void FindTableByID()
        {
            Random random = new Random();
            string name = NameProduct.nameAccessory;
            Console.WriteLine($"-Find Table ID: {name}");
            int id = random.Next(0, 9);
            Console.WriteLine($"-ID: {id} Name: {name}  CategoryID: {id}");
            accessoryDAO.FindByID(name, new Accessotion(id, name));
            accessoryDAO.PrintTable(Database.Instance.table[name]);
        }
    }
}
