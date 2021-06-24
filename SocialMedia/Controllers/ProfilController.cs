using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
            var viewModel = this.profilService.getProfilByUserId(id);
            return this.View(viewModel);
        }
        public IActionResult Edit(string id )
        {
            var viewModel = this.profilService.getProfilByUserId(id);

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

  

        //todooooo
        public IActionResult AllProfils()
        {
            var profils = this.profilService.AllProfils();

            var viewModel = new AllProfils();

            viewModel.profils = profils;
            return this.View(viewModel);
        }

       public IActionResult OpenProfil(int id)
        {
            var profil = this.profilService.getProfilByProfilId(id);
            return this.View(profil);
        }
    }
}
