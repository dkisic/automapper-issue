using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AutomapperIssue.MultiTenancy.Dto;

namespace AutomapperIssue.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

