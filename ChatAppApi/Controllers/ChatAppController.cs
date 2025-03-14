using Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatAppController : ControllerBase
    {
        private readonly IChatAppUnitOfWork _chatUow;
        public ChatAppController(IChatAppUnitOfWork chatUow)
        {
            _chatUow = chatUow;
        }
    }
}
