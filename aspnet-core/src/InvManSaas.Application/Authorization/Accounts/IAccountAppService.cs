using System.Threading.Tasks;
using Abp.Application.Services;
using InvManSaas.Authorization.Accounts.Dto;

namespace InvManSaas.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
