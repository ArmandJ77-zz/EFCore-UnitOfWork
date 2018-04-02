using Test.Objects.Builders;

namespace Test.Objects.ObjectMothers
{
    public static class SupplierObjectMother
    {
        public static SupplierBuilder aDefaultSupplier()
            => SupplierBuilder.aSupplierBuilder();
    }
}
