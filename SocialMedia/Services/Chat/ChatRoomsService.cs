using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services.Chat
{
    public class ChatRoomsService : IChatRoomsService
    {
        private readonly ApplicationDbContext db;

        public ChatRoomsService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddMessages(int profilId, string content)
        {
            this.db.ChatRooms.Add(new ChatRooms
            {
                Content = content,
                ProfilId = profilId,
                CreatedOn = DateTime.Now
                
            });
            this.db.SaveChanges();
        }

        public List<ChatRooms> GetAllMessages()
        {
            var messagess = this.db.ChatRooms.Include(x=> x.Profil).ToList();

            return messagess.OrderBy(x=> x.CreatedOn).ToList();
        }
    }
}
