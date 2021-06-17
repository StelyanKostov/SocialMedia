using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class ApplicationUser : IdentityUser
    {
       

        public ApplicationUser()
        {
            this.Id = this.Id = Guid.NewGuid().ToString();

        }
        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int ProfilId { get; set; }
        public Profils Profil { get; set; }


    }
}
