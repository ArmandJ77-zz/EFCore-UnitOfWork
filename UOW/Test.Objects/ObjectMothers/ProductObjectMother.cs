using Test.Objects.Builders;

namespace Test.Objects.ObjectMothers
{
    public sealed class ProductObjectMother
    {
        public static  ProductBuilder aDefaultProduct()
            => ProductBuilder.aProductBuilder();
    }
}
