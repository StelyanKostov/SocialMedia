using SocialMedia.Data;
using SocialMedia.ViewModels.Profil;

namespace SocialMedia.Services
{
    public interface IProfilService
    {
        public ProfilViewModel getProfilByUserId(string id);

        public void EditProfil(ProfilViewModel viewModel);

        public Profils getProfil(string id);

        public AllProfils AllProfils();

        public ProfilViewModel getProfilByProfilId(int id);


        public AllProfils SearchByUsername(string username);

        public void RealDeleteProfil(int profilId);
    }
}
