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
            Console.WriteLine($"ID:{row.Id}  Name:{row.Name}  CateID:{row.Id}");
        }
        public List<Entity> SelectTable(string name)
        {
            List<Entity> list = table[name];
            list.ForEach(s => Console.WriteLine($"Id:{s.Id}  Name:{s.Name}  CateID:{s.Id}"));
            return list;
        }
        public void UpdateTable(string name, Entity row)
        {
            List<Entity> list = table[name];
            for (int i = 0; i < list.Count; i++)
            {
                if (row.Id == list[i].Id)
                {
                    table[name][i] = row;
                }
                Console.WriteLine($"ID:{list[i].Id}  Name:{list[i].Name}  CateID:{list[i].Id}");
            }
        }
        public void UpdateTableByID(int id, string name, Entity row)
        {
            //string name = row.Name;
            List<Entity> list = table[name];
            if (table.ContainsKey(name))
            {
                list.RemoveAt(id);
                list.Insert(id, row);
                table[name][id] = row;
                list.ForEach(s => Console.WriteLine($"ID:{s.Id}  Name:{s.Name}  CateID:{s.Id}"));
            }
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (id == list[i].Id)
            //    {
            //        table[name][i] = row;
            //        Console.WriteLine($"ID:{list[id].Id}  Name: NewByID{list[id].Name}  CateID:{list[id].Id}");
            //    }
            //    Console.WriteLine($"ID:{list[i].Id}  Name:{list[i].Name}  CateID:{list[i].Id}");
            //}
        }
        public void DeleteTable(string name, Entity row)
        {
            List<Entity> list = table[name];
            if (table.ContainsKey(name))
            {
                list.FindAll(s => s.Id.Equals(row.Id));
                list.RemoveAt(row.Id);
                Console.WriteLine($"Remove: Id:{row.Id}  Name:{row.Name}  CateID:{row.Id}");
                list.ForEach(s => Console.WriteLine($"Id:{s.Id}  Name:{s.Name}  CateID:{s.Id}"));

            }
        }
        public void TruncateTable(string name)
        {
            List<Entity> list = table[name];
            var count = list.Count(x => x.Equals(name));
            if (table.ContainsKey(name))
            {
                list.RemoveAll(s => s.Equals(name));
                if (count <= 0)
                {
                    Console.WriteLine("Removed ALL");
                }
            }
            //for (int i = list.Count - 1; i >= 0; i--)
            //{
            //    list.Remove(list[i]);
            //    Console.WriteLine($"ID:{i} Name:{name} CateID:{i}");
            //    if(i <= 0)
            //    {
            //        Console.WriteLine("Removed All");
            //    }
            //}
        }
    }
}
