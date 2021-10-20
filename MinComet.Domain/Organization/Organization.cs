using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MinComet.Domain.Organization
{
    /// <summary>
    /// 组织信息
    /// </summary>
    public class Organization : Entity<long>
    {
        /// <summary>
        /// 组织名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备用联系方式
        /// </summary>
        public string PhoneEx { get; set; }

        /// <summary>
        /// 持有人id
        /// </summary>
        public long Holder { get; set; }

        public int IsValid { get; set; }

        public long SaasId { get; set; }
    }
}
