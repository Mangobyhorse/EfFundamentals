using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstApp.Entities;

namespace CodeFirstApp
{
    class MovieContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public MovieContext():base("MovieContext")
        {
            
        }
    }
}
