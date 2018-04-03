using Microsoft.EntityFrameworkCore;
using UOW.DeleteRestriction;

namespace UOW.Consumer.Repository
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DatabaseContext()
        { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //Create a sql user with enough premission to execute the set identity on used by the 
        //    //data seed user can be anything just rememebr to change here
        //    optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=UOWConsumerDb;User ID=UOWConsumerDbUser;Password=UOWConsumerDbUser");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(IDeletable).IsAssignableFrom(entity.ClrType) != true) continue;
                //Remove shadow property because when you use _dbset.Find it may return tracked entities that may have been marked as deleted then there is no way to check. If IsDeleted == true. As IDetalable and IsDelted prop to the Entity
                //entity.AddProperty(IsDeletedProperty, typeof(bool));

                modelBuilder
                    .Entity(entity.ClrType)
                    .HasQueryFilter(IsDeletableRestriction.
                        GetRestrictionExpression(entity.ClrType));
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
