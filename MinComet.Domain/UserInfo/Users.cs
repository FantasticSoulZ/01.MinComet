using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.UserInfo
{
    public class Users : Entity<int>
    {
        public string Account { get; set; }
        public string UserName { get; set; }

        public string RoleId { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }
    }
}
