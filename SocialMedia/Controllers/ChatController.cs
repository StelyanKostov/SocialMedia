using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Services.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class ChatController :Controller
    {
        private readonly IChatRoomsService chatRoomsService;

        public ChatController(IChatRoomsService chatRoomsService)
        {
            this.chatRoomsService = chatRoomsService;
        }
        public IActionResult Index()
        {
            var mess = this.chatRoomsService.GetAllMessages();
            return this.View(mess);
        }
    }
}
