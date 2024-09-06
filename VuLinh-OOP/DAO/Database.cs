using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using VuLinh_OOP.Demo;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.DAO
{
    public class Database : Singleton<Database>
    {
        public Dictionary<string, List<Entity>> table = new Dictionary<string, List<Entity>>()
        {
            {NameProduct.nameProduct, new List<Entity>()},
            {NameProduct.nameAccessory, new List<Entity>()},
            {NameProduct.nameCategory, new List<Entity>()},
        };
        /// <summary>
        /// Create Method InsertTable to add new Obj to list<> with keyName in Ditonary
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        public void InsertTable(string name, Entity row)
        {
            table[name].Add(row);
        }
        /// <summary>
        /// Create Method SelectTable to Display all Object of list<> conrresponding with keyName in Dictionary
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Entity> SelectTable(string name)
        {
            List<Entity> list = table[name];
            //list.ForEach(s => Console.WriteLine($"Show: Id:{s.Id}  Name:{s.Name}  CateID:{s.Id}"));
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
                //Console.WriteLine($"ID:{list[i].Id}  Name:{list[i].Name}  CateID:{list[i].Id}");
            }
        }
        /// <summary>
        /// Create Mehod UpdateTable to add new object to list<>, find id and change new row
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="row"></param>
        public void UpdateTableByID(int id, string name, Entity row)
        {
            //string name = row.Name;
            List<Entity> list = table[name];
            if (table.ContainsKey(name))
            {
                list.RemoveAt(id);
                list.Insert(id, row);
                table[name][id] = row;
                //list.ForEach(s => Console.WriteLine($"ID:{s.Id}  Name:{s.Name}  CateID:{s.Id}"));
            }
        }
        /// <summary>
        /// Create Method DeleteTable to delete obj with keyName,id you input
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        public void DeleteTable(string name, Entity row)
        {
            List<Entity> list = table[name];
            if (table.ContainsKey(name))
            {
                list.FindAll(s => s.Id == row.Id);
                list.RemoveAt(row.Id);
                //Console.WriteLine($"Remove: Id:{row.Id}  Name:{row.Name}  CateID:{row.Id}");
                //list.ForEach(s => Console.WriteLine($"Id:{s.Id}  Name:{s.Name}  CateID:{s.Id}"));
            }
        }
        /// <summary>
        /// Create Mehtod TruncateTable to delete all list<> correponding with keyName had been input
        /// </summary>
        /// <param name="name"></param>
        public void TruncateTable(string name)
        {
            List<Entity> list = table[name];
            var count = list.Count(x => x.Equals(name));
            if (table.ContainsKey(name))
            {
                list.RemoveAll(s => s.Equals(name));
                if (count <= 0)
                {
                    return;
                }
            }
        }
        public void FindByID(string name, Entity row)
        {
            List<Entity> list = table[name];
            if (table.ContainsKey(name))
            {
                list.Where(s => s.Id == row.Id);
                //Console.WriteLine($"Finded :ID: {row.Id}  Name: {row.Name}  Category:{row.Id}");
            }
        }
    }
}
