using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.FeatureImage;
using SocialMedia.ViewModels.Comments;
using SocialMedia.ViewModels.Likes;
using System;

namespace SocialMedia.Controllers
{
    public class FeatureImageController : Controller
    {
        private readonly IFeatureImageService featureImageService;
        private readonly IProfilService profilService;
        private readonly UserManager<ApplicationUser> userManager;

        public FeatureImageController(IFeatureImageService featureImageService,
             IProfilService profilService,
              UserManager<ApplicationUser> userManager)
        {
            this.featureImageService = featureImageService;
            this.profilService = profilService;
            this.userManager = userManager;
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddComment([FromBody]CommentsViewModel viewModel)
        {

            var commeendProfilId = this.profilService.getProfilByUserId(this.userManager.GetUserId(this.User)).id;
            try
            {
              var rezultUsername = this.featureImageService.AddComment(viewModel.ImageId, viewModel.Content, commeendProfilId);

                return this.Json(new { username = rezultUsername,content = viewModel.Content });


            }
            catch (Exception)
            {
                return this.Json(new { });

                throw;
            }

        }

        [Authorize]
        public JsonResult GetComments([FromQuery]string ImgId)
        {
            var viewModel = this.featureImageService.GetCommentsImage(ImgId);

            return this.Json(viewModel);
            
        }

        [Authorize]
        [HttpPost]
        public IActionResult LikeImage([FromBody]string imgId)
        {

            var userId = this.userManager.GetUserId(this.User);

            var count =   this.featureImageService.LikeImage(imgId, userId);

            return this.Json(new {count = count });

           
        }
       
    }
}