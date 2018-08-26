using System;
using System.Linq;
using System.Threading.Tasks;
using IdentityApi.Data;
using IdentityApi.Models;
using IdentityApi.Utils;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private TestContext  _context;

        public UsersController(TestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            using (_context)
            {
                var users = _context.Users.ToArray();
                if (users.Length == 0)
                {
                    return NotFound(new FailedRes());
                }
                return Ok(new SuccessRes(users));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegisterDto dto)
        {
            using (_context)
            {
                var hasUser = _context.Users.SingleOrDefault(u => u.Login.Equals(dto.Login));
                if (hasUser != null)
                {
                    return BadRequest(new FailedRes("request:register again"));
                }
                var salt = CryptoUtil.CreateSalt(10);
                var encode = CryptoUtil.Encrypt(dto.Password, salt);
                var user = new User
                {
                    Id = Guid.NewGuid().ToString().Replace("-", ""),
                    Login = dto.Login,
                    Password = encode,
                    Salt = salt,
                    UtcCreated = DateTime.UtcNow,
                    UtcUpdated = DateTime.UtcNow
                };
                await _context.Users.AddAsync(user);
                if (await _context.SaveChangesAsync() <= 0)
                {
                    return NotFound(new FailedRes("request:failed in db"));
                }
                return Ok(new SuccessRes(user.Id));
            }
        }
    }
}
