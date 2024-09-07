using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.DAO
{
    public class ProductDAO : BaseDAO, IFunction
    {
        /// <summary>
        /// Create Method FindbyName, Type Object,  input Name then find it in List<> correpond with keyName
        /// </summary>
        /// <param name="name">find Name = elementName, will display this element if have</param>
        /// <returns></returns>
        public Entity FindByName(string name)
        {
            List<Entity> list = Database.Instance.Table[NameProduct.nameCategory];
            var row = list.Find(x => x.Name == name);
            return row;
        }
        /// <summary>
        /// Create Method Search, Type List, input a string then find it in List<> correpond with keyName
        /// </summary>
        /// <param name="name">search in list, display all element have it in list </param>
        /// <returns></returns>
        public List<Entity> Search(string name)
        {
            List<Entity> list = Database.Instance.Table[NameProduct.nameCategory];
            list.Where(x => x.Name == name);
            return list;
        }
    }
}
