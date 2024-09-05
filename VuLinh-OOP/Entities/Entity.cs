using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuLinh_OOP.Entities
{
    public /*abstract */class Entity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Entity(int id , string name)
        {
            Id = id;
            Name = name;
        }
    }
}
