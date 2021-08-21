using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Chat;
using System;
using System.Collections.Generic;
using System.Linq;

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
                Sender = profilService.getProfilByProfilId(sendProfilId).UserName,
                CreateOn = DateTime.Now,
                New = true,
                SenderId = sendProfilId

            };
            var route = this.db.RouteChat
                .Include(x => x.realTimeChats)
                .Where(x => x.CreatorId == sendProfilId || x.SecondProflId == sendProfilId)
                .Where(x => x.CreatorId == recipientProfilId || x.SecondProflId == recipientProfilId).FirstOrDefault();

            if (route != null)
            {
                route.IsDeleted = false;

            }
            if (route == null)
            {
                var newRoute = new RouteChat();
                newRoute.CreatorId = sendProfilId;
                newRoute.SecondProflId = recipientProfilId;
                newRoute.realTimeChats.Add(newMessages);
                this.db.RouteChat.Add(newRoute);
                this.db.SaveChanges();
            }
            else
            {
                newMessages.RouteChatId = route.Id;
                this.db.RealTimeChat.Add(newMessages);
                this.db.SaveChanges();

            }

        }

        public void DeletedRealTimeChat(string RouteChatId)
        {
            var routeChat = this.db.RouteChat.FirstOrDefault(x => x.Id == RouteChatId);

            routeChat.IsDeleted = true;

            db.SaveChanges();
        }

        public List<RealTimeChatViewModel> GetMessages(int profilId)
        {
            var route = this.db.RouteChat.Include(x => x.realTimeChats)
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
                    helperViewModel.Id = item.Id;
                    helperViewModel.IsDeleted = item.IsDeleted;

                }
                else if (profilId != item.SecondProflId)
                {
                    helperViewModel.WithProfilId = item.SecondProflId;
                    helperViewModel.WithProfilUserName = this.profilService.getProfilByProfilId(item.SecondProflId).UserName;
                    helperViewModel.Id = item.Id;
                    helperViewModel.IsDeleted = item.IsDeleted;

                }
                helperViewModel.Messages = this.mapper.Map<List<RealTimeMessagesViewModel>>(item.realTimeChats).OrderBy(x => x.CreateOn).ToList();

                viewModel.Add(helperViewModel);
            }

            return viewModel;
        }

        public List<RealTimeMessagesViewModel> GetMessagesOneToOne(int ownerProfil, int otherProfil)
        {
            var data = this.db.RouteChat.Include(x => x.realTimeChats).Where(x => x.CreatorId == ownerProfil && x.SecondProflId == otherProfil).FirstOrDefault();

            if (data == null)
            {
                data = this.db.RouteChat.Include(x => x.realTimeChats).Where(x => x.CreatorId == otherProfil && x.SecondProflId == ownerProfil).FirstOrDefault();

            }

            var viewModel = mapper.Map<List<RealTimeMessagesViewModel>>(data.realTimeChats).Where(x => x.SenderId == otherProfil).ToList();

            return viewModel;
        }

        public void SeenMessages(int id, int id2)
        {
            var mess = this.db.RouteChat.Include(x => x.realTimeChats).Where(x => x.CreatorId == id && x.SecondProflId == id2).FirstOrDefault();

            if (mess == null)
            {
                mess = this.db.RouteChat.Include(x => x.realTimeChats).Where(x => x.CreatorId == id2 && x.SecondProflId == id).FirstOrDefault();
            }


            var username = this.profilService.getProfilByProfilId(id2).UserName;

            foreach (var item2 in mess.realTimeChats.Where(x => x.Sender == this.profilService.getProfilByProfilId(id2).UserName))
            {
                item2.Seen = true;
            }


            this.db.SaveChanges();
        }


    }
}
