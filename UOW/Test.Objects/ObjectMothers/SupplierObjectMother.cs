using System.Collections.Generic;
using Test.Objects.Builders;
using UOW.Consumer.Repository;

namespace Test.Objects.ObjectMothers
{
    public static class SupplierObjectMother
    {
        public static SupplierBuilder aDefaultSupplier()
            => SupplierBuilder.aSupplierBuilder();


        public static List<Supplier> aListOfSuppliers()
            => new List<Supplier>
            {
                SupplierBuilder.aSupplierBuilder().WithName("Asus").ToRepository(),
                SupplierBuilder.aSupplierBuilder().WithName("Razer").ToRepository(),
                SupplierBuilder.aSupplierBuilder().WithName("Samsung").ToRepository(),
                SupplierBuilder.aSupplierBuilder().WithName("MSI").ToRepository(),
                SupplierBuilder.aSupplierBuilder().WithName("NZXT").ToRepository(),
                SupplierBuilder.aSupplierBuilder().WithName("Corsair").ToRepository(),
                SupplierBuilder.aSupplierBuilder().WithName("WesternDigital").ToRepository(),
            };
    }
}
