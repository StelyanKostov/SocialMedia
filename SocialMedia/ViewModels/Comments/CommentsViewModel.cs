using SocialMedia.ViewModels.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Comments
{
    public class CommentsViewModel
    {

        public string ImageId { get; set; }

        public ImageViewModel Image { get; set; }

        public string Content { get; set; }

        public int ProfilIdCommented { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
