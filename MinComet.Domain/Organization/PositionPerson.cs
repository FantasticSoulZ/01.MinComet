using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.Organization
{
    public class PositionPerson: Entity<long>
    {
        /// <summary>
        /// 职称id
        /// </summary>
        public long PositionId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public long PersonId { get; set; }

        public int IsValid { get; set; }

        public long SaasId { get; set; }
    }
}
