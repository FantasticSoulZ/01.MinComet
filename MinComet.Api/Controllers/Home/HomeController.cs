using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace MinComet.Api.Controllers.Home
{
    [Route("api/[Controller]")]
    public class HomeController : AbpController
    {
        [HttpGet]
        public string Test()
        {
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
