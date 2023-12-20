using AutoMapper;
using DotnetBootcamp.Core.DTOs;
using DotnetBootcamp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Team, TeamDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserProfile, UserProfileDto>().ReverseMap();

            CreateMap<TeamDto, Team>();
        }
    }
}
