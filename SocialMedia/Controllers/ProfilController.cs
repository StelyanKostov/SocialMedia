using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
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

        //private readonly RoleManager<IdentityRole> roleManager;

        public ProfilController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IProfilService profilService
          /*  RoleManager<IdentityRole> roleManager*/)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this.profilService = profilService;
            //this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var id = _userManager.GetUserId(this.User);
            var userProfil = profilService.getUserById(id);
            return View(userProfil);
        }
    }
}
