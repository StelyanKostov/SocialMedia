using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.ViewModels.Profil;
using System;

namespace SocialMedia.Controllers
{
    public class GalleryController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IGalleryService galleryService;
        private readonly IWebHostEnvironment environment;
        private readonly IProfilService profilService;

        public GalleryController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IGalleryService galleryService,
            IWebHostEnvironment environment,
            IProfilService profilService
          )
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this.galleryService = galleryService;
            this.environment = environment;
            this.profilService = profilService;
        }
        public IActionResult Index(int id)
        {

            var viewModel = this.profilService.getProfilByProfilId(id);
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(ProfilViewModel viewModel)
        {
            var userId = this._userManager.GetUserId(this.User);
            var path = $"{this.environment.WebRootPath}/images";

            try
            {
                this.galleryService.AddImgae(viewModel.ImagesVieModel, path, userId , viewModel.Description);
            }
            catch (Exception ex)
            {

                return this.Content(ex.Message);

            }
            return this.RedirectToAction("Index", new { id = viewModel.id });
        }

        public IActionResult RealDeleteImage(int idProfil, string idImage)
        {
            this.galleryService.RealDeleteImage(idImage);

            return this.RedirectToAction("Index", new { id = idProfil });
        }

        public IActionResult SetProfilImage(string idProfil, string idImage)
        {
            this.galleryService.SetProfilImage(idProfil, idImage);
            return this.Redirect("/Profil/index");
        }
    }
}
