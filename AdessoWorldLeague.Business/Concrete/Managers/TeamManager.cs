using AdessoWorldLeague.Business.Abstract;
using AdessoWorldLeague.Entities.Concrete;

namespace AdessoWorldLeague.Business.Concrete.Managers
{
    public class TeamManager : ITeamService
    {
        private List<Team> _teams;

        public TeamManager()
        {
            _teams = new List<Team>
            {
                #region Türkiye
		        new Team{ Name = "Adesso İstanbul" },
                new Team{ Name = "Adesso Ankara" },
                new Team{ Name = "Adesso İzmir" },
                new Team{ Name = "Adesso Antalya" }, 
	            #endregion

                #region Almanya
                new Team{ Name = "Adesso Berlin" },
                new Team{ Name = "Adesso Frankfurt" },
                new Team{ Name = "Adesso Münih" },
                new Team{ Name = "Adesso Dortmund" },
                #endregion

                #region Fransa
                new Team{ Name = "Adesso Paris"  },
                new Team{ Name = "Adesso Marsilya" },
                new Team{ Name = "Adesso Nice" },
                new Team{ Name = "Adesso Lyon" },
                #endregion

                #region Hollanda
                new Team{ Name = "Adesso Amsterdam" },
                new Team{ Name = "Adesso Rotterdam" },
                new Team{ Name = "Adesso Lahey" },
                new Team{ Name = "Adesso Eindhoven" },
                #endregion

                #region Portekiz
                new Team{ Name = "Adesso Lisbon" },
                new Team{ Name = "Adesso Porto" },
                new Team{ Name = "Adesso Braga" },
                new Team{ Name = "Adesso Coimbra"},
                #endregion

                #region İtalya
                new Team{ Name = "Adesso Roma" },
                new Team{ Name = "Adesso Milano" },
                new Team{ Name = "Adesso Venedik" },
                new Team{ Name = "Adesso Napoli" },
                #endregion

                #region İspanya
                new Team{ Name = "Adesso Sevilla" },
                new Team{ Name = "Adesso Madrid" },
                new Team{ Name = "Adesso Barselona" },
                new Team{ Name = "Adesso Granada" },
                #endregion

                #region Belçika
                new Team{ Name = "Adesso Brüksel" },
                new Team{ Name = "Adesso Brugge" },
                new Team{ Name = "Adesso Gent" },
                new Team{ Name = "Adesso Anvers" },
                #endregion
            };
        }

        public List<List<Team>> PlaceTeamsInGroups(int teamsPerGroup)
        {
            List<List<Team>> groups = new List<List<Team>>();

            var shuffledTeams = _teams.OrderBy(x => Guid.NewGuid()).ToList();

            for (int i = 0; i < shuffledTeams.Count; i += teamsPerGroup)
            {
                List<Team> group = shuffledTeams.Skip(i).Take(teamsPerGroup).ToList();
                groups.Add(group);
            }

            return groups;
        }
    }
}
