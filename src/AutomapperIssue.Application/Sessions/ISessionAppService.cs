using System.Threading.Tasks;
using Abp.Application.Services;
using AutomapperIssue.Sessions.Dto;

namespace AutomapperIssue.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
