using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AutomapperIssue.Authorization.Roles;
using AutomapperIssue.Authorization.Users;
using AutomapperIssue.MultiTenancy;
using AutomapperIssue.Partners;

namespace AutomapperIssue.EntityFrameworkCore
{
    public class AutomapperIssueDbContext : AbpZeroDbContext<Tenant, Role, User, AutomapperIssueDbContext>
    {
        public DbSet<Partner> Partners { get; set; }

        public AutomapperIssueDbContext(DbContextOptions<AutomapperIssueDbContext> options)
            : base(options)
        {
        }
    }
}
