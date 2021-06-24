using Microsoft.AspNetCore.Http;
using SocialMedia.ViewModels.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public interface IGalleryService
    {
        public void AddImgae(IEnumerable<IFormFile> ImagesVieModel, string imagePath, string userId,string description);

        public void RealDeleteImage(int idProfil, string idImage);
        public void SetProfilImage(string idProfil, string idImage);

        public List<ImageViewModel> GetAllImage();
    }
}
