﻿using System;
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
        static CategoryDAO categoryDAO = new CategoryDAO();

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
            for (int i = 0; i < 10; i++)
            {
                categoryDAO.InsertTable(name,new Category(i, name));
            }
        }
        public static void InitTableTest()
        {
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-InsertTable: {name} ");
            for (int i = 0; i < 10; i++)
            {
                categoryDAO.InsertTable(name, new Accessotion(i, name));
            }
            categoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void SelecteTable()
        {
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Select Table: {name}");
            categoryDAO.SelectTable(name);
            categoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void DeleteTable()
        {
            Random rand = new Random();
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Delete Table: {name}");
            int id = rand.Next(0, 9);
            Console.WriteLine($"-ID: {id}");
            categoryDAO.DeleteTable(name, new Category(id,name));
            categoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void UpdateTable()
        {
            Random rand = new Random();
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Update Table: {name}");
            int id = rand.Next(0, 9);
            categoryDAO.UpdateTable(name, new Category(id, $"New {name}"));
            categoryDAO.PrintTable(Database.Instance.table[name]);
        }
        public static void FindTableByID()
        {
            Random random = new Random();
            string name = NameProduct.nameCategory;
            Console.WriteLine($"-Find Table ID: {name}");
            int id = random.Next(0, 9);
            Console.WriteLine($"-ID: {id} Name: {name}  CategoryID: {id}");
            categoryDAO.FindByID(name, new Category(id, name));
            categoryDAO.PrintTable(Database.Instance.table[name]);
        }
    }
}
