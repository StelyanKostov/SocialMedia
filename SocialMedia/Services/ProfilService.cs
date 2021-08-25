using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Profil;
using System.Collections.Generic;
using System.Linq;

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

        //TODOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        public void EditProfil(ProfilViewModel viewModel)
        {
            var profil = getProfil(viewModel.ApplicationUserId);
            //var rezult = _mapper.Map(viewModel, profil);

            profil.Alcohol = viewModel.Alcohol;

            profil.Cigarettes = viewModel.Cigarettes;

            profil.Description = viewModel.Description;

            profil.EyesColor = viewModel.EyesColor;

            profil.From = viewModel.From;

            profil.HairColor = viewModel.HairColor;

            profil.Height = viewModel.Height;

            profil.Likes = viewModel.Likes;

            profil.LookingFor = viewModel.LookingFor;

            profil.Status = viewModel.Status;

            profil.Weight = viewModel.Weight;

            this.db.SaveChanges();
        }

        public Profils getProfil(string id)
        {
            var profile = this.db.Profils.Include(x=> x.Images).Where(x => x.ApplicationUserId == id).FirstOrDefault();
            return profile;
        }

        public ProfilViewModel getProfilByUserId(string id)
        {
            var profil = getProfil(id);                        
            var profilViewModel = _mapper.Map<ProfilViewModel>(profil);
            return profilViewModel;

        }

        

        public AllProfils AllProfils()
        {
            var profils = this.db.Profils.Include(x => x.Images).ToList();

            var profilViewModel = _mapper.Map<List<ProfilViewModel>>(profils);

            var viewModel = new AllProfils();

            viewModel.profils = profilViewModel;

            return viewModel;
        }

        public ProfilViewModel getProfilByProfilId(int id)
        {
            var profil = this.db.Profils.Include(x=> x.Images).Where(x => x.id == id).FirstOrDefault();

            var profilViewModel = _mapper.Map<ProfilViewModel>(profil);

            return profilViewModel;

        }

        public AllProfils SearchByUsername(string username)
        {
            var profils = this.db.Profils.Include(x => x.Images).Where(x => x.UserName.Contains(username)).ToList();

            var mapProfils = _mapper.Map<List<ProfilViewModel>>(profils);


            var viewModel = new AllProfils();

            viewModel.profils = mapProfils;

            return viewModel;
        }

        public void RealDeleteProfil(int profilId)
        {
            var data = this.db.Profils.Include(x => x.Images).Include(x => x.Messages).Include(x => x.RouteChat).Where(x=> x.id == profilId).FirstOrDefault();

            db.Profils.Remove(data);

            this.db.SaveChanges();
        }
    }
}
