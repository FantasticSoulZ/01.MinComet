using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinComet.CommonHelper.SnowMaker
{
    public class SnowflakeBackgroundServices : BackgroundService
    {
        private readonly ISnowflakeIdMaker _idMaker;
        private readonly SnowOption option;
        public SnowflakeBackgroundServices(ISnowflakeIdMaker idMaker, IOptions<SnowOption> options)
        {
            _idMaker = idMaker;
            option = options.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (!stoppingToken.IsCancellationRequested)
            {
                while (true)
                {
                    //定时刷新机器id的存活状态
                    await Task.Delay(option.RefreshAliveInterval.Add(TimeSpan.FromMinutes(1)), stoppingToken);
                }

            }
        }
    }
}
