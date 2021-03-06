﻿using Net.Application.Shop.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Application.Shop
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("Name=DataContext")
        {

        }

        public DbSet<User> User { get; set; }

        public DbSet<UserAddress> UserAddress { get; set; }

        public DbSet<Payment> Payment { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }
        
        public DbSet<Product> Product { get; set; }

        public DbSet<ProductSell> ProductSell { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithRequired(item => item.Order);

            modelBuilder.Entity<ProductSell>()
                .HasMany(s => s.Category)
                .WithMany(c => c.Sells)
                .Map(m =>
                {
                    m.MapLeftKey("SellID");
                    m.MapRightKey("CategoryID");
                    m.ToTable("ProductSellCategoryMap");
                });
        }
    }
}
