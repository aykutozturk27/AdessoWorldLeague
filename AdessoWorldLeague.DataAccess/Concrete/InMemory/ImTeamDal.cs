using AdessoWorldLeague.Core.DataAccess.InMemory;
using AdessoWorldLeague.DataAccess.Abstract;
using AdessoWorldLeague.Entities.Concrete;

namespace AdessoWorldLeague.DataAccess.Concrete.InMemory
{
    public class ImTeamDal : ImEntityRepositoryBase<Team>, ITeamDal
    {
    }
}
