using AdessoWorldLeague.Business.Abstract;
using AdessoWorldLeague.Entities.Concrete;

namespace AdessoWorldLeague.Business.Concrete.Managers
{
    public class GroupManager : IGroupService
    {
        private List<Group> _groups;
        private List<BaseGroup> _baseGroups;

        public GroupManager()
        {
            _groups = new List<Group>
            {
                new Group{ GroupName = "A" },
                new Group{ GroupName = "B" },
                new Group{ GroupName = "C" },
                new Group{ GroupName = "D" },
                new Group{ GroupName = "E" },
                new Group{ GroupName = "F" },
                new Group{ GroupName = "G" },
                new Group{ GroupName = "H" },
            };
            _baseGroups = new List<BaseGroup>();
        }

        public List<BaseGroup> PrintGroups(List<List<Team>> teams)
        {
            List<Group> groupList = new List<Group>();
            List<BaseGroup> result = new List<BaseGroup>();
            int i = 0;
            foreach (var teamItem in teams)
            {
                groupList.Add(new Group { GroupName = $"Group {_groups[i].GroupName}", Teams = teamItem });
                i++;
            }

            result.Add(new BaseGroup { Groups = groupList });
            return result;
        }
    }
}
