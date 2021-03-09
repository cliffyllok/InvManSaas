using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using InvManSaas.Configuration;
using InvManSaas.Web;

namespace InvManSaas.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class InvManSaasDbContextFactory : IDesignTimeDbContextFactory<InvManSaasDbContext>
    {
        public InvManSaasDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<InvManSaasDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            InvManSaasDbContextConfigurer.Configure(builder, configuration.GetConnectionString(InvManSaasConsts.ConnectionStringName));

            return new InvManSaasDbContext(builder.Options);
        }
    }
}
