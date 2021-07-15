using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Messages;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialMedia.Services
{
    public class MessagesService : IMessagesService
    {
        private readonly ApplicationDbContext db;
        private readonly IProfilService profilService;
        private readonly IMapper _mapper;

        public MessagesService(ApplicationDbContext db  , IProfilService profilService , IMapper mapper)
        {
            this.db = db;
            this.profilService = profilService;
            this._mapper = mapper;
        }
        public void sentMessages(MessagesViewModel viewModel)
        {
            //var profil = this.db.Profils.Include(x => x.Messages).Where(x => x.id == viewModel.ProfilId).FirstOrDefault();

            var mapProfil = _mapper.Map<Messages>(viewModel);

            mapProfil.Seen = false;
            mapProfil.CreateOn = DateTime.Now;

            this.db.Messages.Add(mapProfil);

            this.db.SaveChanges();

        }

        public List<ProfilViewModel> GetMessagesByProfilId(int myProfilId)
        {
            var profilMes = this.db.Profils.Include(x => x.Messages).Include(x=> x.Images).Where(y => y.Messages.Any(x => x.SecondProfilId == myProfilId)).ToList();

            var viewModel = this._mapper.Map<List<ProfilViewModel>>(profilMes);

            return viewModel;

        }

        public List<MessagesViewModel> GetMessagesByOneProfil(int myProfilId , int sendProfilId)
        {
            var mes = this.db.Messages.Include(x => x.Profil).Include(x => x.Profil.Images).Where(x => x.ProfilId == myProfilId && x.SecondProfilId == sendProfilId).ToList();
            var mes2 = this.db.Messages.Include(x => x.Profil).Include(x=> x.Profil.Images).Where(x => x.ProfilId == sendProfilId && x.SecondProfilId == myProfilId).ToList();

            var viewModel = this._mapper.Map<List<MessagesViewModel>>(mes);

            var viewModel2 = this._mapper.Map<List<MessagesViewModel>>(mes2);

            viewModel.AddRange(viewModel2);

            return viewModel;
        }
    }
}
