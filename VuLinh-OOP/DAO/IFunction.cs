using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.Entities;

namespace VuLinh_OOP.DAO
{
    public interface IFunction
    {
        void FindByName(Entity row);
        void Search();
    }
}
