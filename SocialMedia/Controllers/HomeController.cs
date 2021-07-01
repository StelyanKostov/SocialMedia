using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialMedia.Data;
using SocialMedia.Models;
using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGalleryService galleryService;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(ILogger<HomeController> logger , IGalleryService galleryService, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this.galleryService = galleryService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var viewModel = this.galleryService.GetAllImage();

            

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
