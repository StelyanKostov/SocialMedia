using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Chat
{
    public class RealTimeChatViewModel
    {
        public List<RealTimeMessagesViewModel> Messages { get; set; }

        public int WithProfilId { get; set; }

        public string WithProfilUserName { get; set; }
        


    }
}
