using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AutomapperIssue.Configuration.Dto;

namespace AutomapperIssue.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AutomapperIssueAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
