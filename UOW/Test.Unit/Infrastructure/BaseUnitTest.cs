using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using UOW;
using UOW.Consumer.Repository;
using UOW.Consumer.Repository.Infrastructure;

namespace Test.Unit.Infrastructure
{
    public class BaseUnitTest
    {
        public IUnitOfWork Uow { get; set; }
        public DatabaseContext Context { get; set; }

        public BaseUnitTest() { }

        [OneTimeSetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "UOW_InMemory")
                .Options;

            Context = new DatabaseContext(options);
            DatabaseSeed.SeedInMemory(Context);
            Uow = new UnitOfWork<DatabaseContext>(Context);

            
        }
    }
}
