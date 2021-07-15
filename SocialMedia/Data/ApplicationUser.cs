using Microsoft.AspNetCore.Identity;
using System;

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

       
        public Profils Profil { get; set; }


    }
}
