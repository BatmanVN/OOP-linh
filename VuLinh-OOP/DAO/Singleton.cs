using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuLinh_OOP.DAO
{
    public class Singleton<T> where T : class, new()
    {
        private static T _instance;

        protected Singleton() { }
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }
    }
}
