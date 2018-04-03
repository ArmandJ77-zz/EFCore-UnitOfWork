using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Linq;
using System.Threading.Tasks;
using Test.Unit.Infrastructure;
using UOW.Consumer.Repository;
using UOW.Consumer.Repository.Infrastructure;

namespace Test.Unit
{
    [TestFixture]
    public class FindTest : BaseUnitTest
    {
        [Test]
        public void Products_FindById_FirstItem()
        {
            var item = Uow.GetRepository<Product>().Find(1);

            StringAssert.AreEqualIgnoringCase(DatabaseSeed.Products.FirstOrDefault().Name,item.Name);
        }

        [Test]
        public async Task Products_FindByIdAsync_NameEqualsSeedDataName()
        {
            var item = await Uow.GetRepository<Product>().FindAsync(1);

            StringAssert.AreEqualIgnoringCase(DatabaseSeed.Products.FirstOrDefault().Name, item.Name);
        }
    }
}
