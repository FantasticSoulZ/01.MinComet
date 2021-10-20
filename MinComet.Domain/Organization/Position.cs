using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.Organization
{
    /// <summary>
    /// 职称信息
    /// </summary>
    public class Position: Entity<long>
    {
        /// <summary>
        /// 职位名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 层级ID
        /// </summary>
        public long StructureId { get; set; }

        /// <summary>
        /// 职称重要度 0 最大  
        /// </summary>
        public int Ord { get; set; }

        public int IsValid { get; set; }
    }
}
