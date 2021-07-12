using SocialMedia.Data;
using SocialMedia.ViewModels.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services.Chat
{
    public interface IRealTimeChatService
    {
        public void AddMessages(string content, int sendProfilId, int recipientProfilId);

        public List<RealTimeChatViewModel> GetMessages(int profilId);
    }
}
