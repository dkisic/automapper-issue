using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AutomapperIssue.Authorization.Roles;
using AutomapperIssue.Authorization.Users;
using AutomapperIssue.MultiTenancy;

namespace AutomapperIssue.EntityFrameworkCore
{
    public class AutomapperIssueDbContext : AbpZeroDbContext<Tenant, Role, User, AutomapperIssueDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AutomapperIssueDbContext(DbContextOptions<AutomapperIssueDbContext> options)
            : base(options)
        {
        }
    }
}
