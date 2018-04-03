using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UOW.Consumer.Repository.Infrastructure
{
    public static class DatabaseSeed
    {
        public static List<Category> Categories => new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "Headset"
            },
            new Category
            {
                Id = 2,
                Name = "Mouse"
            },
            new Category
            {
                Id = 3,
                Name = "Keyboard"
            },
            new Category
            {
                Id = 4,
                Name = "Broadcaster"
            },
            new Category
            {
                Id = 5,
                Name = "Console"
            },
            new Category
            {
                Id = 6,
                Name = "Mats"
            },
        };
        public static List<Supplier> Suppliers => new List<Supplier>
        {
            new Supplier
            {
                Id = 1,
                Name = "Razer",
            },
        };
        public static List<Product> Products => new List<Product>
        {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Leviathan",
                Price = 199.99
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Kraken Mobile - Yellow",
                Price = 89.99
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Hammerhead Pro V2",
                Price = 69.99
            },
            new Product
            {
                Id = 4,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Leviathan Mini",
                Price = 179.99
            },
            new Product
            {
                Id = 5,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Kraken Pro V2 - Black - Oval Ear Cushion",
                Price = 79.99
            },
            new Product
            {
                Id = 6,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Hammerhead BT",
                Price = 99.99
            },
            new Product
            {
                Id = 7,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Hammerhead for iOS",
                Price = 99.99
            },
            new Product
            {
                Id = 8,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Kraken 7.1 V2 - Black - Oval Ear Cushions",
                Price = 99.99
            },
            new Product
            {
                Id = 9,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Kraken Pro V2 - White - Oval Ear Cushion",
                Price = 79.99
            },
            new Product
            {
                Id = 10,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Kraken Pro V2 - Green - Oval Ear Cushion",
                Price = 79.99
            },
            new Product
            {
                Id = 11,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Thresher Ultimate for PlayStation 4",
                Price = 1249.99
            },
            new Product
            {
                Id = 12,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Thresher Ultimate for Xbox One",
                Price = 249.99
            },
            new Product
            {
                Id = 13,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Tiamat 2.2 V2",
                Price = 129.99
            },
            new Product
            {
                Id = 14,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Destiny 2 Razer ManO'War Tournament Edition",
                Price = 109.99
            },
            new Product
            {
                Id = 15,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Tiamat 7.1 V2",
                Price = 199.99
            },
            new Product
            {
                Id = 16,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Kraken 7.1 V2 - Mercury White - Oval Ear Cushions",
                Price = 99.99
            },
            new Product
            {
                Id = 17,
                CategoryId = 1,
                SupplierId = 1,
                Name = "Razer Kraken 7.1 V2 - Gunmetal Grey - Oval Ear Cushions",
                Price = 99.99
            },
            new Product
            {
                Id = 18,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer DeathAdder Left-Hand Edition",
                Price = 59.99
            },
            new Product
            {
                Id = 19,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Abyssus V2",
                Price = 49.99
            },
            new Product
            {
                Id = 20,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Naga Epic Chroma",
                Price = 129.99
            },
            new Product
            {
                Id = 21,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer DeathAdder Elite",
                Price = 69.99
            },
            new Product
            {
                Id = 22,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Lancehead Tournament Edition - Black",
                Price = 79.99
            },
            new Product
            {
                Id = 23,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Lancehead",
                Price = 139.99
            },
            new Product
            {
                Id = 24,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Mamba",
                Price = 149.99
            },
            new Product
            {
                Id = 25,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Mamba Tournament Edition",
                Price = 89.99
            },
            new Product
            {
                Id = 26,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Lancehead Tournament Edition - Gunmetal Grey",
                Price = 79.99
            },
            new Product
            {
                Id = 27,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Destiny 2 Razer DeathAdder Elite",
                Price = 79.99
            },
            new Product
            {
                Id = 28,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Lancehead Tournament Edition - Mercury White",
                Price = 79.99
            },
            new Product
            {
                Id = 29,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Atheris",
                Price = 49.99
            },
            new Product
            {
                Id = 30,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Basilisk",
                Price = 69.99
            },
            new Product
            {
                Id = 31,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Overwatch Razer DeathAdder Elite",
                Price = 79.99
            },
            new Product
            {
                Id = 32,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Naga Trinity",
                Price = 99.99
            },
            new Product
            {
                Id = 33,
                CategoryId = 2,
                SupplierId = 1,
                Name = "D.Va Razer Abyssus Elite",
                Price = 59.99
            },
            new Product
            {
                Id = 34,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer DeathAdder Elite SKT T1 Edition",
                Price = 79.99
            },
            new Product
            {
                Id = 35,
                CategoryId = 2,
                SupplierId = 1,
                Name = "Razer Lancehead Tournament Edition - Quartz Edition",
                Price = 793.99
            },
        };
        //public static List<Customer> Customers => new List<Customer>()
        //public static List<Sales> Sales => new List<Sales>();
        
        
        public static void SeedSql(DatabaseContext context)
        {
            SeedCategories(context);
            SeedSupplier(context);
            SeedProducts(context);
            //SeedCustomers(context);
            //SeedSales(context);
        }

        public static void SeedInMemory(DatabaseContext context)
        {
            if (!context.Categories.Any())
                Categories.ForEach(x =>
                {
                    context.Categories.Add(x);
                    context.SaveChanges();
                });

            if (!context.Suppliers.Any())
                Suppliers.ForEach(x =>
                {
                    context.Suppliers.Add(x);
                    context.SaveChanges();
                });

            if (!context.Products.Any())
                Products.ForEach(x =>
                {
                    context.Products.Add(x);
                    context.SaveChanges();
                });
        }

        public static void SeedSales(DatabaseContext context)
        {
            //Console.WriteLine("Seeding Sales");
            //if (context.Sales.Any())
            //{
            //    Console.WriteLine("Truncating Sales");
            //    context.Database.ExecuteSqlCommand($"DELETE [dbo].[Sales]");
            //    context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT ('Sales',RESEED, 0)");
            //}

            //Console.WriteLine("Enable Identity Insert on Sales");
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Sales] ON");

            //Console.WriteLine("Adding Sales");

            //Sales.ForEach(x =>
            //{
            //    context.Sales.Add(x);
            //    context.SaveChanges();
            //});
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Sales] OFF");
            //context.Database.CloseConnection();
            //Console.WriteLine("Products Sales");
        }

        public static void SeedCustomers(DatabaseContext context)
        {
            //Console.WriteLine("Seeding Customers");
            //if (context.Customers.Any())
            //{
            //    Console.WriteLine("Truncating Customers");
            //    context.Database.ExecuteSqlCommand($"DELETE [dbo].[Customers]");
            //    context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT ('Customers',RESEED, 0)");
            //}

            //Console.WriteLine("Enable Identity Insert on Customers");
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Customers] ON");

            //Console.WriteLine("Adding Customers");

            //Customers.ForEach(x =>
            //{
            //    context.Customers.Add(x);
            //    context.SaveChanges();
            //});
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Customers] OFF");
            //context.Database.CloseConnection();
            //Console.WriteLine("Customers Saved");
        }

        public static void SeedProducts(DatabaseContext context)
        {
            context.Database.OpenConnection();
            Console.WriteLine("Seeding Products");
            if (context.Products.Any())
            {
                Console.WriteLine("Truncating Products");
                context.Database.ExecuteSqlCommand($"DELETE [dbo].[Products]");
                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT ('Products',RESEED, 0)");
            }

            Console.WriteLine("Enable Identity Insert on Products");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Products] ON");

            Console.WriteLine("Adding Products");

            Products.ForEach(x =>
            {
                context.Products.Add(x);
                context.SaveChanges();
            });
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Products] OFF");
            context.Database.CloseConnection();
            Console.WriteLine("Products Saved");
            context.Database.CloseConnection();
        }

        public static void SeedCategories(DatabaseContext context)
        {
            context.Database.OpenConnection();
            Console.WriteLine("Seeding Categories");

            if (context.Categories.Any())
            {
                Console.WriteLine("Truncating Categories");
                context.Database.ExecuteSqlCommand($"DELETE [dbo].[Categories]");
                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT ('Categories',RESEED, 0)");
            }

            Console.WriteLine("Enable Identity Insert on Categories");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Categories] ON");

            Console.WriteLine("Adding Categories");

            Categories.ForEach(x =>
            {
                context.Categories.Add(x);
                context.SaveChanges();
            });
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Categories] OFF");
            context.Database.CloseConnection();
            Console.WriteLine("Categories Saved");
            context.Database.CloseConnection();
        }

        public static void SeedSupplier(DatabaseContext context)
        {
            context.Database.OpenConnection();
            Console.WriteLine("Seeding Suppliers");
            if (context.Suppliers.Any())
            {
                Console.WriteLine("Truncating Suppliers");
                context.Database.ExecuteSqlCommand($"DELETE [dbo].[Suppliers]");
                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT ('Suppliers',RESEED, 0)");
            }

            Console.WriteLine("Enable Identity Insert on Suppliers");
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Suppliers] ON");

            Console.WriteLine("Adding Suppliers");

            Suppliers.ForEach(x =>
            {
                context.Suppliers.Add(x);
                context.SaveChanges();
            });
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Suppliers] OFF");
            context.Database.CloseConnection();
            Console.WriteLine("Suppliers Saved");
            context.Database.CloseConnection();
        }
    }
}
