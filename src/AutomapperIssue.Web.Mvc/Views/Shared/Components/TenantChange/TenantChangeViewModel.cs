using Abp.AutoMapper;
using AutomapperIssue.Sessions.Dto;

namespace AutomapperIssue.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
