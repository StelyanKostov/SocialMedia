using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Models.Chat;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Hubs
{

    [Authorize]
    public class ChatHub : Hub
    {
        private readonly IProfilService profilService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IChatRoomsService chatRoomsService;

        public ChatHub(IProfilService profilService, UserManager<ApplicationUser> userManager, IChatRoomsService chatRoomsService)
        {
            this.profilService = profilService;
            this.userManager = userManager;
            this.chatRoomsService = chatRoomsService;
        }

        public async Task Send(string message)
        {
            var result = this.Clients.Groups("dasdas").SendAsync("dasdas" , new object());

            
            var userId = this.userManager.GetUserAsync(this.Context.User).Result.Id;
            var profil = this.profilService.getProfilByUserId(userId);
            await this.Clients.All.SendAsync(
                "NewMessage",
                new Message { User = profil.UserName, Text = message, });

            this.chatRoomsService.AddMessages(profil.id, message);

            //this.Context.User.Identity.Name
        }

    }
}
