using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class ChatController :Controller
    {
        private readonly IChatRoomsService chatRoomsService;
        private readonly IMessagesService messagesService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProfilService profilService;
        private readonly IRealTimeChatService realTimeChatService;

        public ChatController(IChatRoomsService chatRoomsService ,
            IMessagesService messagesService,
            UserManager<ApplicationUser> userManager,
            IProfilService profilService ,
            IRealTimeChatService realTimeChatService)
        {
            this.chatRoomsService = chatRoomsService;
            this.messagesService = messagesService;
            this._userManager = userManager;
            this.profilService = profilService;
            this.realTimeChatService = realTimeChatService;
        }
        public IActionResult Index()
        {
            var id = this._userManager.GetUserId(this.User);
            var viewModelId = this.profilService.getProfilByUserId(id).id;
            this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(viewModelId);

            var mess = this.chatRoomsService.GetAllMessages();
            return this.View(mess);
        }

        
       
    }
}
