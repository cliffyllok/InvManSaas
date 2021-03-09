using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InvManSaas.Authorization.Roles;
using InvManSaas.Authorization.Users;
using InvManSaas.MultiTenancy;

namespace InvManSaas.EntityFrameworkCore
{
    public class InvManSaasDbContext : AbpZeroDbContext<Tenant, Role, User, InvManSaasDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public InvManSaasDbContext(DbContextOptions<InvManSaasDbContext> options)
            : base(options)
        {
        }
    }
}
