using DotnetBootcamp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Repository.Configurations
{
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x=>x.FirstName).IsRequired().HasMaxLength(250);
            builder.Property(x=>x.LastName).IsRequired().HasMaxLength(250);
            builder.Property(x=>x.NickName).IsRequired().HasMaxLength(100);
        }
    }
}
