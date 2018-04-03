using Test.Objects.Builders;

namespace Test.Objects.ObjectMothers
{
    public sealed class ProductObjectMother
    {
        public static  ProductBuilder aDefaultProduct()
            => ProductBuilder.aProductBuilder();

        //public static List<Product> AListOfProducts()
        //    => new List<Product>
        //    {
        //        ProductBuilder.aProductBuilder()
        //            .WithName("")
        //        .WithCategoryId()
        //        .WithSupplierId()
        //        .
        //    };
    }
}
