using DotnetBootcamp.Core.Models;
using DotnetBootcamp.Core.Repositories;
using DotnetBootcamp.Core.Services;
using DotnetBootcamp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Service.Services
{
    public class UserProfileService : Service<UserProfile>, IUserProfileService
    {
        public UserProfileService(IGenericRepository<UserProfile> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
