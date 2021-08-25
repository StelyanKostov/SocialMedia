using Microsoft.AspNetCore.Http;
using SocialMedia.ViewModels.Image;
using System.Collections.Generic;

namespace SocialMedia.Services
{
    public interface IGalleryService
    {
        public void AddImgae(IEnumerable<IFormFile> ImagesVieModel, string imagePath, string userId,string description);

        public void RealDeleteImage(string idImage);
        public void SetProfilImage(string idProfil, string idImage);

        public List<ImageViewModel> GetAllImage();
    }
}
