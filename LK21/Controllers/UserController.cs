using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.DataAnnotations;

namespace LK20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUser user;
        private readonly IMemoryCache memoryCache;


        public UserController(ILogger<UserController> logger, IUser user, IMemoryCache memoryCache)
        {
            _logger = logger;
            this.user = user;
            this.memoryCache = memoryCache;
        }

        [HttpPost]
        public IUser Post(User user)
        {
            const string key = "test_key";
            var errors = ModelState.Values.SelectMany(x => x.Errors);
            User result;
            if (memoryCache.TryGetValue(key,out result))
            {
                return result;
            }
            else if (ModelState.IsValid)
            {
                memoryCache.Set(key, user);
                return user;
            }
            else
            {
                return null;
            }
        }
        
    }
}