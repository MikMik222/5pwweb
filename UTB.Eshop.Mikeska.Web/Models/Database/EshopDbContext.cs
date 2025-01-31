﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using UTB.Eshop.Mikeska.Web.Models.Database.Configuration;
using UTB.Eshop.Mikeska.Web.Models.Entities;
using UTB.Eshop.Mikeska.Web.Models.Identity;

namespace UTB.Eshop.Mikeska.Web.Models.Database
{
    public class EshopDbContext : IdentityDbContext<User, Role, int>
    {
        public DbSet<CarouselSlide> CarouselSlides { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Kategorie> Kategories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var entity in builder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().Replace("AspNet", String.Empty));
            }

            DatabaseInit databaseInit = new DatabaseInit();
            builder.Entity<CarouselSlide>().HasData(databaseInit.CreateCarouselSlides());
            builder.Entity<Product>().HasData(databaseInit.CreateProducts());
            builder.Entity<Kategorie>().HasData(databaseInit.CreateKategorie());


            builder.Entity<Role>().HasData(databaseInit.CreateRoles());

            (User admin, List<IdentityUserRole<int>> adminUserRoles) = databaseInit.CreateAdminWithRoles();
            (User manager, List<IdentityUserRole<int>> managerUserRoles) = databaseInit.CreateManagerWithRoles();

            builder.Entity<User>().HasData(admin, manager);
            builder.Entity<IdentityUserRole<int>>().HasData(adminUserRoles);
            builder.Entity<IdentityUserRole<int>>().HasData(managerUserRoles);

            builder.ApplyConfiguration<Order>(new OrderConfiguration());
        }
    }
}
