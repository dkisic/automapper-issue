using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using AutomapperIssue.Authorization;
using AutomapperIssue.Controllers;
using AutomapperIssue.MultiTenancy;
using AutomapperIssue.MultiTenancy.Dto;

namespace AutomapperIssue.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : AutomapperIssueControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _tenantAppService.GetAllAsync(new PagedTenantResultRequestDto { MaxResultCount = int.MaxValue }); // Paging not implemented yet
            return View(output);
        }

        public async Task<ActionResult> EditTenantModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.GetAsync(new EntityDto(tenantId));
            return View("_EditTenantModal", tenantDto);
        }
    }
}
