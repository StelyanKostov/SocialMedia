using System.Collections.Generic;

namespace SocialMedia.ViewModels.Chat
{
    public class RealTimeChatViewModel
    {

        public string Id { get; set; }
        public List<RealTimeMessagesViewModel> Messages { get; set; }

        public int WithProfilId { get; set; }

        public string WithProfilUserName { get; set; }

        public bool IsDeleted { get; set; }



    }
}
