using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services.Chat
{
    public interface IChatRoomsService
    {
        public void AddMessages(int profilId , string content);

        public List<ChatRooms> GetAllMessages();
    }
}
