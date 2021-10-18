using System;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MinComet.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule)
        )]
    public class MinCometDomainModule : AbpModule
    {
    }
}
