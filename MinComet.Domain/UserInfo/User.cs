using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.UserInfo
{
    public class User : Entity<long>
    {
        /// <summary>
        /// 登录账号(自定义)
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码密文
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 账号加密盐
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// 账号有效性
        /// </summary>
        public int IsValid { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNum { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string EmailAdress { get; set; }

        public long SaasId { get; set; }
    }
}
