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
        const string nameProduct = "product";
        static ProductDAO productDao = new ProductDAO();

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
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Insert Table: {name} ");
            for (int i = 0; i < 10; i++)
            {
                productDao.InsertTable(name,new Product(i, name));
            }
        }
        /// <summary>
        /// Create i element and add to list<> correpond with keyName, then print this lis<>
        /// </summary>
        public static void InitTableTest()
        {
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Insert Table: {name} ");
            for (int i = 0; i < 10; i++)
            {
                productDao.InsertTable(name, new Product(i, name));
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
            Random rand = new Random();
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Delete Table: {name}");
            int id = rand.Next(0, 9);
            Console.WriteLine($"-ID: {id}");
            productDao.DeleteTable(name, new Product(id, name));
            productDao.PrintTable(Database.Instance.table[name]);
        }
        /// <summary>
        /// Input new obj then change with 1 element in list<>
        /// </summary>
        public static void UpdateTable()
        {
            Random rand = new Random();
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Update Table: {name}");
            int id = rand.Next(0, 9);
            productDao.UpdateTable(name, new Product(id, $"New {name}"));
            productDao.PrintTable(Database.Instance.table[name]);
        }
        /// <summary>
        /// Input int ID then compare with all Element in List<> then show it 
        /// </summary>
        public static void FindTableByID()
        {
            Random random = new Random();
            string name = NameProduct.nameProduct;
            Console.WriteLine($"-Find Table ID: {name}");
            int id = random.Next(0, 9);
            Console.WriteLine($"-ID: {id} Name: {name}  CategoryID: {id}");
            productDao.FindByID(name, new Product (id, name));
            productDao.PrintTable(Database.Instance.table[name]);
        }

    }
}
