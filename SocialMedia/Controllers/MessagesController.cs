using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using SocialMedia.ViewModels.Messages;
using System;

namespace SocialMedia.Controllers
{
    public class MessagesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMessagesService messagesService;
        private readonly IProfilService profilService;
        private readonly IRealTimeChatService realTimeChatService;

        public MessagesController(UserManager<ApplicationUser> userManager, 
            IMessagesService messagesService , 
            IProfilService profilService ,
            IRealTimeChatService realTimeChatService)
        {
            this._userManager = userManager;
            this.messagesService = messagesService;
            this.profilService = profilService;
            this.realTimeChatService = realTimeChatService;
        }

        public IActionResult Index()
        {
            var user = this._userManager.GetUserId(this.User);
            var mess = this.messagesService.GetMessagesByProfilId(this.profilService.getProfilByUserId(user).id);

            var id = this._userManager.GetUserId(this.User);
            var viewModelId = this.profilService.getProfilByUserId(id).id;
            this.ViewData["RealTimeChatViewModel"] = this.realTimeChatService.GetMessages(viewModelId);

            return View(mess);
        }

        public IActionResult SendMessages(int id)
        {
            var viewModel = new MessagesViewModel();

            var user = this._userManager.GetUserId(this.User);
            viewModel.ProfilId = this.profilService.getProfilByUserId(user).id;
            viewModel.SecondProfilId = id;

            return this.View(viewModel);

        }
        [HttpPost]
        public IActionResult SendMessages(MessagesViewModel viewModel)
        {

            this.messagesService.sentMessages(viewModel);

            Console.WriteLine();
            return this.RedirectToAction("OpenProfil" ,"Profil", new {id= viewModel.SecondProfilId });

        }

        public IActionResult OpenMessages(int id)
        {
            var user = this._userManager.GetUserId(this.User);

           var viewProfil = this.messagesService.GetMessagesByOneProfil(this.profilService.getProfilByUserId(user).id, id);

            return this.View(viewProfil);
        }

        public IActionResult Test()
        {
            

            return this.View();
        }
    }
}
