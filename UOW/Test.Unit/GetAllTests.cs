using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Linq;
using Test.Unit.Infrastructure;
using UOW.Consumer.Repository;
using UOW.Consumer.Repository.Infrastructure;

namespace Test.Unit
{
    [TestFixture]
    public class GetAllTests:BaseUnitTest
    {
        [Test]
        public void Products_GetAll_AllProducts()
        {
            var items = Uow.GetRepository<Product>().GetAll().ToList();

            Assert.That(items.Count, Is.EqualTo(DatabaseSeed.Products.Count));
        }
    }
}
