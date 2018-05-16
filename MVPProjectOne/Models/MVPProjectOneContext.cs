using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVPProjectOne.Models
{
    public class MVPProjectOneContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVPProjectOneContext() : base("name=MVPProjectOneContext")
        {
        }

        public System.Data.Entity.DbSet<MVPProjectOne.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<MVPProjectOne.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVPProjectOne.Models.ProductSold> ProductSolds { get; set; }

        public System.Data.Entity.DbSet<MVPProjectOne.Models.Store> Stores { get; set; }
    }
}
