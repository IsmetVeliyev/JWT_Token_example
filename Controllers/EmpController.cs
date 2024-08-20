using JWT_Token_example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Token_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        [HttpGet]
        [Route("GetData")]
        [Authorize]
        public string GetData()
        {
            return "Authenticated with JWT";
        }

        [HttpGet]
        [Route("Details")]
        [Authorize]
        public string Details()
        {
            return "Authenticated with JWT";
        }

       [Authorize]
        [HttpPost]
        [Authorize]
        public string AddUser(Users user)
        {
            return "User added with username" + user.Username;
        }
    }
}
