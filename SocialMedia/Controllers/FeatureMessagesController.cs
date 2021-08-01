using Microsoft.AspNetCore.Mvc;
using SocialMedia.Services.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{

    public class FeatureMessagesController : Controller
    {
        private readonly IRealTimeChatService realTimeChatService;

        public FeatureMessagesController(IRealTimeChatService realTimeChatService)
        {
            this.realTimeChatService = realTimeChatService;
        }

        
        [HttpPost]
        public IActionResult DeltedRouteChat([FromBody]string routeId)
        {
            realTimeChatService.DeletedRealTimeChat(routeId);

            return this.Json(new { });
        }
    }
}
