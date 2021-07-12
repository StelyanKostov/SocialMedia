using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    public class RealTimeChatController : Controller
    {
        private readonly IRealTimeChatService realTimeChatService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProfilService profilService;

        public RealTimeChatController(IRealTimeChatService realTimeChatService , UserManager<ApplicationUser> userManager , IProfilService profilService)
        {
            this.realTimeChatService = realTimeChatService;
            this.userManager = userManager;
            this.profilService = profilService;
        }
        public IActionResult Index()
        {
            var id = this.userManager.GetUserId(this.User);
            var profilId = this.profilService.getProfilByUserId(id).id;

            var viewModel = realTimeChatService.GetMessages(profilId);
            return this.View(viewModel);
        }
    }
}
