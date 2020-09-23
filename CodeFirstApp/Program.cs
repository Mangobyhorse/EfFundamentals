using CodeFirstApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieContext db = new MovieContext();
            var category = new Category()
            {
                CategoryName = "Adventure",
                Description = "adventure.desc"
            };
            db.Categories.Add(category);
            db.SaveChanges();
        }
    }
}
