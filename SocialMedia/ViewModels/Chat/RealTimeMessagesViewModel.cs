using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Chat
{
    public class RealTimeMessagesViewModel
    {
        public string Content { get; set; }

        public bool New { get; set; }

        public bool Seen { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
