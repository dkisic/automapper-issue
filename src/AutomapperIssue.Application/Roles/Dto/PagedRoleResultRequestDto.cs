using Abp.Application.Services.Dto;

namespace AutomapperIssue.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

