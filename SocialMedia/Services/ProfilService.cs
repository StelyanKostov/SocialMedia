using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class ProfilService : IProfilService
    {
        private readonly ApplicationDbContext db;

        public ProfilService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public Profils getUserById(string id)
        {
            Profils user = this.db.Profils.Where(x => x.ApplicationUserId == id).FirstOrDefault();

         
            return user;
            
        }
    }
}
