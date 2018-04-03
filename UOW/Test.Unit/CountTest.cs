using NUnit.Framework;
using Test.Unit.Infrastructure;
using UOW.Consumer.Repository;

namespace Test.Unit
{
    [TestFixture]
    public class CountTest : BaseUnitTest
    {
        [Test]
        public void Products_CountItems_GraterThan0()
        {
            var count = Uow.GetRepository<Product>().Count();

            Assert.That(count,Is.GreaterThan(0));
        }

    }
}
