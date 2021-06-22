using SocialMedia.Data;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Messages
{
    public class MessagesViewModel
    {
        //public int id { get; set; }

        public bool Seen { get; set; }

        public string Content { get; set; }

        public DateTime CreateOn { get; set; }

        public ProfilViewModel Profil { get; set; }
        public int ProfilId { get; set; }

        public int SecondProfilId { get; set; }
    }
}
