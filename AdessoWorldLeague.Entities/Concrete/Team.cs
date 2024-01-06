using AdessoWorldLeague.Core.Entities;

namespace AdessoWorldLeague.Entities.Concrete
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}
