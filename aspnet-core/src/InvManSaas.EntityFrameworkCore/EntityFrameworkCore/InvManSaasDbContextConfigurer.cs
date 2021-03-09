using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace InvManSaas.EntityFrameworkCore
{
    public static class InvManSaasDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InvManSaasDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InvManSaasDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
