using Test.Objects.Infrastructure.TestObjects.Infrastructure;
using UOW.Consumer.Repository;

namespace Test.Objects.Builders
{
    public class CategoryBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        private CategoryBuilder() { }

        public static CategoryBuilder aCategoryBuilder()
            => new CategoryBuilder();

        public CategoryBuilder WithId(int id)
        {
            this.Id = id;
            return this;
        }

        public CategoryBuilder WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public Category ToRepository()
            => Converter.Convert<CategoryBuilder, Category>(this, new Category());
    }
}
