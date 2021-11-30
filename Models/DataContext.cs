using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WAD_BTNHOM.Models
{
    
    public class DataContext :DbContext
    {
        public DataContext() : base("WAD_BTNHOM") { }
        public DbSet<Category> Categories { get; set;}

        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands{ get; set; }

     

    }
}