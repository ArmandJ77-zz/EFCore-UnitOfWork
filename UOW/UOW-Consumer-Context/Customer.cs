using UOW.Consumer.Repository.Infrastructure;
using UOW.DeleteRestriction;

namespace UOW.Consumer.Repository
{
    public class Customer : BaseRepository, IDeletable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
    }
}
