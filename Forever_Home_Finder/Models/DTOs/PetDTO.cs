using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forever_Home_Finder.Models.DTOs
{
    public class PetDTO
    {
        public int PetId { get; set; }

        public string PetName { get; set; }

        public Dictionary<int, string> PetType { get; set; }

        public int PetAge { get; set; }

        public string PetSex { get; set; }

        public Dictionary<int, string> User { get; set; }

    }
}
