﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.DAO
{
    public class ProductDAO
    {
        Database database = new Database();
        public void Insert(Entity row)
        {

        }
        public void Update(Entity row)
        {

        }
        public void Delete(Entity row)
        {

        }
        public void FindAll()
        {

        }
        public void FindById(string name)
        {

        }
        public void FindByName(string name)
        {

        }
        public List<Product> Search()
        {
            List<Product> list = database.products;
            return list;
        }
    }
}
