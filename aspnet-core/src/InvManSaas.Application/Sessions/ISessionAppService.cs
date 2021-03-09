using System.Threading.Tasks;
using Abp.Application.Services;
using InvManSaas.Sessions.Dto;

namespace InvManSaas.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
