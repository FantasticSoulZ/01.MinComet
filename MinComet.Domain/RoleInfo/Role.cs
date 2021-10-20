using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.RoleInfo
{
    /// <summary>
    /// 角色信息
    /// </summary>
    public class Role : Entity<long>
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 0:系统角色 1:组织下角色 暂定
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        public long OrganizationId { get; set; }

        public int IsValid { get; set; }

        public long SaasId { get; set; }
    }
}
