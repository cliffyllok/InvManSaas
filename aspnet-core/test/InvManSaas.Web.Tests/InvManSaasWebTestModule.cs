using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvManSaas.EntityFrameworkCore;
using InvManSaas.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace InvManSaas.Web.Tests
{
    [DependsOn(
        typeof(InvManSaasWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class InvManSaasWebTestModule : AbpModule
    {
        public InvManSaasWebTestModule(InvManSaasEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InvManSaasWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(InvManSaasWebMvcModule).Assembly);
        }
    }
}