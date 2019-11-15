using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AutomapperIssue.EntityFrameworkCore
{
    public static class AutomapperIssueDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AutomapperIssueDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AutomapperIssueDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
