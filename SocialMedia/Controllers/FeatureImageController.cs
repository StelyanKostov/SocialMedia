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
        public IActionResult AddComment([FromBody]string[] data)
        {
            this.featureImageService.AddComment(data[0], data[1], int.Parse(data[2]));

            return this.Json(new {});
        }

        
        public JsonResult GetComments([FromQuery]string ImgId)
        {
            var viewModel = this.featureImageService.GetCommentsImage(ImgId);

            

            return this.Json(viewModel);
            //return this.Json(new[] {
            //    new { Name = "Niki2", Date = DateTime.UtcNow.ToString("O") },
            //    new { Name = "Stoyan2", Date = DateTime.UtcNow.AddDays(1).ToString("O") },
            //    new { Name = "Pesho2", Date = DateTime.UtcNow.AddDays(2).ToString("O") },
            //});
        }
    }
}