using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class RealTimeChat
    {
        public RealTimeChat()
        {

            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public bool Seen { get; set; }

        public string Content { get; set; }

        public DateTime CreateOn { get; set; }    

        public bool IsDeleted { get; set; }

        public bool New { get; set; }

        public string RouteChatId { get; set; }
        public RouteChat RouteChat { get; set; }

    }
}
