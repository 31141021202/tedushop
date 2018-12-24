namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeduShop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "tedu",
            //    Email = "tedu.international@gmail.com",
            //    EmailConfirmed = true,
            //    Birthday = DateTime.Now,
            //    FullName = "Technology Education"
            //};

            //manager.Create(user, "123456");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("tedu.international@gmail.com");
            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }

        private void CreateProductCategorySample(TeduShopDbContext context)
        {
            if(context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name = "Dien lanh", Alias = "dien-lanh", Status = true },
                    new ProductCategory() { Name = "Vien thong", Alias = "vien-thong", Status = true },
                    new ProductCategory() { Name = "Do gia dung", Alias = "do-gia-dung", Status = true },
                    new ProductCategory() { Name = "My pham", Alias = "my-pham", Status = true }
                };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}
