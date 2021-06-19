using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    public class ProfilController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IProfilService profilService;
        private readonly IWebHostEnvironment environment;

        //private readonly RoleManager<IdentityRole> roleManager;

        public ProfilController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IProfilService profilService,
            IWebHostEnvironment environment
          /*  RoleManager<IdentityRole> roleManager*/)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this.profilService = profilService;
            this.environment = environment;
            //this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var id = this._userManager.GetUserId(this.User);
            var viewModel = this.profilService.getProfilById(id);
            return this.View(viewModel);
        }

        public IActionResult Edit(string id)
        {
            var viewModel = this.profilService.getProfilById(id);

            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProfilViewModel viewModel)
        {
            var user = this._userManager.GetUserAsync(this.User);

            viewModel.ApplicationUser = user.Result;
            this.profilService.EditProfil(viewModel);
            return this.RedirectToAction("Index");
        }

        public IActionResult Gallery()
        {
            return this.View();
        }

        [HttpPost]
         public IActionResult Gallery(ProfilViewModel viewModel)
        {
            var userId = this._userManager.GetUserId(this.User);
            var path = $"{this.environment.WebRootPath}/images";
          
            try
            {
                this.profilService.AddImgae(viewModel.ImagesVieModel, path, userId);
            }
            catch (Exception ex)
            {

                return this.Content(ex.Message);

            }
            return this.Content(path);
        }
    }
}
