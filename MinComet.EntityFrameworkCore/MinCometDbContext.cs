using Microsoft.EntityFrameworkCore;
using MinComet.Domain.Organization;
using MinComet.Domain.Permission;
using MinComet.Domain.RoleInfo;
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
        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationStructure> OrganizationStructures { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionPerson> PositionPersons { get; set; }
        public DbSet<BasePermission> BasePermissions { get; set; }
        public DbSet<PermisstionRelation> PermisstionRelations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public MinCometDbContext(DbContextOptions<MinCometDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
