using System.Threading.Tasks;
using InvManSaas.Configuration.Dto;

namespace InvManSaas.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
