using SocialMedia.ViewModels.Chat;
using System.Collections.Generic;

namespace SocialMedia.Services.Chat
{
    public interface IRealTimeChatService
    {
        public void AddMessages(string content, int sendProfilId, int recipientProfilId);

        public List<RealTimeChatViewModel> GetMessages(int profilId);

        public void SeenMessages(int id, int id2);

        public void DeletedRealTimeChat(string RouteChatId);
    }
}
