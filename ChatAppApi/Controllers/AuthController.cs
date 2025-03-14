using Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IChatAppUnitOfWork _chatUow;

        public AuthController(IChatAppUnitOfWork chatUow)
        {
            _chatUow = chatUow;
        }

    }
}
