using System.Threading.Tasks;
using AutomapperIssue.Configuration.Dto;

namespace AutomapperIssue.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
