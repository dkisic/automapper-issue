using Abp.AutoMapper;
using AutomapperIssue.Roles.Dto;
using AutomapperIssue.Web.Models.Common;

namespace AutomapperIssue.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
