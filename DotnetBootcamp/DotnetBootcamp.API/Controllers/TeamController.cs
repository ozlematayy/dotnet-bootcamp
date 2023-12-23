using AutoMapper;
using DotnetBootcamp.Core.DTOs;
using DotnetBootcamp.Core.Models;
using DotnetBootcamp.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBootcamp.API.Controllers
{
    public class TeamController :CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITeamService _teamService;

        public TeamController(IMapper mapper, ITeamService teamService)
        {
            _mapper = mapper;
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var teams = await _teamService.GetAllAsync();
            var teamsDto = _mapper.Map<List<TeamDto>>(teams.ToList());
            return CreateActionResult(GlobalResultDto<List<TeamDto>>.Success(200, teamsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var team = await _teamService.GetById(id);
            var teamDto = _mapper.Map<TeamDto>(team);
            return CreateActionResult(GlobalResultDto<TeamDto>.Success(200,teamDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(TeamDto teamDto)
        {
            var team = await _teamService.AddAsync(_mapper.Map<Team>(teamDto));
            var teamDtos = _mapper.Map<TeamDto>(team);
            return CreateActionResult(GlobalResultDto<TeamDto>.Success(201, teamDtos));
        }
        [HttpPut]
        public async Task<IActionResult> Update(TeamDto teamDto)
        {
            await _teamService.UpdateAsync(_mapper.Map<Team>(teamDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var team = await _teamService.GetById(id);
            await _teamService.RemoveAsync(team);
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
