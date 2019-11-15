using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AutomapperIssue.MultiTenancy;

namespace AutomapperIssue.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
