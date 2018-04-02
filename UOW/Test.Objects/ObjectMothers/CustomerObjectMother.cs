using Test.Objects.Builders;

namespace Test.Objects.ObjectMothers
{
    public sealed class CustomerObjectMother
    {
        public static CustomerBuilder aDefaultCustomer()
            => CustomerBuilder.aCustomerBuilder();
    }
}
