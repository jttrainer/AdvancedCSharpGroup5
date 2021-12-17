using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Forever_Home_Finder.Models
{
    internal class SeedAddInfo : IEntityTypeConfiguration<AddInfo>
    {
        public void Configure(EntityTypeBuilder<AddInfo> entity)
        {
            entity.HasData(
                new AddInfo { AddInfoId = 1, AddInfoDescription = "Beautiful dog needs loving home", PetId = 1 }
            );
        }
    }
}
