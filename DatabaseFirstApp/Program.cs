using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities db =  new NorthwindEntities();
            var categories = db.Categories;
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName);
                

            }
            Console.Read();
        }
    }
}
