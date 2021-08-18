using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialMedia.Data;
using SocialMedia.Models;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using System.Diagnostics;

namespace SocialMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGalleryService galleryService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProfilService profilService;
        private readonly IRealTimeChatService realTimeChatService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public HomeController(ILogger<HomeController> logger ,
            IGalleryService galleryService,
            UserManager<ApplicationUser> userManager ,
            IProfilService profilService ,
            IRealTimeChatService realTimeChatService,
             SignInManager<ApplicationUser> signInManager)
        {
            _logger = logger;
            this.galleryService = galleryService;
            this._userManager = userManager;
            this.profilService = profilService;
            this.realTimeChatService = realTimeChatService;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            if (signInManager.IsSignedIn(this.User))
            {
                var id = this._userManager.GetUserId(this.User);
                var viewModelId = this.profilService.getProfilByUserId(id).id;
                this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(viewModelId);
            } 

            var viewModel = this.galleryService.GetAllImage();

            //todoo

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
