using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AutomapperIssue.Roles.Dto;
using AutomapperIssue.Users.Dto;

namespace AutomapperIssue.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
