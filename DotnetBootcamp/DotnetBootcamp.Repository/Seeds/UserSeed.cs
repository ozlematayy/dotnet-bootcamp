using DotnetBootcamp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, UserName = "ozlem", Email = "ozlematay@gmail.com", Password = "123456", TeamId = 1, CreatedDate = DateTime.Now },
                new User { Id = 2, UserName = "aysekurt", Email = "aysekurt@gmail.com", Password = "122312", TeamId = 2, CreatedDate = DateTime.Now },
                new User { Id = 3, UserName = "ali", Email = "aliakçay@gmail.com", Password = "423785482",  TeamId = 3, CreatedDate = DateTime.Now },
                new User { Id = 4, UserName = "ecenaz", Email = "ecenaz@gmail.com", Password = "35374125", TeamId = 4, CreatedDate = DateTime.Now }
                );
        }
    }
}
