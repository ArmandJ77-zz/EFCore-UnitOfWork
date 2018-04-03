using System.Collections.Generic;
using Test.Objects.Builders;
using UOW.Consumer.Repository;

namespace Test.Objects.ObjectMothers
{
    public sealed class CategoryObjectMonther
    {
        public static CategoryBuilder aDefaultCategory()
            => CategoryBuilder.aCategoryBuilder();

        public static List<Category> aListOfCategories()
            => new List<Category>
            {
                CategoryBuilder.aCategoryBuilder().WithName("Chassis").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("Mouse").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("Keyboard").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("Motherboard").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("CPU").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("GPU").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("CLC").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("RAM").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("HDD Solid State").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("Case Fan").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("Mousepad").ToRepository(),
                CategoryBuilder.aCategoryBuilder().WithName("Headsets").ToRepository(),
            };
    }
}
