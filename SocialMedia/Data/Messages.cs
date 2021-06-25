using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Messages
    {
        public int id { get; set; }

        public bool Seen { get; set; }

        public string Content { get; set; }

        public DateTime CreateOn { get; set; }

        public int ProfilId { get; set; }
        public virtual Profils Profil { get; set; }

        public int SecondProfilId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
