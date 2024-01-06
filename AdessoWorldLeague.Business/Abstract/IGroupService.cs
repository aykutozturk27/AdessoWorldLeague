using AdessoWorldLeague.Entities.Concrete;

namespace AdessoWorldLeague.Business.Abstract
{
    public interface IGroupService
    {
        List<BaseGroup> PrintGroups(List<List<Team>> teams);
    }
}
