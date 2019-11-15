using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AutomapperIssue.Configuration;
using AutomapperIssue.Web;

namespace AutomapperIssue.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AutomapperIssueDbContextFactory : IDesignTimeDbContextFactory<AutomapperIssueDbContext>
    {
        public AutomapperIssueDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AutomapperIssueDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AutomapperIssueDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AutomapperIssueConsts.ConnectionStringName));

            return new AutomapperIssueDbContext(builder.Options);
        }
    }
}
