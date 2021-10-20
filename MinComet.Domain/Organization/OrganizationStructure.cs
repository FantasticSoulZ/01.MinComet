using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.Organization
{
    /// <summary>
    /// 组织架构
    /// </summary>
    public class OrganizationStructure : Entity<long>
    {
        /// <summary>
        /// 层级名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 上级名称
        /// </summary>
        public long Parent { get; set; }

        /// <summary>
        /// 0 组织架构 1 用户组(属于组织但不属于组织架构)
        /// </summary>
        public int Type { get; set; }

        public int IsValid { get; set; }

        public long OrganizationId { get; set; }
    }
}
