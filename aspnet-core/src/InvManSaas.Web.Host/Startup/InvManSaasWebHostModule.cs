using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvManSaas.Configuration;

namespace InvManSaas.Web.Host.Startup
{
    [DependsOn(
       typeof(InvManSaasWebCoreModule))]
    public class InvManSaasWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public InvManSaasWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InvManSaasWebHostModule).GetAssembly());
        }
    }
}
