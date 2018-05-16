namespace MVPProjectOne.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProjectOne : DbContext
    {
        public ProjectOne()
            : base("name=ProjectOne")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSold> ProductSolds { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ProductSolds)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.Customer_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductSolds)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.Product_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.ProductSolds)
                .WithRequired(e => e.Store)
                .HasForeignKey(e => e.Store_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
