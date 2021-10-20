using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.Permission
{
    public class BasePermission: Entity<long>
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 0 菜单权限 1 按钮权限
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 路径信息
        /// </summary>
        public string Url { get; set; }

        public int IsValid { get; set; }

        public long SaasId { get; set; }
    }
}
