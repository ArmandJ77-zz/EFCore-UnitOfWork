using NUnit.Framework;
using Test.Unit.Infrastructure;
using UOW.Consumer.Repository;

namespace Test.Unit
{
    [TestFixture]
    public class CountTest : BaseUnitTest
    {
        [Test]
        public void Products_Count_GraterThan0()
        {
            var count = Uow.GetRepository<Product>().Count();

            Assert.That(count,Is.GreaterThan(0));
        }

        [Test]
        public void Category_Count_GraterThan0()
        {
            var count = Uow.GetRepository<Category>().Count();

            Assert.That(count, Is.GreaterThan(0));
        }

        [Test]
        public void Supplier_Count_GraterThan0()
        {
            var count = Uow.GetRepository<Supplier>().Count();

            Assert.That(count, Is.GreaterThan(0));
        }

    }
}
