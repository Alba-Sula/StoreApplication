using StoreApplication.Models.Store;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoreApplication.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base ("DefaultConnection")
        { }

        public DbSet<Product> Products { get; set; }
    }
}