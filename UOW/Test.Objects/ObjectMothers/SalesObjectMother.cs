using Test.Objects.Builders;

namespace Test.Objects.ObjectMothers
{
    public sealed class SalesObjectMother
    {
        public static SalesBuilder aDefaultSale() 
            => SalesBuilder.aSalesBuilder();
    }
}
