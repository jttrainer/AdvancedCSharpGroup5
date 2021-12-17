using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forever_Home_Finder.Models
{
    public class PetQueryOptions : QueryOptions<Pet>
    {
        public void SortFilter(PetsGridBuilder builder)
        {
            if (builder.IsFilterByPetType)
            {
                Where = b => b.PetType.PetTypeName == builder.CurrentRoute.PetTypeFilter;
            }
            

            if (builder.IsSortByPetType)
            {
                OrderBy = b => b.PetType.PetTypeName;
            }
            else
            {
                OrderBy = b => b.PetName;
            }
        }
    }
}
