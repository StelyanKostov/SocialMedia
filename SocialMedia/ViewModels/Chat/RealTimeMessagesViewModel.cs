using System;

namespace SocialMedia.ViewModels.Chat
{
    public class RealTimeMessagesViewModel
    {
        public string Content { get; set; }

        public bool New { get; set; }

        public bool Seen { get; set; }

        public DateTime CreateOn { get; set; }

        public string Sender { get; set; }
        public int SenderId { get; set; }

    }
}
