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
		        new Team{ Name = "Adesso İstanbul", CountryId = 1 },
                new Team{ Name = "Adesso Ankara", CountryId = 1 },
                new Team{ Name = "Adesso İzmir", CountryId = 1 },
                new Team{ Name = "Adesso Antalya", CountryId = 1 }, 
	            #endregion

                #region Almanya
                new Team{ Name = "Adesso Berlin", CountryId = 2 },
                new Team{ Name = "Adesso Frankfurt", CountryId = 2 },
                new Team{ Name = "Adesso Münih", CountryId = 2 },
                new Team{ Name = "Adesso Dortmund", CountryId = 2 },
                #endregion

                #region Fransa
                new Team{ Name = "Adesso Paris", CountryId = 3 },
                new Team{ Name = "Adesso Marsilya", CountryId = 3 },
                new Team{ Name = "Adesso Nice", CountryId = 3 },
                new Team{ Name = "Adesso Lyon", CountryId = 3 },
                #endregion

                #region Hollanda
                new Team{ Name = "Adesso Amsterdam", CountryId = 4 },
                new Team{ Name = "Adesso Rotterdam", CountryId = 4 },
                new Team{ Name = "Adesso Lahey", CountryId = 4 },
                new Team{ Name = "Adesso Eindhoven", CountryId = 4 },
                #endregion

                #region Portekiz
                new Team{ Name = "Adesso Lisbon", CountryId = 5 },
                new Team{ Name = "Adesso Porto", CountryId = 5 },
                new Team{ Name = "Adesso Braga", CountryId = 5 },
                new Team{ Name = "Adesso Coimbra", CountryId = 5 },
                #endregion

                #region İtalya
                new Team{ Name = "Adesso Roma", CountryId = 6 },
                new Team{ Name = "Adesso Milano", CountryId = 6 },
                new Team{ Name = "Adesso Venedik", CountryId = 6 },
                new Team{ Name = "Adesso Napoli", CountryId = 6 },
                #endregion

                #region İspanya
                new Team{ Name = "Adesso Sevilla", CountryId = 7 },
                new Team{ Name = "Adesso Madrid", CountryId = 7 },
                new Team{ Name = "Adesso Barselona", CountryId = 7 },
                new Team{ Name = "Adesso Granada", CountryId = 7 },
                #endregion

                #region Belçika
                new Team{ Name = "Adesso Brüksel", CountryId = 8 },
                new Team{ Name = "Adesso Brugge", CountryId = 8 },
                new Team{ Name = "Adesso Gent", CountryId = 8 },
                new Team{ Name = "Adesso Anvers", CountryId = 8 },
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
