namespace Test.Objects.Builders
{
    public class ProductBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public decimal Price { get; set; }

        private ProductBuilder() { }

        public static ProductBuilder aProductBuilder()
            => new ProductBuilder();

        public ProductBuilder WithId(int id)
        {
            this.Id = id;
            return this;
        }

        public ProductBuilder WithCategoryId(int id)
        {
            this.CategoryId = id;
            return this;
        }

        public ProductBuilder WithSupplierId(int id)
        {
            this.SupplierId = id;
            return this;
        }

        public ProductBuilder WithPrice(decimal price)
        {
            this.Price = price;
            return this;
        }

        public ProductBuilder WithName(string name)
        {
            this.Name = name;
            return this;
        }
    }
}
