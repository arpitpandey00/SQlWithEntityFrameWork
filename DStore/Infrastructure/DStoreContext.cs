using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DStore.Data.Infrastructure
{
    public class DStoreContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> productOrders { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<SupplierProductOrder> SupplierProductOrders { get; set; }
        public DbSet<ProductCategory> productCategories { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;DataBase=DStore;username=postgres;password=pandey10");        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuring Role
            modelBuilder.Entity<Role>().HasKey(k => k.RoleId);
            modelBuilder.Entity<Role>().Property(x => x.RoleName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Role>().Property(x => x.Description).HasMaxLength(512);

            //configuring address
            modelBuilder.Entity<Address>().HasKey(k => k.AddressId);
            modelBuilder.Entity<Address>().Property(x => x.AddressLine1).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.AddressLine2).HasMaxLength(128);
            modelBuilder.Entity<Address>().Property(x => x.City).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.State).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.Pincode).HasMaxLength(10).IsRequired();
            
            //configuring staff
            modelBuilder.Entity<Staff>().HasKey(r => r.StaffId);
            modelBuilder.Entity<Staff>().Property(x => x.FirstName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.LastName).HasMaxLength(64);
            modelBuilder.Entity<Staff>().Property(x => x.PhoneNumber).HasMaxLength(10).IsRequired().IsFixedLength();
            modelBuilder.Entity<Staff>().Property(x => x.RoleId).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.AddressId).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.Gender).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.Salary).IsRequired();

            //configure inventory
            modelBuilder.Entity<Inventory>().HasNoKey();
            modelBuilder.Entity<Inventory>().HasIndex(r => r.ProductId).IsUnique();
            modelBuilder.Entity<Inventory>().Property(x => x.ProductQuantity).IsRequired();

            //configure category
            modelBuilder.Entity<Category>().HasKey(r => r.CategoryId);
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasMaxLength(32).IsRequired();

            //configure product
            modelBuilder.Entity<Product>().HasKey(r => r.ProductId);
            modelBuilder.Entity<Product>().Property(x => x.ProductCode).HasMaxLength(5).IsRequired().IsFixedLength();
            modelBuilder.Entity<Product>().HasIndex(x => x.ProductCode).IsUnique();
            modelBuilder.Entity<Product>().Property(x => x.Manufacturer).HasMaxLength(64);
            modelBuilder.Entity<Product>().Property(x => x.InStock).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.ExpiryDate).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasMaxLength(64).IsRequired();

            //configure productcategory
            modelBuilder.Entity<ProductCategory>().HasKey(r => new {r.CategoryId, r.ProductId});

            //configure supplier
            modelBuilder.Entity<Supplier>().HasKey(r => r.SupplierId);
            modelBuilder.Entity<Supplier>().Property(r => r.SupplierName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.SupplierAge).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.Gender).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.PhoneNumber).HasMaxLength(10).IsRequired().IsFixedLength();
            modelBuilder.Entity<Supplier>().Property(r => r.AddressId).IsRequired();

            //configure productorder
            modelBuilder.Entity<ProductOrder>().HasKey(r => r.ProductOrderId);
            modelBuilder.Entity<ProductOrder>().Property(x => x.Qunatity).IsRequired();

            //configure supplierproductorder
            modelBuilder.Entity<SupplierProductOrder>().HasKey(r => new {r.ProductId,r.ProductOrderId,r.SupplierId });

            //confgure productrevenue
            modelBuilder.Entity<ProductPrice>().HasKey(r => r.ProductPriceId);
            modelBuilder.Entity<ProductPrice>().Property(r => r.IsActive).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(r=>r.Month).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(r=>r.CostPrice).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(r=>r.SellingPrice).IsRequired();
            modelBuilder.Entity<ProductPrice>().Property(r=>r.ProductId).IsRequired();

        }

    }
}
