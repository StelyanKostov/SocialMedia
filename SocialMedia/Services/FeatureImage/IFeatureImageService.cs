using SocialMedia.ViewModels.Comments;
using SocialMedia.ViewModels.Image;
using System.Collections.Generic;

namespace SocialMedia.Services.FeatureImage
{
    public interface IFeatureImageService
    {
   
        public void AddComment(string id , string content, int ProfilIdCommented);

        public object GetCommentsImage(string ImgId);

        public int LikeImage(string imdId, int profilIdLikedImg);
    }
}
