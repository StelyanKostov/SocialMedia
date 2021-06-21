using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var profil = this.db.Profils.Include(x => x.Messages).Where(x => x.id == viewModel.ProfilId).FirstOrDefault();

            var mapProfil = _mapper.Map<Messages>(viewModel);

            mapProfil.Seen = false;
            mapProfil.CreateOn = DateTime.Now;

            profil.Messages.Add(mapProfil);

            this.db.SaveChanges();

        }
    }
}
