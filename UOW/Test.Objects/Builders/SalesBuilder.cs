namespace Test.Objects.Builders
{
    public class SalesBuilder
    {

        public int Id { get; set; }
        public int Qty { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        private SalesBuilder() { }

        public static SalesBuilder aSalesBuilder()
            => new SalesBuilder();

        public SalesBuilder WithId(int id)
        {
            this.Id = id;
            return this;
        }

        public SalesBuilder WithProductId(int id)
        {
            this.ProductId = id;
            return this;
        }

        public SalesBuilder WithCustomerId(int id)
        {
            this.CustomerId = id;
            return this;
        }

        public SalesBuilder WithQty(int qty)
        {
            this.Qty = qty;
            return this;
        }
    }
}
