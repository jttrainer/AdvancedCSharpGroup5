using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forever_Home_Finder.Models
{
    public class User : IdentityUser
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        [NotMapped]
        public IList<string> RoleNames { get; set; }
        
        public string UserEmail { get; set; }

        public string UserPhone { get; set; }
    }
}
