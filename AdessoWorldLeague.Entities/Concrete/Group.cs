using AdessoWorldLeague.Core.Entities;

namespace AdessoWorldLeague.Entities.Concrete
{
    public class Group : BaseEntity
    {
        public string GroupName { get; set; }

        public List<Team> Teams { get; set; }
    }
}
