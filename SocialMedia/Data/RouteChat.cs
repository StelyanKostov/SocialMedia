using System;
using System.Collections.Generic;

namespace SocialMedia.Data
{
    public class RouteChat
    {
        public RouteChat()
        {

            this.Id = Guid.NewGuid().ToString();
            this.realTimeChats = new HashSet<RealTimeChat>();
        }
        public string Id { get; set; }

        public int CreatorId { get; set; }
        public Profils Creator { get; set; }

        public int SecondProflId { get; set; }
        

        public ICollection<RealTimeChat> realTimeChats { get; set; } 
    }
}
