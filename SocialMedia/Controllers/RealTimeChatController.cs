using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;

namespace SocialMedia.Controllers
{
    [Authorize]
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

        
        public IActionResult SeenMessages([FromQuery]int id2)
        {
            var id = this.userManager.GetUserId(this.User);
            var profilId = this.profilService.getProfilByUserId(id).id;

            this.realTimeChatService.SeenMessages(profilId, id2);
            return this.Json(new { });
        }
    }

   
}
