using UOW.Consumer.Repository.Infrastructure;
using UOW.DeleteRestriction;

namespace UOW.Consumer.Repository
{
    public class Supplier : BaseRepository, IDeletable
    {
        public string Name { get; set; }
    }
}
