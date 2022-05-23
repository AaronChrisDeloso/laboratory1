using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using sourcetree.Configuration.Dto;

namespace sourcetree.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : sourcetreeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
