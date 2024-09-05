using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.Demo;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.DAO
{
    public class Database
    {
        const string nameProduct = "product";
        const string nameCategory = "category";
        const string nameAccessory = "accessory";
        public List<Product> products = new List<Product>();
        public List<Accessotion> accessotions = new List<Accessotion>();
        public List<Category> categories = new List<Category>();

        Dictionary<string, List<Entity>> table = new Dictionary<string, List<Entity>>()
        {
            {nameProduct, new List<Entity>()},
            {nameCategory, new List<Entity>()},
            {nameAccessory, new List<Entity>()},
        };

        public Database()
        {

        }
        public void InsertTable(string name, Entity row)
        {
            table[name].Add(row);
        }
        public List<Entity> SelectTable(string name)
        {
            List<Entity> list = table[name];
            Console.WriteLine($"ID:{list.Count}  Name:{name}  CateID:{list.Count}");
            return list;
        }
        public void UpdateTable(string name, Entity row)
        {
            List <Entity> list = table[name];
            for (int i = 0; i < list.Count; i++)
            {
                if (row.Id == list[i].Id)
                {
                    table[name][i] = row;
                }
                Console.WriteLine($"ID:{list[i].Id}  Name:{list[i].Name}  CateID:{list[i].Id}");
            }

        }
        public void DeleteTable(string name, Entity row)
        {
            List<Entity> list = table[name];
            for (int i = 0; i < list.Count; i++)
            {
                if (row.Id == list[i].Id)
                {
                    table[name].Remove(list[i]);
                    Console.WriteLine($"Remove: Id:{row.Id}  Name:{row.Name}  CateID:{row.Id}");
                }
                Console.WriteLine($"ID:{list[i].Id}  Name:{list[i].Name}  CateID:{list[i].Id}");
            }
        }
        public void TruncateTable(string name)
        {
            List<Entity> list = table[name];
            for (int i = list.Count - 1; i >= 0; i--)
            {
                list.Remove(list[i]);
                Console.WriteLine($"ID:{i} Name:{name} CateID:{i}");
                if(i <= 0)
                {
                    Console.WriteLine("Removed All");
                }
            }
        }
        public void UpdateTableByID(int id, Entity row)
        {

        }
    }
}
