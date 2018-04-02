namespace Test.Objects.Builders
{
    public class CustomerBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }

        private CustomerBuilder() { }

        public static CustomerBuilder aCustomerBuilder()
            => new CustomerBuilder();

        public CustomerBuilder WithId(int id)
        {
            this.Id = id;
            return this;
        }

        public CustomerBuilder WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public CustomerBuilder WithEmail(string email)
        {
            this.Email = email;
            return this;
        }

        public CustomerBuilder WithStreetAddress(string streetAddress)
        {
            this.StreetAddress = streetAddress;
            return this;
        }
    }
}
