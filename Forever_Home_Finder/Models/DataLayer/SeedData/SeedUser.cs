using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forever_Home_Finder.Models
{
    internal class SeedUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasData(
                new User { UserId = 1, Username = "TheBeast", UserFirstName = "Jason", UserLastName = "Adams", UserEmail = "thebeast@gmail.com", UserPhone = "314-224-2235"}
            );
        }
    }
}
