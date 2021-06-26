using AutoMapper;
using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services.FeatureImage
{
    public class FeatureImageService : IFeatureImageService
    {
        private ApplicationDbContext db;
        private IMapper _mapper;
        private IProfilService profilService;

        public FeatureImageService(ApplicationDbContext db, IMapper mapper, IProfilService profilService)
        {
            this.db = db;
            this._mapper = mapper;
            this.profilService = profilService;
        }

        public void AddComment(string ImgId , string content ,int ProfilIdCommented)
        {
            var image = this.db.images.Where(x => x.Id == ImgId).FirstOrDefault();

            image.Comments.Add(new Comments()
            {
                Content = content,
                CreatedOn = DateTime.Now,
                ProfilIdCommented = ProfilIdCommented,               
            });

            this.db.SaveChanges();
            
        }
    }
}
