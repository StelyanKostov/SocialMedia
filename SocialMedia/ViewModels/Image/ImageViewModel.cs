using SocialMedia.Data;
using SocialMedia.ViewModels.Comments;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Image
{
    public class ImageViewModel
    {
        public string Id { get; set; }
        public virtual ProfilViewModel Profil { get; set; }

        public string Extension { get; set; }


        public bool ProfilImage { get; set; }
        public string RemoteImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Description { get; set; }

        public IEnumerable<CommentsViewModel> Comments { get; set; }
    }
}
