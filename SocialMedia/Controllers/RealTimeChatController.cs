using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using SocialMedia.ViewModels.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class RealTimeChatController : Controller
    {
        private readonly IRealTimeChatService realTimeChatService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProfilService profilService;
        private readonly IHttpContextAccessor httpContextAccessor;

        public RealTimeChatController(IRealTimeChatService realTimeChatService ,
            UserManager<ApplicationUser> userManager ,
            IProfilService profilService,
             IHttpContextAccessor httpContextAccessor)
        {
            this.realTimeChatService = realTimeChatService;
            this.userManager = userManager;
            this.profilService = profilService;
            this.httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            var id = this.userManager.GetUserId(this.User);
            var profilId = this.profilService.getProfilByUserId(id).id;

            var viewModel = realTimeChatService.GetMessages(profilId);
            return this.View(viewModel);
        }

        
        public IActionResult SeenMessages([FromQuery]int id2)
        {
            var id = this.userManager.GetUserId(this.User);
            var profilId = this.profilService.getProfilByUserId(id).id;

            this.realTimeChatService.SeenMessages(profilId, id2);
            return this.Json(new { });
        }

    }

   
}
