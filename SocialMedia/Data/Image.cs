using System;
using System.Collections.Generic;

namespace SocialMedia.Data
{
    public class Image
    {
        public Image()
        {
            this.Comments = new HashSet<Comments>();
            this.Likes = new HashSet<Likes>();

            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }


        public int ProfilId { get; set; }
        public virtual Profils Profil { get; set; }

        public string Extension { get; set; }

        //// The contents of the image is in the file system

        public bool ProfilImage { get; set; }
        public string RemoteImageUrl { get; set; }
        public DateTime CreatedOn { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Comments> Comments { get; set; }

        public ICollection<Likes> Likes { get; set; }


    }
}
