using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UOW.Consumer.Repository;
using UOW.Consumer.Repository.Infrastructure;

namespace UOW.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer(@"Data Source=.;Initial Catalog=UOWConsumerDb;User ID=UOWConsumerDbUser;Password=UOWConsumerDbUser")
                .Options;

            using (var context = new DatabaseContext(options))
            {
                DatabaseSeed.SeedSql(context);

                Console.WriteLine($"Seed added {context.Categories.ToList().Count} categories");
                Console.WriteLine($"Seed added {context.Suppliers.ToList().Count} suppliers");
                Console.WriteLine($"Seed added {context.Products.ToList().Count} products");

            }

            Console.ReadLine();
        }
    }
}
