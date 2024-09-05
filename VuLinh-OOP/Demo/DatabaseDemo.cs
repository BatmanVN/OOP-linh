using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VuLinh_OOP.DAO;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.Demo
{
    public class DatabaseDemo
    {
        const string nameProduct = "product";
        const string nameCategory = "category";
        const string nameAccessory = "accessory";
        static List<Product> products = new List<Product>();
        static List<Category> categories = new List<Category>();
        static List<Accessotion> accessions = new List<Accessotion>();
        public static Database database = new Database();

        static void Main(string[] args)
        {
            InitDataBase();
        }
        public static void InitDataBase()
        {
            InsertTableTest();
            UpdateTalbeTest();
            DeleteTableTest();
            TruncateTable();
            Console.ReadKey();
        }
        public static void InsertTableTest()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                database.InsertTable(name, new Entity(i, name));
                database.SelectTable(name);
            }
        }
        public static void SelectTableTest()
        {
            string name = Console.ReadLine();
            database.SelectTable(name);
        }
        public static void UpdateTalbeTest()
        {
            Console.Write("New Row: ");
            string name = Console.ReadLine();
            database.UpdateTable(name, new Entity(2, "Linh"));
        }
        public static void DeleteTableTest()
        {
            Console.Write("Row: ");
            string name = Console.ReadLine();
            database.DeleteTable(name, new Entity(2, name));
        }

        public static void TruncateTable()
        {
            Console.Write("Remove all List: ");
            string name = Console.ReadLine();
            database.TruncateTable(name);
        }
    }
}
