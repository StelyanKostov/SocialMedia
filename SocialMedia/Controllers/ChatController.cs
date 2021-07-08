using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class ChatController :Controller
    {
        public ChatController()
        {
          
        }
        public IActionResult Index()
        {

            return this.View();
        }
    }
}
