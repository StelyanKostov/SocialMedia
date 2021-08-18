using System;

namespace SocialMedia.Data
{
    public class RealTimeChat
    {
        public RealTimeChat()
        {

            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Sender { get; set; }
        public bool Seen { get; set; }

        public string Content { get; set; }

        public DateTime CreateOn { get; set; }    

        public bool IsDeleted { get; set; }

        public bool New { get; set; }

        public string RouteChatId { get; set; }
        public RouteChat RouteChat { get; set; }

    }
}
