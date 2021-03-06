using System;

namespace SocialMedia.Data
{
    public class ChatRooms
    {
        public ChatRooms()
        {

            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string Content { get; set; }

        public int ProfilId { get; set; }
        public virtual Profils Profil { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
