using AutoMapper;
using DotnetBootcamp.Core.DTOs;
using DotnetBootcamp.Core.Models;
using DotnetBootcamp.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBootcamp.API.Controllers
{
    public class UserController :CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService  userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var users = await _userService.GetAllAsync();
            var usersDto = _mapper.Map<List<UserDto>>(users.ToList());
            return CreateActionResult(GlobalResultDto<List<UserDto>>.Success(200, usersDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetById(id);
            var userDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(GlobalResultDto<UserDto>.Success(200,userDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(UserDto userDto)
        {
            var user = await _userService.AddAsync(_mapper.Map<User>(userDto));
            var userDtos = _mapper.Map<UserDto>(user);
            return CreateActionResult(GlobalResultDto<UserDto>.Success(201, userDtos));
        }
        [HttpPut]
        public async Task<IActionResult> Update(UserDto userDto)
        {
            await _userService.UpdateAsync(_mapper.Map<User>(userDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var user = await _userService.GetById(id);
            await _userService.RemoveAsync(user);
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
