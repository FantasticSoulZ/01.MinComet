using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.SnowMaker
{
    public interface ISnowflakeIdMaker
    {
        long NextId(int? workId = null);
    }
}
