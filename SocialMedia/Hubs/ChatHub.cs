using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Models.Chat;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
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
        private readonly IRealTimeChatService realTimeChatService;

        public ChatHub(
            IProfilService profilService,
            UserManager<ApplicationUser> userManager,
            IChatRoomsService chatRoomsService ,
            IRealTimeChatService realTimeChatService
            )
        {
            this.profilService = profilService;
            this.userManager = userManager;
            this.chatRoomsService = chatRoomsService;
            this.realTimeChatService = realTimeChatService;
        }

        public async Task Send(string message)
        {
            //var result = this.Clients.Groups("dasdas").SendAsync("dasdas" , new object());

            var userId = this.userManager.GetUserAsync(this.Context.User).Result.Id;
            var profil = this.profilService.getProfilByUserId(userId);
            await this.Clients.All.SendAsync(
                "NewMessage",
                new Message { User = profil.UserName, Text = message, ProfilId = profil.id});

            this.chatRoomsService.AddMessages(profil.id, message);


            //this.Context.User.Identity.Name
        }
        public async Task SendToOneProfil(string data)
        {
            /*string recipientProfilId*/
            var array = data.Split("<>=!").ToArray();

            var message = array[0];
            var userId = this.userManager.GetUserAsync(this.Context.User).Result.Id;
            var profil = this.profilService.getProfilByUserId(userId);

           

            //await this.Clients.Caller.SendAsync("NewMessage",
            //  new Message { User = profil.UserName, Text = message, });

            var recipientProfilId = array[1];

            this.realTimeChatService.AddMessages(message, profil.id, int.Parse(recipientProfilId));

            var recepient = this.profilService.getProfilByProfilId(int.Parse(recipientProfilId)).ApplicationUserId;
            

            await  this.Clients.User(recepient).SendAsync("NewMessage",
              new Message { User = profil.UserName, Text = message, });
        }


    }
}
