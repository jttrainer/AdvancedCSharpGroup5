using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Forever_Home_Finder.Models
{
    public class AddInfo
    {
        public int AddInfoId { get; set; }

        public string AddInfoDescription { get; set; }

        public int PetId { get; set; }

        public Pet Pet { get; set; }
    }
}
