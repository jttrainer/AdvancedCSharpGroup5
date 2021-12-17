using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Forever_Home_Finder.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        public string PetName { get; set; }

        public int PetTypeId { get; set; }

        public PetType PetType { get; set; }

        public int PetAge { get; set; }

        public string PetSex { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
