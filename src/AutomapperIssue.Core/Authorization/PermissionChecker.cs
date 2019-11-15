using Abp.Authorization;
using AutomapperIssue.Authorization.Roles;
using AutomapperIssue.Authorization.Users;

namespace AutomapperIssue.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
