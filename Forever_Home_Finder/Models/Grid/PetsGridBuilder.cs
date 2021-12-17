using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Forever_Home_Finder.Models
{
    public class PetsGridBuilder : GridBuilder
    {
        public PetsGridBuilder(ISession sess) : base(sess) { }

        public PetsGridBuilder(ISession sess, PetsGridDTO values,
            string defaultSortField) : base(sess, values, defaultSortField)
        {
            bool isInitial = values.PetType.IndexOf(FilterPrefix.PetType) == -1;
            routes.PetTypeFilter = (isInitial) ? FilterPrefix.PetType + values.PetType : values.PetType;
        }

        public void LoadFilterSegments(string[] filter, PetType petType)
        {
            if(petType == null) {
                routes.PetTypeFilter = FilterPrefix.PetType + filter[0];
            } else
            {
                routes.PetTypeFilter = FilterPrefix.PetType + filter[0]
                    + "-" + petType.PetTypeName.Slug();
            }
        }

        public void ClearFilterSegments() => routes.ClearFilters();

        string def = PetsGridDTO.DefaultFilter;
        public bool IsFilterByPetType => routes.PetTypeFilter != def;

        public bool IsSortByPetType =>
            routes.SortField.EqualsNoCase(nameof(PetType));
    }
}
