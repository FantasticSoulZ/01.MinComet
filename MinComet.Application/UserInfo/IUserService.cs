using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinComet.Application.UserInfo
{
    public interface IUserService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password">明文密码</param>
        /// <returns></returns>
        public Task<object> Login(string account,string password);

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> Register(UserDto user);
    }
}
