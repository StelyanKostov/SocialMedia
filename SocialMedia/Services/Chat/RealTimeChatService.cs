using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services.Chat
{
    public class RealTimeChatService : IRealTimeChatService
    {
        private readonly ApplicationDbContext db;
        private readonly IProfilService profilService;
        private readonly IMapper mapper;

        public RealTimeChatService(ApplicationDbContext db, IProfilService profilService, IMapper mapper)
        {
            this.db = db;
            this.profilService = profilService;
            this.mapper = mapper;
        }
        public void AddMessages(string content, int sendProfilId, int recipientProfilId)
        {
            var newMessages = new RealTimeChat()
            {
                Content = content,
                CreateOn = DateTime.Now,
                New = true,

            };
            var route = this.db.RouteChat
                .Where(x => x.CreatorId == sendProfilId || x.SecondProflId == sendProfilId)
                .Where(x => x.CreatorId == recipientProfilId || x.SecondProflId == recipientProfilId).FirstOrDefault();
            if (route == null)
            {
                var newRoute = new RouteChat();
                newRoute.CreatorId = sendProfilId;
                newRoute.SecondProflId = recipientProfilId;
                newRoute.realTimeChats.Add(newMessages);
                this.db.RealTimeChat.Add(newMessages);
                this.db.SaveChanges();
            }
            else
            {
                route.realTimeChats.Add(newMessages);
                this.db.RouteChat.Add(route);
                this.db.SaveChanges();

            }

        }

        public List<RealTimeChatViewModel> GetMessages(int profilId)
        {
            var route = this.db.RouteChat.Include(x=> x.realTimeChats)
              .Where(x => x.CreatorId == profilId || x.SecondProflId == profilId)
             .ToList();

            var viewModel = new List<RealTimeChatViewModel>();

            foreach (var item in route)
            {
                var helperViewModel = new RealTimeChatViewModel();
                if (profilId != item.CreatorId)
                {
                    helperViewModel.WithProfilId = item.CreatorId;
                    helperViewModel.WithProfilUserName = this.profilService.getProfilByProfilId(item.CreatorId).UserName;
                }
                else if (profilId != item.SecondProflId)
                {
                    helperViewModel.WithProfilId = item.CreatorId;
                    helperViewModel.WithProfilUserName = this.profilService.getProfilByProfilId(item.SecondProflId).UserName;

                }
                helperViewModel.Messages = this.mapper.Map<List<RealTimeMessagesViewModel>>(item.realTimeChats);

                viewModel.Add(helperViewModel);
            }

            return viewModel;
        }
    }
}
