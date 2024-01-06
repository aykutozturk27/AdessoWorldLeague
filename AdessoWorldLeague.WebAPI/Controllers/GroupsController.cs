using AdessoWorldLeague.Business.Abstract;
using AdessoWorldLeague.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdessoWorldLeague.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupService _groupService;
        private readonly ITeamService _teamService;

        public GroupsController(IGroupService groupService, ITeamService teamService)
        {
            _groupService = groupService;
            _teamService = teamService;
        }

        [HttpPost("{teamsPerGroup}")]
        public IActionResult GetAll(int teamsPerGroup = 4)
        {
            string message = string.Empty;
            if (teamsPerGroup != 4 && teamsPerGroup != 8)
            {
                message = "Takım adedi 4 veya 8 den farklı olamaz";
                return BadRequest(message);
            }
            else
            {
                List<List<Team>> teamList = _teamService.PlaceTeamsInGroups(teamsPerGroup);
                if (teamList == null)
                {
                    return BadRequest();
                }
                var result = _groupService.PrintGroups(teamList);
                return Ok(result);
            }
        }
    }
}
