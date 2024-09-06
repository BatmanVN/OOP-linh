using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.DAO
{
    public abstract class BaseDAO
    {
        
        public void InsertTable(string name, Entity row) 
        {
            Database.Instance.InsertTable(name, row);
        }
        public void UpdateTable(string name, Entity row) 
        {
            Database.Instance.UpdateTable(name, row);
        }
        public void DeleteTable(string name, Entity row) 
        {
            Database.Instance.DeleteTable(name, row);
        }
        public List<Entity> SelectTable(string name)
        {
            List<Entity> list = Database.Instance.SelectTable(name);
            return list;
        }
        public void FindByID(string name, Entity row) 
        {
            Database.Instance.FindByID(name, row);
        }
        public void PrintTable(List<Entity> entity)
        {
            for (int i = 0; i < entity.Count; i++)
            {
                Console.WriteLine($"ID: {entity[i].Id} Name: {entity[i].Name}  CategoryID: {entity[i].Id}");
            }
        }
    }
}
