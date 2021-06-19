using AutoMapper;
using SocialMedia.Data;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class ProfilService : IProfilService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper _mapper;

        public ProfilService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this._mapper = mapper;
        }

        public void EditProfil(ProfilViewModel viewModel)
        {
            var profil = getProfil(viewModel.ApplicationUserId);
            var rezult = _mapper.Map(viewModel, profil);

            this.db.SaveChanges();
        }

        private Profils getProfil(string id)
        {
            var profile = this.db.Profils.Where(x => x.ApplicationUserId == id).FirstOrDefault();
            return profile;
        }

        public ProfilViewModel getProfilById(string id)
        {
            var profil = getProfil(id);

            var profilViewModel = _mapper.Map<ProfilViewModel>(profil);


            return profilViewModel;

        }
    }
}
