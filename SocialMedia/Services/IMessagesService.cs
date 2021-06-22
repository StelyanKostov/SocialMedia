using SocialMedia.ViewModels.Messages;
using SocialMedia.ViewModels.Profil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public interface IMessagesService
    {
        public void sentMessages(MessagesViewModel viewModel);

        public List<ProfilViewModel> GetMessagesByProfilId(int myProfilId);
        public List<MessagesViewModel> GetMessagesByOneProfil(int myProfilId, int sendProfilId);

    }
}
