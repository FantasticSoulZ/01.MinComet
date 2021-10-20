using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.SnowMaker
{
    /// <summary>
    /// 配置操作
    /// </summary>
    public class SnowOption
    {
        /// <summary>
        /// 工作机器ID
        /// </summary>
        public int WorkId { get; set; }

        /// <summary>
        /// 工作机器id所占用的长度，最大10，默认10
        /// </summary>
        public int WorkIdLength { get; set; } = 10;

        /// <summary>
        /// 刷新存活状态的间隔时间
        /// </summary>
        public TimeSpan RefreshAliveInterval { get; set; }

        /// <summary>
        /// 用于计算时间戳的开始时间
        /// </summary>
        public DateTime StartTimeStamp { get; set; } = DateTime.Parse("2000-01-01");
    }
}
