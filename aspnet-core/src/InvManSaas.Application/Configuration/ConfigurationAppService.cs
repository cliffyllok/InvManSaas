using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using InvManSaas.Configuration.Dto;

namespace InvManSaas.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InvManSaasAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
