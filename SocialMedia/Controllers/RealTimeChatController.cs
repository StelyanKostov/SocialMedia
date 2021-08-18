using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Data;
using SocialMedia.Services;
using SocialMedia.Services.Chat;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    [Authorize]
    public class RealTimeChatController : Controller
    {
        private readonly IRealTimeChatService realTimeChatService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProfilService profilService;
        private readonly IHttpContextAccessor httpContextAccessor;

        public RealTimeChatController(IRealTimeChatService realTimeChatService ,
            UserManager<ApplicationUser> userManager ,
            IProfilService profilService,
             IHttpContextAccessor httpContextAccessor)
        {
            this.realTimeChatService = realTimeChatService;
            this.userManager = userManager;
            this.profilService = profilService;
            this.httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            var id = this.userManager.GetUserId(this.User);
            var profilId = this.profilService.getProfilByUserId(id).id;

            var viewModel = realTimeChatService.GetMessages(profilId);
            return this.View(viewModel);
        }

        
        public IActionResult SeenMessages([FromQuery]int id2)
        {
            var id = this.userManager.GetUserId(this.User);
            var profilId = this.profilService.getProfilByUserId(id).id;

            this.realTimeChatService.SeenMessages(profilId, id2);
            return this.Json(new { });
        }

        //public async Task GetUpdateForSeenMessages(int id)
        //{
        //    var context = this.httpContextAccessor.HttpContext;
        //    if (!context.WebSockets.IsWebSocketRequest)
        //    {
        //        context.Response.StatusCode = 400;
        //        return;
        //    }

        //    var webSocket = await context.WebSockets.AcceptWebSocketAsync();
        //    CheckResult result;
        //    do
        //    {
        //        result = this.orderService.GetUpdate(id);
        //        if (result.New)
        //        {
        //            var jsonMessage = $"\"{result.Update}\"";
        //            var byteMessage = Encoding.UTF8.GetBytes(jsonMessage);
        //            await webSocket.SendAsync(
        //                buffer: new ArraySegment<byte>(byteMessage, 0, byteMessage.Length),
        //                messageType: WebSocketMessageType.Text,
        //                endOfMessage: true,
        //                cancellationToken: CancellationToken.None);
        //        }
        //    }
        //    while (!result.Finished);
        //    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Done", CancellationToken.None);
        //}

    }

   
}
