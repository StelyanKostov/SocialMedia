using SocialMedia.Data;
using System.Collections.Generic;

namespace SocialMedia.Services.Chat
{
    public interface IChatRoomsService
    {
        public void AddMessages(int profilId , string content);

        public List<ChatRooms> GetAllMessages();
    }
}
