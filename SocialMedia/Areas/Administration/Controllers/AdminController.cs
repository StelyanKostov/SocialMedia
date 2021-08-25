using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IGalleryService galleryService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProfilService profilService;

        public AdminController(IGalleryService galleryService,
            UserManager<ApplicationUser> userManager,
            IProfilService profilService)
        {
            this.galleryService = galleryService;
            this.userManager = userManager;
            this.profilService = profilService;
        }
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult AllImg()
        {
            var data = this.galleryService.GetAllImage();
            return this.View(data);
        }

        public IActionResult DeleteImg(string imgId)
        {
            this.galleryService.RealDeleteImage(imgId);

            return this.RedirectToAction("AllImg");
        }

        public async Task<ActionResult> RealDeleteProfil(int profilId)
        {
            var profil = this.profilService.getProfilByProfilId(profilId);

            var user = await userManager.FindByIdAsync(profil.ApplicationUserId);

            await this.userManager.DeleteAsync(user);

            this.profilService.RealDeleteProfil(profilId);

            return this.Redirect("/");
        }
    }
}
