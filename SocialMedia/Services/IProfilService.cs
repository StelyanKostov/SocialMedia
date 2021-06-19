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
        public ProfilViewModel getProfilById(string id);

        public void EditProfil(ProfilViewModel viewModel);



    }
}
