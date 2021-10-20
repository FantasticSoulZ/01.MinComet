using Microsoft.AspNetCore.Mvc;
using MinComet.Application.UserInfo;
using MinComet.CommonHelper.SnowMaker;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc;

namespace MinComet.Api.Controllers.Home
{
    [Route("api/[Controller]")]
    //[ApiController]
    public class Login : AbpController//,IApplicationService
    {
        IUserService _userService { get; set; }

        ISnowflakeIdMaker _idMaker { get; set; }
        public Login(IUserService userService, ISnowflakeIdMaker idMaker)
        {
            _userService = userService;
            _idMaker = idMaker;
        }


        [HttpGet]
        public string Test() {
            return "hello world";
        }

        [HttpPost]
        public async Task<object> DoLogin(UserDto user) 
        {
            return await _userService.Login(user.Account, user.Password);
            //return "test";
        }

        [HttpPost]
        [Route("register")]
        public async Task<bool> DoRegister(UserDto user)
        {
            return await _userService.Register(user);
            //return true;
        }

        [HttpGet]
        [Route("getId")]
        public long getId()
        {
            return _idMaker.NextId();
            //return true;
        }
    }
}
