using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Messages;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class ProfilService : IProfilService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper _mapper;
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };


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

        private Profils getProfil(string id)
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

        public void AddImgae(IEnumerable<IFormFile> ImagesVieModel, string imagePath, string userId)
        {
            var profil = this.getProfil(userId);

            Directory.CreateDirectory($"{imagePath}/ProfilImage/{profil.UserName}/");
            foreach (var image in ImagesVieModel)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');
                if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image extension {extension}");
                }

                var dbImage = new Image
                {
                    ProfilId = profil.id,
                    Extension = extension,
                };
                profil.Images.Add(dbImage);
               
                var physicalPath = $"{imagePath}/ProfilImage/{profil.UserName}/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                image.CopyTo(fileStream);

                this.db.SaveChanges();
            }
        }


        public void RealDeleteImage(int idProfil , string idImage)
        {
            var profil = this.db.Profils.Include(x => x.Images).Where(x => x.id == idProfil).FirstOrDefault();

            var image = profil.Images.Where(x => x.Id == idImage).FirstOrDefault();


            this.db.images.Remove(image);

           this.db.SaveChanges();
        }

        public void SetProfilImage(string idProfil, string idImage)
        {
            var profil = this.getProfil(idProfil);

            var image = profil.Images.Where(x => x.ProfilImage).FirstOrDefault();

            if (image != null)
            {
                image.ProfilImage = false;

            }

            var newProfilImage = profil.Images.Where(x => x.Id == idImage).FirstOrDefault();

            newProfilImage.ProfilImage = true;

            this.db.SaveChanges();

        }

        public List<ProfilViewModel> AllProfils()
        {
            var profils = this.db.Profils.Include(x => x.Images).ToList();

            var profilViewModel = _mapper.Map<List<ProfilViewModel>>(profils);

            return profilViewModel;
        }

        public ProfilViewModel getProfilByProfilId(int id)
        {
            var profil = this.db.Profils.Include(x=> x.Images).Where(x => x.id == id).FirstOrDefault();

            var profilViewModel = _mapper.Map<ProfilViewModel>(profil);

            return profilViewModel;

        }
     
    }
}
