using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Comments;
using SocialMedia.ViewModels.Image;
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

        public string AddComment(string ImgId, string content, int profilIdCommend)
        {
            var image = this.db.images.Where(x => x.Id == ImgId).FirstOrDefault();


            image.Comments.Add(new Comments()
            {
                Content = content,
                CreatedOn = DateTime.Now,
                ProfilIdCommented = profilIdCommend,
            });

            this.db.SaveChanges();

            return this.db.Profils.Where(x => x.id == profilIdCommend).FirstOrDefault().UserName;
        }

        public object GetCommentsImage(string ImgId)
        {
            var comments = this.db.images.Include(x => x.Comments).Include(x => x.Profil).Where(x => x.Id == ImgId).ToList();

            var viewModel = _mapper.Map<List<ImageViewModel>>(comments);


            var rezult = viewModel.Select(x => new
            {
                userNameCommend = x.Profil.UserName,
                comments = x.Comments.Select(y => new
                {
                    content = y.Content,
                    commentingId = y.ProfilIdCommented,
                    username = this.profilService.getProfilByProfilId(y.ProfilIdCommented).UserName

                }).ToList()

            }).ToList();

            return rezult;
        }

        public int LikeImage(string imdId,  string userlIdLiked)
        {
            var img = this.db.images.Include(x=> x.Likes).Where(x => x.Id == imdId).FirstOrDefault();

            var profilIdLikedImg = this.profilService.getProfilByUserId(userlIdLiked).id;

            if (img.Likes.Any(x=> x.ProfilIdLiked == profilIdLikedImg))
            {
                
            }
            else
            {
                img.Likes.Add(new Likes()
                {
                    ProfilIdLiked = profilIdLikedImg,
                    

                });

                this.db.SaveChanges();
            }

            return img.Likes.Count();
        }
    }
}
