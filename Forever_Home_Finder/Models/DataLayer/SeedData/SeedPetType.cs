using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forever_Home_Finder.Models
{
    internal class SeedPetType : IEntityTypeConfiguration<PetType>
    {
        public void Configure(EntityTypeBuilder<PetType> entity)
        {
            entity.HasData(
                new PetType { PetTypeId = 1, PetTypeName = "Dog" },
                new PetType { PetTypeId = 2, PetTypeName = "Cat" },
                new PetType { PetTypeId = 3, PetTypeName = "Horse" },
                new PetType { PetTypeId = 4, PetTypeName = "Reptile" },
                new PetType { PetTypeId = 5, PetTypeName = "Amphibian" },
                new PetType { PetTypeId = 6, PetTypeName = "Arachnid" },
                new PetType { PetTypeId = 7, PetTypeName = "Other" }
            );
        }
    }
}
