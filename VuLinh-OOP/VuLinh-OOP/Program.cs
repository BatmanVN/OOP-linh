using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.Demo;

namespace VuLinh_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDemo productDemo = new ProductDemo();
            productDemo.createProductTest();
            Console.ReadKey();
        }
    }
}
