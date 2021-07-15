using System.Collections.Generic;

namespace SocialMedia.ViewModels.Chat
{
    public class RealTimeChatViewModel
    {
        public List<RealTimeMessagesViewModel> Messages { get; set; }

        public int WithProfilId { get; set; }

        public string WithProfilUserName { get; set; }
        


    }
}
