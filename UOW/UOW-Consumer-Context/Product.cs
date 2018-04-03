using UOW.Consumer.Repository.Infrastructure;
using UOW.DeleteRestriction;

namespace UOW.Consumer.Repository
{
    public class Product : BaseRepository, IDeletable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public bool IsDeleted { get; set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
    }
}
