using Microsoft.AspNetCore.Mvc;
using SocialMedia.Services.FeatureImage;
using SocialMedia.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}