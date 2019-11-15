using Abp.AspNetCore.Mvc.ViewComponents;

namespace AutomapperIssue.Web.Views
{
    public abstract class AutomapperIssueViewComponent : AbpViewComponent
    {
        protected AutomapperIssueViewComponent()
        {
            LocalizationSourceName = AutomapperIssueConsts.LocalizationSourceName;
        }
    }
}
