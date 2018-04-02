namespace Test.Objects.Infrastructure
{
    namespace TestObjects.Infrastructure
    {
        public class Converter
        {
            public static TDestination Convert<TSource, TDestination>(TSource source, TDestination destination) where TSource : class where TDestination : class
            {
                var sourceProperties = source.GetType().GetProperties();
                var destinationProperties = destination.GetType().GetProperties();
                foreach (var parentProperty in sourceProperties)
                {
                    foreach (var childProperty in destinationProperties)
                    {
                        if (parentProperty.Name != childProperty.Name ||
                            parentProperty.PropertyType != childProperty.PropertyType) continue;
                        childProperty.SetValue(destination, parentProperty.GetValue(source)); break;
                    }
                }

                return destination;
            }
        }
    }
}
