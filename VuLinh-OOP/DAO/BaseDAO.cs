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
        /// <summary>
        /// Add new obj to list
        /// </summary>
        /// <param name="name">To access list<></param>
        /// <param name="row"> a Obj</param>
        public void InsertTable(string name, Entity row) 
        {
            Database.Instance.InsertTable(name, row);
        }
        /// <summary>
        /// Change one Element in List by new obj
        /// </summary>
        /// <param name="name">To access list</param>
        /// <param name="row">a Object</param>
        public void UpdateTable(string name, Entity row) 
        {
            Database.Instance.UpdateTable(name, row);
        }
        /// <summary>
        /// Delete a element in list
        /// </summary>
        /// <param name="name">To access list</param>
        /// <param name="row">a Object</param>
        public void DeleteTable(string name, Entity row) 
        {
            Database.Instance.DeleteTable(name, row);
        }
        /// <summary>
        /// Display all Element in list
        /// </summary>
        /// <param name="name">To access list</param>
        /// <returns></returns>
        public List<Entity> SelectTable(string name)
        {
            List<Entity> list = Database.Instance.SelectTable(name);
            return list;
        }
        /// <summary>
        /// Find Element with ID in List
        /// </summary>
        /// <param name="name">To access list</param>
        /// <param name="row">a Object</param>
        public void FindByID(string name, Entity row) 
        {
            Database.Instance.FindByID(name, row);
        }
        /// <summary>
        /// Print Elements in List
        /// </summary>
        /// <param name="entity"></param>
        public void PrintTable(List<Entity> entity)
        {
            for (int i = 0; i < entity.Count; i++)
            {
                Console.WriteLine($"ID: {entity[i].Id} Name: {entity[i].Name}  CategoryID: {entity[i].Id}");
            }
        }
        /// <summary>
        /// Input string with mess
        /// </summary>
        /// <param name="mess">Input mess</param>
        /// <returns></returns>
        public string InpuntStr(string mess)
        {
            Console.Write(mess);
            string inPut = Console.ReadLine();
            return inPut;
        }
        /// <summary>
        /// Input int with mess
        /// </summary>
        /// <param name="mess">Input mess</param>
        /// <returns></returns>
        public int InputInt(string mess)
        {
            Console.Write(mess);
            int inPut = int.Parse(Console.ReadLine());
            return inPut;
        }
    }
}
