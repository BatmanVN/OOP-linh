using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.DAO;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.Demo
{
    public class ProductDaoDemo
    {
        private static ProductDAO productDao = new ProductDAO();
        private static int quantity = categoryDAO.InputInt("Input Quantity Product: ");
        private static string nameP;

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
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Insert Table: {name} ");
            for (int i = 0; i < 10; i++)
            {
                nameP = name + i;
                productDao.InsertTable(name,new Product(i, nameP));
            }
        }
        /// <summary>
        /// Create i element and add to list<> correpond with keyName, then print this lis<>
        /// </summary>
        public static void InitTableTest()
        {
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Insert Table: {name} ");
            for (int i = 0; i < quantity; i++)
            {
                nameP = name + i;
                productDao.InsertTable(name, new Product(i, nameP));
            }
            productDao.PrintTable(Database.Instance.table[name]);
        }
        /// <summary>
        /// Input name then display all elements of List<> correpond with keyName
        /// </summary>
        public static void SelecteTable()
        {
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Select Table: {name}");
            productDao.SelectTable(name);
            productDao.PrintTable(Database.Instance.table[name]);

        }

        /// <summary>
        /// Input keyName,ID then compare with element in list<>, delete it
        /// </summary>
        public static void DeleteTable()
        {
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Delete Table: {name}");
            int id = productDao.InputInt("Input ID Delete: ");
            productDao.DeleteTable(name, new Product(id, name));
            productDao.PrintTable(Database.Instance.table[name]);
        }
        /// <summary>
        /// Input new obj then change with 1 element in list<>
        /// </summary>
        public static void UpdateTable()
        {
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Update Table: {name}");
            int id = productDao.InputInt("Input ID Update: ");
            nameP = "New " + name;
            accessoryDAO.UpdateTable(name, new Accessotion(id, $"New {nameP}"));
            productDao.PrintTable(Database.Instance.table[name]);
        }
        /// <summary>
        /// Input int ID then compare with all Element in List<> then show it 
        /// </summary>
        public static void FindTableByID()
        {
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Find Table ID: {name}");
            int id = productDao.InputInt("Input ID Find: ");
            Console.WriteLine($"-ID: {id} Name: {nameP}  CategoryID: {id}");
            productDao.FindByID(name, new Product (id, name));
        }


        public static void FindByName()
        {
            string name = NameProduct.nameProduct;
            List<Entity> list = Database.Instance.Table[name];
            Console.WriteLine($"-Find Name: ");
            string findName = productDao.InpuntStr("Input Name Find:");
            productDao.FindByName(findName);
            var row = list.Find(x => x.Name.Equals(findName));
            Console.WriteLine($"Name Find: {findName}   ID: {row.Id}  Category:{row.Id}");
        }
        public static void SearchTable()
        {
            string name = NameProduct.nameProduct;
            List<Entity> list = Database.Instance.Table[name];
            string findName = categoryDAO.InpuntStr("Input Word Find:");
            productDao.Search(findName);
            productDao.PrintTable(Database.Instance.Table[name]);
        }
    }
}
