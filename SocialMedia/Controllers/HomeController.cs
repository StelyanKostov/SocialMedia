using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialMedia.Data;
using SocialMedia.Models;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;

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

        public HomeController(ILogger<HomeController> logger,
            IGalleryService galleryService,
            UserManager<ApplicationUser> userManager,
            IProfilService profilService,
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
                var profil = this.profilService.getProfilByUserId(id);
                this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(profil.id);

                var pathToProfilImg = this.galleryService.GetProfilImgPath(profil.id);
                this.HttpContext.Session.SetString("Avatar", pathToProfilImg);
                this.HttpContext.Session.SetString("Username", profil.UserName);

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
