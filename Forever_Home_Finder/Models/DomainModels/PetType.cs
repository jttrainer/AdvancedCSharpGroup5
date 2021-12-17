using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Forever_Home_Finder.Models
{
    public class PetType
    {
        public int PetTypeId { get; set; }

        public string PetTypeName { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
