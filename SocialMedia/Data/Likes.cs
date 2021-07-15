
namespace SocialMedia.Data
{
    public class Likes
    {
        public int id { get; set; }

        public string ImageId { get; set; }

        public virtual Image Image { get; set; }


        public int ProfilIdLiked { get; set; }

    }
}
