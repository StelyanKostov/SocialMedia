using SocialMedia.ViewModels.Comments;
using SocialMedia.ViewModels.Image;
using System.Collections.Generic;

namespace SocialMedia.Services.FeatureImage
{
    public interface IFeatureImageService
    {
   
        public string AddComment(string id , string content, string userlIdCommented);

        public object GetCommentsImage(string ImgId);

        public int LikeImage(string imdId,string userlIdLiked);
    }
}
