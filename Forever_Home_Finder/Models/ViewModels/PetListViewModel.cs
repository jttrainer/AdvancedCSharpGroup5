using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forever_Home_Finder.Models
{
    public class PetListViewModel
    {
        public IEnumerable<Pet> Pets { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }

        public IEnumerable<PetType> PetType { get; set; }
    }
}
