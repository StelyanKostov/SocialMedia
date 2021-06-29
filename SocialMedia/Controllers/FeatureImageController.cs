using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SocialMedia.Services.FeatureImage;
using SocialMedia.ViewModels.Comments;
using SocialMedia.ViewModels.Image;
using SocialMedia.ViewModels.Messages;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    public class FeatureImageController : Controller
    {
        private readonly IFeatureImageService featureImageService;

        public FeatureImageController(IFeatureImageService featureImageService)
        {
            this.featureImageService = featureImageService;
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddComment([FromBody]string[] data)
        {

            try
            {
              var rezultUsername = this.featureImageService.AddComment(data[0], data[1], int.Parse(data[2]));

                return this.Json(new { commentingId = data[2], username = rezultUsername,content = data[1] });


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
        public IActionResult LikeImage([FromBody]string[] data)
        {

            var count =   this.featureImageService.LikeImage(data[0], int.Parse(data[1]));

            return this.Json(new {count = count });

           
        }
       
    }
}