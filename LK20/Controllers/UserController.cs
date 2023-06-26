using Microsoft.AspNetCore.Mvc;

namespace LK20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUser user;
        private readonly List<IUser> users = new List<IUser>();


        public UserController(ILogger<UserController> logger, IUser user)
        {
            _logger = logger;
            this.user = user;
            User test_user = new User() { UserId = 10, Name = "test" , Age = 1};
            users.Add(test_user);
        }

        [HttpGet]
        public IEnumerable<IUser> Get()
        {
            User new_user_1 = new User() { UserId = 1, Name = "Test_Name_1", Age = 42 };
            User new_user_2 = new User() { UserId = 2, Name = "Test_Name_2", Age = 25 };
            User new_user_3 = new User() { UserId = 3, Name = "Test_Name_3", Age = 71 };
            User new_user_4 = new User() { UserId = 4, Name = "Test_Name_4", Age = 11 };
            users.Add(new_user_1);
            users.Add(new_user_2);
            users.Add(new_user_3);
            users.Add(new_user_4);
            return users;
        }
        [HttpPost("/UserId")]
        public IUser Post(int UserId)
        {
            var user = users.FirstOrDefault(x => x.UserId == UserId);
            return user;
        }
        [HttpPut("/UserId")]
        public IUser Put(int UserId, string name, int age)
        {
            var user = users.FirstOrDefault(x => x.UserId == UserId);
            user.Name = name;
            user.Age = age;
            return user;
        }
        [HttpDelete("/UserId")]
        public IUser Delete(int UserId)
        {
            var user = users.FirstOrDefault(x => x.UserId == UserId);
            users.Remove(user);
            return user;
        }
    }
}