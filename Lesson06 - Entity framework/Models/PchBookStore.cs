using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson06___Entity_framework.Models
{
    public class PchBookStore:DbContext
    {
        public PchBookStore():base() { }

        public DbSet<PchCategory> PchCategories { get; set; }  
        public DbSet<PchBook> PchBooks { get; set; }
    }
}