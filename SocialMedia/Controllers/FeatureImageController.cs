using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Services.FeatureImage;
using System;

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
              var rezultUsername = this.featureImageService.AddComment(data[0], data[1], data[2]);

                return this.Json(new { username = rezultUsername,content = data[1] });


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

            var count =   this.featureImageService.LikeImage(data[0], data[1]);

            return this.Json(new {count = count });

           
        }
       
    }
}