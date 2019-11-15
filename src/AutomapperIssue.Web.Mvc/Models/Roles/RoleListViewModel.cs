using System.Collections.Generic;
using AutomapperIssue.Roles.Dto;

namespace AutomapperIssue.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
