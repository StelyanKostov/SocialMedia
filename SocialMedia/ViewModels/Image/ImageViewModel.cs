using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Image
{
    public class ImageViewModel
    {
        public string Id { get; set; }
        public virtual Profils Profil { get; set; }

        public string Extension { get; set; }


        public bool ProfilImage { get; set; }
        public string RemoteImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Description { get; set; }
    }
}
