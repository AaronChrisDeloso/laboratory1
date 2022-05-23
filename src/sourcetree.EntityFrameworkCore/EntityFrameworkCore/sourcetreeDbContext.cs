using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using sourcetree.Authorization.Roles;
using sourcetree.Authorization.Users;
using sourcetree.MultiTenancy;

namespace sourcetree.EntityFrameworkCore
{
    public class sourcetreeDbContext : AbpZeroDbContext<Tenant, Role, User, sourcetreeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public sourcetreeDbContext(DbContextOptions<sourcetreeDbContext> options)
            : base(options)
        {
        }
    }
}
