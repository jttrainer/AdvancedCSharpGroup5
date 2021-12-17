using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forever_Home_Finder.Models
{
    public class SeedPet : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> entity)
        {
            entity.HasData(
                new Pet { PetId = 1, PetName = "Fluffy", PetTypeId = 1, PetAge = 1, PetSex = "Female", UserId = 1}
            );
        }
    }
}
