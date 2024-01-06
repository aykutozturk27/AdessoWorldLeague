using AdessoWorldLeague.Entities.Concrete;

namespace AdessoWorldLeague.Business.Abstract
{
    public interface ITeamService
    {
        List<List<Team>> PlaceTeamsInGroups(int teamsPerGroup);
    }
}
