using UOW.Consumer.Repository.Infrastructure;
using UOW.DeleteRestriction;

namespace UOW.Consumer.Repository
{
    public class Category : BaseRepository, IDeletable
    {
        public string Name { get; set; }
    }
}
