using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvManSaas.Authorization;

namespace InvManSaas
{
    [DependsOn(
        typeof(InvManSaasCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class InvManSaasApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<InvManSaasAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(InvManSaasApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
