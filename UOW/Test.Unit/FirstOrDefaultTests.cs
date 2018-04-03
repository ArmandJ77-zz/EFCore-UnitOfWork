using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using Test.Unit.Infrastructure;
using UOW.Consumer.Repository;
using UOW.Consumer.Repository.Infrastructure;

namespace Test.Unit
{
    [TestFixture]
    public class FirstOrDefaultTests : BaseUnitTest
    {
        [Test]
        public void Products_FirstOrDefault_Predicate()
        {
            var item = Uow.GetRepository<Product>().GetFirstOrDefault(predicate: p => p.CategoryId == 2);
            StringAssert.AreEqualIgnoringCase(DatabaseSeed.Products.FirstOrDefault(x => x.CategoryId == 2).Name, item.Name);
        }

        [Test]
        public async Task Products_FirstOrDefaultAsync_Predicate()
        {
            var item = await Uow.GetRepository<Product>().GetFirstOrDefaultAsync(predicate: p => p.CategoryId == 2);
            StringAssert.AreEqualIgnoringCase(DatabaseSeed.Products.FirstOrDefault(x => x.CategoryId == 2).Name, item.Name);
        }

        [Test]
        public void Products_FirstOrDefault_PredicateOrderByDesc()
        {
            var item = Uow.GetRepository<Product>().GetFirstOrDefault(
                predicate: p => p.CategoryId == 2,
                orderBy: o => o.OrderByDescending(d => d.Id));
            StringAssert.AreEqualIgnoringCase(DatabaseSeed.Products
                .OrderByDescending(d => d.Id)
                .FirstOrDefault()
                .Name
                , item.Name);
        }

        [Test]
        public async Task Products_FirstOrDefaultAsync_PredicateOrderByDesc()
        {
            var item = await Uow.GetRepository<Product>().GetFirstOrDefaultAsync(
                predicate: p => p.CategoryId == 2,
                orderBy: o => o.OrderByDescending(d => d.Id));
            StringAssert.AreEqualIgnoringCase(DatabaseSeed.Products
                    .OrderByDescending(d => d.Id)
                    .FirstOrDefault()
                    .Name
                , item.Name);
        }

        [Test]
        public void Products_FirstOrDefault_PredicateOrderByDescIncluding()
        {
            var item = Uow.GetRepository<Product>().GetFirstOrDefault(
                predicate: p => p.CategoryId == 2,
                orderBy: o => o.OrderByDescending(d => d.Id),
                include: i => i.Include(o => o.Supplier));

            var origional = DatabaseSeed.Products
                .OrderByDescending(d => d.Id)
                .FirstOrDefault();

            var supplier = DatabaseSeed.Suppliers.FirstOrDefault(x => x.Id == origional.SupplierId);

            StringAssert.AreEqualIgnoringCase(origional.Name, item.Name);
            StringAssert.AreEqualIgnoringCase(supplier.Name, item.Supplier.Name);
        }

        [Test]
        public async Task Products_FirstOrDefaultAsync_PredicateOrderByDescIncluding()
        {
            var item = await Uow.GetRepository<Product>().GetFirstOrDefaultAsync(
                predicate: p => p.CategoryId == 2,
                orderBy: o => o.OrderByDescending(d => d.Id),
                include: i => i.Include(o => o.Supplier));

            var origional = DatabaseSeed.Products
                .OrderByDescending(d => d.Id)
                .FirstOrDefault();

            var supplier = DatabaseSeed.Suppliers.FirstOrDefault(x => x.Id == origional.SupplierId);

            StringAssert.AreEqualIgnoringCase(origional.Name, item.Name);
            StringAssert.AreEqualIgnoringCase(supplier.Name, item.Supplier.Name);
        }

        [Test]
        public void Products_FirstOrDefault_OrderByDescIncluding()
        {
            var item = Uow.GetRepository<Product>().GetFirstOrDefault(
                orderBy: o => o.OrderByDescending(d => d.Id),
                include: i => i.Include(o => o.Supplier));

            var origional = DatabaseSeed.Products.OrderByDescending(d => d.Id).FirstOrDefault();
            Assert.That(item.Supplier.Id, Is.EqualTo(origional.SupplierId));
        }

        [Test]
        public async Task Products_FirstOrDefaultAsync_OrderByDescIncluding()
        {
            var item = await Uow.GetRepository<Product>().GetFirstOrDefaultAsync(
                orderBy: o => o.OrderByDescending(d => d.Id),
                include: i => i.Include(o => o.Supplier));

            var origional = DatabaseSeed.Products.OrderByDescending(d => d.Id).FirstOrDefault();
            Assert.That(item.Supplier.Id, Is.EqualTo(origional.SupplierId));
        }

        [Test]
        public void Products_FirstOrDefault_OrderByDesc()
        {
            var item = Uow.GetRepository<Product>().GetFirstOrDefault(
                orderBy: o => o.OrderByDescending(d => d.Id));

            var origional = DatabaseSeed.Products.OrderByDescending(d => d.Id).FirstOrDefault();
            Assert.That(item.Id, Is.EqualTo(origional.Id));
        }

        [Test]
        public async Task Products_FirstOrDefaultAsync_OrderByDesc()
        {
            var item = await Uow.GetRepository<Product>().GetFirstOrDefaultAsync(
                orderBy: o => o.OrderByDescending(d => d.Id));

            var origional = DatabaseSeed.Products.OrderByDescending(d => d.Id).FirstOrDefault();
            Assert.That(item.Id, Is.EqualTo(origional.Id));
        }

        [Test]
        public void Products_FirstOrDefault_Including()
        {
            var item = Uow.GetRepository<Product>().GetFirstOrDefault(
                include: i => i.Include(o => o.Supplier));

            var origional = DatabaseSeed.Products.FirstOrDefault();
            Assert.That(item.Supplier.Id, Is.EqualTo(origional.SupplierId));
        }

        [Test]
        public void Products_FirstOrDefaultAsync_Including()
        {
            var item = Uow.GetRepository<Product>().GetFirstOrDefault(
                include: i => i.Include(o => o.Supplier));

            var origional = DatabaseSeed.Products.FirstOrDefault();
            Assert.That(item.Supplier.Id, Is.EqualTo(origional.SupplierId));
        }
    }
}
