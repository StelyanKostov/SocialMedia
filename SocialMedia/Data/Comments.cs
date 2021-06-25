using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Comments
    {
        public int id { get; set; }

        public string ImageId { get; set; }

        public virtual Image Image { get; set; }

        public string Content { get; set; }

        public int ProfilIdCommented { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
