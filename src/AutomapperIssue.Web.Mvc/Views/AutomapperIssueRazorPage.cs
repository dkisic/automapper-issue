using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AutomapperIssue.Web.Views
{
    public abstract class AutomapperIssueRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AutomapperIssueRazorPage()
        {
            LocalizationSourceName = AutomapperIssueConsts.LocalizationSourceName;
        }
    }
}
