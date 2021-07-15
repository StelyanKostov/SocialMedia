using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Image;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SocialMedia.Services
{
    public class GalleryService : IGalleryService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper _mapper;
        private readonly IProfilService profilService;
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };

        public GalleryService(ApplicationDbContext db, IMapper mapper , IProfilService profilService)
        {
            this.db = db;
            this._mapper = mapper;
            this.profilService = profilService;
        }
        public void AddImgae(IEnumerable<IFormFile> ImagesVieModel, string imagePath, string userId ,string description)
        {
            var profil = this.profilService.getProfil(userId);

           

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
                    CreatedOn = DateTime.Now,
                    Description = description
                    
                };
                profil.Images.Add(dbImage);

                var physicalPath = $"{imagePath}/ProfilImage/{profil.UserName}/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                image.CopyTo(fileStream);

                this.db.SaveChanges();
            }
        }


        public void RealDeleteImage(int idProfil, string idImage)
        {
            var profil = this.db.Profils.Include(x => x.Images).Where(x => x.id == idProfil).FirstOrDefault();

            var image = profil.Images.Where(x => x.Id == idImage).FirstOrDefault();


            this.db.images.Remove(image);

            this.db.SaveChanges();
        }

        public void SetProfilImage(string idProfil, string idImage)
        {
            var profil = this.profilService.getProfil(idProfil);

            var image = profil.Images.Where(x => x.ProfilImage).FirstOrDefault();

            if (image != null)
            {
                image.ProfilImage = false;

            }

            var newProfilImage = profil.Images.Where(x => x.Id == idImage).FirstOrDefault();

            newProfilImage.ProfilImage = true;

            this.db.SaveChanges();

        }
       public List<ImageViewModel> GetAllImage()
        {
            var image = this.db.images.Include(x => x.Profil).Include(x=> x.Likes).Include(x=> x.Comments).ToList();

            var viewModel = this._mapper.Map<List<ImageViewModel>>(image);

            return viewModel;
        }
    }
}
