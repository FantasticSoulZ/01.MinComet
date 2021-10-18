using Microsoft.EntityFrameworkCore;
using MinComet.Domain.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MinComet.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class MinCometDbContext : AbpDbContext<MinCometDbContext>
    {
        public DbSet<Users> Users { get; set; }
        public MinCometDbContext(DbContextOptions<MinCometDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
