using SocialMedia.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public interface IMessagesService
    {
        public void sentMessages(MessagesViewModel viewModel);
    }
}
