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
    public class UserProfileSeed : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasData(
                new UserProfile { Id = 1, FirstName = "Özlem", LastName = "Atay", NickName = "ozl", UserId = 1 },
                new UserProfile { Id = 2, FirstName = "Ayşe", LastName = "Kurt", NickName = "ayse", UserId = 2 },
                new UserProfile { Id = 3, FirstName = "Ali", LastName = "Akçay", NickName = "alis", UserId = 3 },
                new UserProfile { Id = 4, FirstName = "Ece", LastName = "Naz", NickName = "ece", UserId = 4 }
                );
        }
    }
}
