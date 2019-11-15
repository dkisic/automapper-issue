using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AutomapperIssue.Controllers
{
    public abstract class AutomapperIssueControllerBase: AbpController
    {
        protected AutomapperIssueControllerBase()
        {
            LocalizationSourceName = AutomapperIssueConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
