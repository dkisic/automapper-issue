using Abp.MultiTenancy;
using AutomapperIssue.Authorization.Users;

namespace AutomapperIssue.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
