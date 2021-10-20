using MinComet.CommonHelper.Result;
using MinComet.CommonHelper.Utils;
using MinComet.Domain.UserInfo;
using MinComet.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MinComet.Application.UserInfo
{
    public class UserService : ApplicationService, IUserService
    {
        private IRepository<User> _userRepository;

        //private readonly MinCometDbContext _minCometDbContext;

        //public UserService(MinCometDbContext minCometDbContext) {
        //    this._minCometDbContext = minCometDbContext;
        //}

        public UserService(IRepository<User> userRepository) {
            this._userRepository = userRepository;
        }
        public async Task<object> Login(string account, string password)
        {
            var users = await _userRepository.GetListAsync(m => m.Account == account);
            if (users == null || users.Count <= 0)
            {
                return Result.Fail("账号不存在");
            }

            foreach (var user in users) {
                var afterpwd = UtilsHelper.GetMD5Text(password + user.Salt);
                if (user.Password != UtilsHelper.GetMD5Text(password + user.Salt))
                    continue;

                return Result.Success("登录成功");
            }

            return Result.Fail("密码错误");
        }

        public async Task<bool> Register(UserDto userDto)
        {
            try
            {
                User user = new User();
                user.Account = userDto.Account;
                user.UserName = userDto.UserName;
                user.Salt = UtilsHelper.GetRandomStr(8);
                user.Password = UtilsHelper.GetMD5Text(userDto.Password + user.Salt);

                await _userRepository.InsertAsync(user);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
