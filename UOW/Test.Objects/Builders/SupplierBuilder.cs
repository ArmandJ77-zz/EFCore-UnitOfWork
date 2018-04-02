using Test.Objects.Infrastructure.TestObjects.Infrastructure;
using UOW.Consumer.Repository;

namespace Test.Objects.Builders
{
    public class SupplierBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private SupplierBuilder() { }

        public static SupplierBuilder aSupplierBuilder()
            => new SupplierBuilder();

        public SupplierBuilder WithId(int id)
        {
            this.Id = id;
            return this;
        }

        public SupplierBuilder WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public Supplier ToRepository()
            => Converter.Convert<SupplierBuilder, Supplier>(this, new Supplier());
    }
}
