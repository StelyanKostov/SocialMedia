using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using SocialMedia.ViewModels.Profil;
using System.Collections.Generic;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class ProfilController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IProfilService profilService;
        private readonly IWebHostEnvironment environment;
        private readonly IRealTimeChatService realTimeChatService;

        public ProfilController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IProfilService profilService,
            IWebHostEnvironment environment,
            IRealTimeChatService realTimeChatService
        )
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this.profilService = profilService;
            this.environment = environment;
            this.realTimeChatService = realTimeChatService;
        }
        public IActionResult Index()
        {

            var id = this._userManager.GetUserId(this.User);
            var viewModel = this.profilService.getProfilByUserId(id);

            this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(viewModel.id);

            var test = this.realTimeChatService.GetMessages(viewModel.id);
            return this.View(viewModel);
        }
        public IActionResult Edit(string id)
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
            var id = this._userManager.GetUserId(this.User);
            var viewModelId = this.profilService.getProfilByUserId(id).id;
            this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(viewModelId);

            var profils = this.profilService.AllProfils();
            return this.View(profils);
        }

        public IActionResult Search(string username)
        {
            var id = this._userManager.GetUserId(this.User);
            var viewModelId = this.profilService.getProfilByUserId(id).id;
            this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(viewModelId);

            var viewModel = this.profilService.SearchByUsername(username);
            return this.View("AllProfils", viewModel);
        }

        public IActionResult OpenProfil(int id)
        {
            var viewModelId = this.profilService.getProfilByUserId(this._userManager.GetUserId(this.User)).id;
            this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(viewModelId);

            var profil = this.profilService.getProfilByProfilId(id);
            return this.View(profil);
        }
    }

}
