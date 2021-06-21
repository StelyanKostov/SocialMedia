using Microsoft.AspNetCore.Http;
using SocialMedia.Data;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public interface IProfilService
    {
        public ProfilViewModel getProfilByUserId(string id);

        public void EditProfil(ProfilViewModel viewModel);

        public void AddImgae(IEnumerable<IFormFile> ImagesVieModel, string imagePath, string userId);

        public void RealDeleteImage(int idProfil, string idImage);
        public void SetProfilImage(string idProfil, string idImage);

        public List<ProfilViewModel> AllProfils();

        public ProfilViewModel getProfilByProfilId(int id);



    }
}
