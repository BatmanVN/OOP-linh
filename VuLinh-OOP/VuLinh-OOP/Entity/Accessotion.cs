using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuLinh_OOP.DAO;

namespace VuLinh_OOP.Entity
{

    public class Accessotion
    {
        public int id;
        public string name;
        public int cateID;
        
        public Accessotion() { }
        public void createProductTest()
        {
            Accessotion accessory = new Accessotion();
            Console.Write("Nhap ID: ");
            accessory.id = int.Parse(Console.ReadLine());
            Console.Write("Nhap Name: ");
            accessory.name = Console.ReadLine();
            Console.Write("Nhap CategoryID: ");
            accessory.cateID = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Database database = new Database();
                database.InsertTable(name, accessory);
                accessory.id = i;
                //accessory.name = $"accessory{i}";
                accessory.cateID = i;
                printProduct(accessory.id, accessory.name, accessory.cateID);
            }
        }
        public void printProduct(int id, string name, int cateID)
        {
            Console.WriteLine($"ID: {id} \t Name: {name} \t CateID: {cateID}");
        }
    }
}
