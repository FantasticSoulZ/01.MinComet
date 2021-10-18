using Microsoft.AspNetCore.Mvc;
using MinComet.Application.UserInfo;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc;

namespace MinComet.Api.Controllers.Home
{
    [Route("api/[Controller]")]
    //[ApiController]
    public class LoginController : AbpController//,IApplicationService
    {
        IUserService _userService { get; set; }
        //Login(IUserService userService) {
        //    _userService = userService;
        //}


        [HttpGet]
        public string Test() {
            return "hello world";
        }

        [HttpPost]
        public async Task<object> DoLogin()//UserDto user) 
        {
            //return _userService.Login(user.Account, user.Password);
            return "test";
        }

        [HttpPost]
        [Route("register")]
        public async Task<bool> DoRegister()//UserDto user)
        {
            //return _userService.Register(user);
            return true;
        }
    }
}
