using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.SnowMaker
{
    public static class SnowflakeDependencyInjection
    {
        public static IServiceCollection AddSnowflake(this IServiceCollection service, Action<SnowOption> option)
        {
            service.Configure(option);
            service.AddSingleton<ISnowflakeIdMaker, SnowflakeIdMaker>();
            return service;
        }
    }
}
