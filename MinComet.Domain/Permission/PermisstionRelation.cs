using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.Domain.Permission
{
    public class PermisstionRelation
    {
        /// <summary>
        /// 租户id
        /// </summary>
        public long SaasId { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        public long PermissionId { get; set; }

        /// <summary>
        /// 0 角色 1 组织 2 用户组
        /// </summary>
        public int Type { get; set; }

        public long RelationId { get; set; }
    }
}
