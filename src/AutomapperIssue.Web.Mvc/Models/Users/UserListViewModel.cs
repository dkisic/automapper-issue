using System.Collections.Generic;
using AutomapperIssue.Roles.Dto;
using AutomapperIssue.Users.Dto;

namespace AutomapperIssue.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
