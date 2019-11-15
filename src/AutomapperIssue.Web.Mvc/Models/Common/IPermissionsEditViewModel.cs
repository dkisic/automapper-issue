using System.Collections.Generic;
using AutomapperIssue.Roles.Dto;

namespace AutomapperIssue.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}