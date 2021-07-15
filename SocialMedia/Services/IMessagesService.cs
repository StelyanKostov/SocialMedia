using SocialMedia.ViewModels.Messages;
using SocialMedia.ViewModels.Profil;
using System.Collections.Generic;

namespace SocialMedia.Services
{
    public interface IMessagesService
    {
        public void sentMessages(MessagesViewModel viewModel);

        public List<ProfilViewModel> GetMessagesByProfilId(int myProfilId);
        public List<MessagesViewModel> GetMessagesByOneProfil(int myProfilId, int sendProfilId);

    }
}
